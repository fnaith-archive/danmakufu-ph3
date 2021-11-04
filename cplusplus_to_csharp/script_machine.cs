public class script_machine
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public script_machine(script_engine the_engine)
    {
        Debug.Assert(!the_engine.get_error());
        engine = the_engine;
    
        first_using_environment = null;
        last_using_environment = null;
        first_garbage_environment = null;
        last_garbage_environment = null;
    
        error = false;
        bTerminate = false;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Dispose()
    {
        while (first_using_environment != null)
        {
            environment @object = first_using_environment;
            first_using_environment = first_using_environment.succ;
            @object = null;
        }
    
        while (first_garbage_environment != null)
        {
            environment @object = first_garbage_environment;
            first_garbage_environment = first_garbage_environment.succ;
            @object = null;
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public script_machine.environment new_environment(environment parent, script_engine.block b)
    {
        environment result = null;
    
        if (first_garbage_environment != null)
        {
            // ���݉��
            result = first_garbage_environment;
            first_garbage_environment = result.succ;
            * ((result.succ != null) ? & result.succ.pred : & last_garbage_environment) = result.pred;
        }
    
        if (result == null)
        {
    // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
            result = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) environment;
        }
    
        result.parent = parent;
        result.ref_count = 1;
        result.sub = b;
        result.ip = 0;
        result.variables.release();
        result.stack.length = 0;
        result.has_result = false;
    
        // �g�p??�X�g�ւ̒ǉ�
        result.pred = last_using_environment;
        result.succ = null;
        * ((result.pred != null) ? & result.pred.succ : & first_using_environment) = result;
        last_using_environment = result;
    
        return result;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void dispose_environment(environment @object)
    {
        Debug.Assert(@object.ref_count == 0);
    
        // �g�p??�X�g����̍�?
        * ((@object.pred != null) ? & @object.pred.succ : & first_using_environment) = @object.succ;
        * ((@object.succ != null) ? & @object.succ.pred : & last_using_environment) = @object.pred;
    
        // ����?�X�g�ւ̒ǉ�
        @object.pred = last_garbage_environment;
        @object.succ = null;
        * ((@object.pred != null) ? & @object.pred.succ : & first_garbage_environment) = @object;
        last_garbage_environment = @object;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void run()
    {
        if (bTerminate)
        {
            return;
        }
    
        Debug.Assert(!error);
        if (first_using_environment == null)
        {
            error_line = -1;
            threads.clear();
            threads.push_back(new_environment(null, engine.main_block));
            current_thread_index = 0;
            finished = false;
            stopped = false;
            resuming = false;
    
            while (!finished && !bTerminate)
            {
                advance();
            }
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void resume()
    {
        if (bTerminate)
        {
            return;
        }
    
        Debug.Assert(!error);
        Debug.Assert(stopped);
        stopped = false;
        finished = false;
        resuming = true;
        while (!finished && !bTerminate)
        {
            advance();
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void call(string event_name)
    {
        if (bTerminate)
        {
            return;
        }
    
        Debug.Assert(!error);
        Debug.Assert(!stopped);
        if (engine.events.find(event_name) != engine.events.end())
        {
            run(); // �O�̂���
    
            int threadIndex = current_thread_index;
            current_thread_index = 0;
    
            script_engine.block @event = engine.events[event_name];
            ++(threads[0].ref_count);
            threads[0] = new_environment(threads[0], @event);
    
            finished = false;
            environment epp = threads[0].parent.parent;
            call_start_parent_environment_list.push_back(epp);
            while (!finished && !bTerminate)
            {
                advance();
            }
            call_start_parent_environment_list.pop_back();
            finished = false;
            current_thread_index = threadIndex;
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public bool has_event(string event_name)
    {
        Debug.Assert(!error);
        return engine.events.find(event_name) != engine.events.end();
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public int get_current_line()
    {
        environment current = threads.at[current_thread_index];
        script_engine.code c = & (current.sub.codes.at[current.ip]);
        return c.line;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void advance()
    {
        Debug.Assert(current_thread_index < threads.length);
        environment current = threads.at[current_thread_index];
    
        if (current.ip >= current.sub.codes.length)
        {
            environment removing = current;
            current = current.parent;
    
            bool bFinish = false;
            if (current == null)
            {
                bFinish = true;
            }
            else
            {
                if (call_start_parent_environment_list.size() > 1)
                {
                    environment env = *call_start_parent_environment_list.rbegin();
                    if (current == env)
                    {
                        bFinish = true;
                    }
                }
            }
    
            if (bFinish)
            {
                finished = true;
            }
            else
            {
                threads[current_thread_index] = current;
    
                if (removing.has_result)
                {
                    Debug.Assert(current != null && removing.variables.length > 0);
                    current.stack.push_back(removing.variables.at[0]);
                }
                else if (removing.sub.kind == script_engine.bk_microthread)
                {
                    threads.erase(threads.begin() + current_thread_index);
                    yield();
                }
    
                Debug.Assert(removing.stack.length == 0);
    
                if (false)
                {
                    ;
                }
                else
                {
                    for (; ;)
                    {
                    --(removing.ref_count);
                    if (removing.ref_count > 0)
                    {
                        break;
                    }
                    environment next = removing.parent;
                    dispose_environment(removing);
                    removing = next;
                    }
                }
            }
        }
        else
        {
            script_engine.code c = & (current.sub.codes.at[current.ip]);
            error_line = c.line; // ��
            ++(current.ip);
    
    #if _TRACE_COMMAND
            Console.Write("M:");
            Console.Write(script_engine.command_kind_to_name(c.command));
            Console.Write("\n");
    #endif
            switch (c.command)
            {
                case script_engine.pc_assign:
                {
                        stack_t stack = current.stack;
                        Debug.Assert(stack.length > 0);
                        if (false)
                        {
                            ;
                        }
                        else
                        {
                            for (environment * i = current; i != null; i = i.parent)
                            {
                            if (i.sub.level == c.level)
                            {
                                variables_t vars = i.variables;
                                if (vars.length <= c.variable)
                                {
                                    while (vars.capacity <= c.variable)
                                    {
                                        vars.expand();
                                    }
                                    vars.length = c.variable + 1;
                                }
                                value dest = & (vars.at[c.variable]);
                                value src = stack.at[stack.length - 1];
                                if (dest.has_data() && dest.get_type() != src.get_type() && !(dest.get_type().get_kind() == type_data.tk_array && src.get_type().get_kind() == type_data.tk_array && (dest.length_as_array() > 0 || src.length_as_array() > 0)))
                                {
                                    string error;
                                    error += "A variable was changing it's value type.\r\n";
                                    error += "(����ɂ���Č^���ς����悤�Ƃ��܂���)";
                                    raise_error(error);
                                }
                                 dest.CopyFrom(src);
                                stack.pop_back();
                                break;
                            }
                            }
                        }
                }
                    break;
    
                case script_engine.pc_assign_writable:
                {
                        stack_t stack = current.stack;
                        Debug.Assert(stack.length >= 2);
                        value dest = stack.at[stack.length - 2];
                        value src = stack.at[stack.length - 1];
                        if (dest.has_data() && dest.get_type() != src.get_type() && !(dest.get_type().get_kind() == type_data.tk_array && src.get_type().get_kind() == type_data.tk_array && (dest.length_as_array() > 0 || src.length_as_array() > 0)))
                        {
                            string error;
                            error += "A variable was changing it's value type.\r\n";
                            error += "(����ɂ���Č^���ς����悤�Ƃ��܂���)";
                            raise_error(error);
                        }
                        else
                        {
                            dest.overwrite(src);
                            stack.pop_back();
                            stack.pop_back();
                            // stack->length -= 2;
                        }
                }
                    break;
    
                case script_engine.pc_break_loop:
                case script_engine.pc_break_routine:
                    if (false)
                    {
                        ;
                    }
                    else
                    {
                        for (environment * i = current; i != null; i = i.parent)
                        {
                        i.ip = i.sub.codes.length;
    
                        if (c.command == script_engine.pc_break_loop)
                        {
                            if (i.sub.kind == script_engine.bk_loop)
                            {
                                environment e = i.parent;
                                Debug.Assert(e != null);
                                do
                                {
                                    ++(e.ip);
                                } while (e.sub.codes.at[e.ip - 1].command != script_engine.pc_loop_back);
                                break;
                            }
                        }
                        else
                        {
                            if (i.sub.kind == script_engine.bk_sub || i.sub.kind == script_engine.bk_function || i.sub.kind == script_engine.bk_microthread)
                            {
                                   break;
                            }
                            else if (i.sub.kind == script_engine.bk_loop)
                            {
                                i.parent.stack.clear(); // ���׍H�������Ƃ���
                            }
                        }
                        }
                    }
                    break;
    
                case script_engine.pc_call:
                case script_engine.pc_call_and_push_result:
                {
                        stack_t current_stack = current.stack;
                        Debug.Assert(current_stack.length >= c.arguments);
                        if (c.sub.func != null)
                        {
                            // �l�C�e�B�u�Ăяo��
                            value argv = & (current_stack.at[current_stack.length - c.arguments]);
                            value ret = new value();
                            ret = c.sub.func(this, c.arguments, argv);
                            if (stopped)
                            {
                                --(current.ip);
                            }
                            else
                            {
                                resuming = false;
                                // �l�܂ꂽ��?����?
                                if (false)
                                {
                                    ;
                                }
                                else
                                {
                                    for (int i = 0; i < c.arguments; ++i) current_stack.pop_back();
                                }
                                // current_stack->length -= c->arguments;
                                // �߂�l
                                if (c.command == script_engine.pc_call_and_push_result)
                                {
                                    current_stack.push_back(ret);
                                }
                            }
                        }
                        else if (c.sub.kind == script_engine.bk_microthread)
                        {
                            // �}�C�N?�X?�b�h�N��
                            ++(current.ref_count);
                            environment e = new_environment(current, c.sub);
                            ++current_thread_index;
                            threads.insert(threads.begin() + current_thread_index, e);
                            // ��?�̐ςݑւ�
                            if (false)
                            {
                                ;
                            }
                            else
                            {
                                for (uint i = 0; i < c.arguments; ++i)
                                {
                                e.stack.push_back(current_stack.at[current_stack.length - 1]);
                                current_stack.pop_back();
                                }
                            }
                        }
                        else
                        {
                            // �X�N?�v�g�Ԃ̌Ăяo��
                            ++(current.ref_count);
                            environment e = new_environment(current, c.sub);
                            e.has_result = c.command == script_engine.pc_call_and_push_result;
                            threads[current_thread_index] = e;
                            // ��?�̐ςݑւ�
                            if (false)
                            {
                                ;
                            }
                            else
                            {
                                for (uint i = 0; i < c.arguments; ++i)
                                {
                                e.stack.push_back(current_stack.at[current_stack.length - 1]);
                                current_stack.pop_back();
                                }
                            }
                        }
                }
                    break;
    
                case script_engine.pc_case_begin:
                case script_engine.pc_case_end:
                    break;
    
                case script_engine.pc_case_if:
                case script_engine.pc_case_if_not:
                case script_engine.pc_case_next:
                {
                        bool exit = true;
                        if (c.command != script_engine.pc_case_next)
                        {
                            stack_t current_stack = current.stack;
                            exit = current_stack.at[current_stack.length - 1].as_boolean();
                            if (c.command == script_engine.pc_case_if_not)
                            {
                                exit = !exit;
                            }
                            current_stack.pop_back();
                        }
                        if (exit)
                        {
                            int nested = 0;
                            if (false)
                            {
                                ;
                            }
                            else
                            {
                                for (; ;)
                                {
                                switch (current.sub.codes.at[current.ip].command)
                                {
                                    case script_engine.pc_case_begin:
                                        ++nested;
                                        break;
                                    case script_engine.pc_case_end:
                                        --nested;
                                        if (nested < 0)
                                        {
                                            goto next;
                                        }
                                        break;
                                    case script_engine.pc_case_next:
                                        if (nested == 0 && c.command != script_engine.pc_case_next)
                                        {
                                            ++(current.ip);
                                            goto next;
                                        }
                                        break;
                                }
                                ++(current.ip);
                                }
                            }
                        next:
    #if _MSC_VER
                            ;
    #endif
                        }
                }
                    break;
    
                case script_engine.pc_compare_e:
                case script_engine.pc_compare_g:
                case script_engine.pc_compare_ge:
                case script_engine.pc_compare_l:
                case script_engine.pc_compare_le:
                case script_engine.pc_compare_ne:
                {
                        stack_t stack = current.stack;
                        value t = stack.at[stack.length - 1];
                        double r = t.as_real();
                        bool b;
                        switch (c.command)
                        {
                            case script_engine.pc_compare_e:
                                b = r == 0;
                                break;
                            case script_engine.pc_compare_g:
                                b = r > 0;
                                break;
                            case script_engine.pc_compare_ge:
                                b = r >= 0;
                                break;
                            case script_engine.pc_compare_l:
                                b = r < 0;
                                break;
                            case script_engine.pc_compare_le:
                                b = r <= 0;
                                break;
                            case script_engine.pc_compare_ne:
                                b = r != 0;
                                break;
                        }
                        t.set(engine.get_boolean_type(), b);
                }
                    break;
    
                case script_engine.pc_dup:
                {
                        stack_t stack = current.stack;
                        Debug.Assert(stack.length > 0);
                        stack.push_back(stack.at[stack.length - 1]);
                }
                    break;
    
                case script_engine.pc_dup2:
                {
                        stack_t stack = current.stack;
                        int len = stack.length;
                        Debug.Assert(len >= 2);
                        stack.push_back(stack.at[len - 2]);
                        stack.push_back(stack.at[len - 1]);
                }
                    break;
    
                case script_engine.pc_loop_back:
                    current.ip = c.ip;
                    break;
    
                case script_engine.pc_loop_ascent:
                {
                        stack_t stack = current.stack;
                        value i = stack.at[stack.length - 1];
                        if (i.as_real() <= 0)
                        {
                            do
                            {
                                ++(current.ip);
                            } while (current.sub.codes.at[current.ip - 1].command != script_engine.pc_loop_back);
                        }
                        current.stack.pop_back();
                }
                    break;
    
                case script_engine.pc_loop_descent:
                {
                        stack_t stack = current.stack;
                        value i = stack.at[stack.length - 1];
                        if (i.as_real() >= 0)
                        {
                            do
                            {
                                ++(current.ip);
                            } while (current.sub.codes.at[current.ip - 1].command != script_engine.pc_loop_back);
                        }
                        current.stack.pop_back();
                }
                    break;
    
                case script_engine.pc_loop_count:
                {
                        stack_t stack = current.stack;
                        value i = stack.at[stack.length - 1];
                        Debug.Assert(i.get_type().get_kind() == type_data.tk_real);
                        double r = i.as_real();
                        if (r > 0)
                        {
                            i.set(engine.get_real_type(), r - 1);
                        }
                        else
                        {
                            do
                            {
                                ++(current.ip);
                            } while (current.sub.codes.at[current.ip - 1].command != script_engine.pc_loop_back);
                        }
                }
                    break;
    
                case script_engine.pc_loop_if:
                {
                        stack_t stack = current.stack;
                        bool c = stack.at[stack.length - 1].as_boolean();
                        current.stack.pop_back();
                        if (!c)
                        {
                            do
                            {
                                ++(current.ip);
                            } while (current.sub.codes.at[current.ip - 1].command != script_engine.pc_loop_back);
                        }
                }
                    break;
    
                case script_engine.pc_pop:
                    Debug.Assert(current.stack.length > 0);
                    current.stack.pop_back();
                    break;
    
                case script_engine.pc_push_value:
                    current.stack.push_back(c.data);
                    break;
    
                case script_engine.pc_push_variable:
                case script_engine.pc_push_variable_writable:
                    if (false)
                    {
                        ;
                    }
                    else
                    {
                        for (environment * i = current; i != null; i = i.parent)
                        {
                        if (i.sub.level == c.level)
                        {
                            variables_t vars = i.variables;
                            if (vars.length <= c.variable || !(vars.at[c.variable].has_data()))
                            {
                                string error;
                                error += "you are using a variable that has not been set yet.\r\n";
                                error += "(����������Ă��Ȃ���?���g�����Ƃ��܂���)";
                                raise_error(error);
                            }
                            else
                            {
                                value @var = vars.at[c.variable];
                                if (c.command == script_engine.pc_push_variable_writable)
                                {
                                    @var.unique();
                                }
                                current.stack.push_back(@var);
                            }
                            break;
                        }
                        }
                    }
                    break;
    
                case script_engine.pc_swap:
                {
                        int len = current.stack.length;
                        Debug.Assert(len >= 2);
                        value t = current.stack[len - 1];
                        current.stack[len - 1] = current.stack[len - 2];
                        current.stack[len - 2] = t;
                }
                    break;
    
                case script_engine.pc_yield:
                    yield();
                    break;
    
                default:
                    Debug.Assert(false);
                    break;
            }
        }
    }
}