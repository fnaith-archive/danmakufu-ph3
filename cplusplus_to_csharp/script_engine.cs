public class script_engine
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public string command_kind_to_name(script_engine.command_kind the_command)
    {
        switch (the_command)
        {
            case pc_assign:
                return "pc_assign";
            case pc_assign_writable:
                return "pc_assign_writable";
            case pc_break_loop:
                return "pc_break_loop";
            case pc_break_routine:
                return "pc_break_routine";
            case pc_call:
                return "pc_call";
            case pc_call_and_push_result:
                return "pc_call_and_push_result";
            case pc_case_begin:
                return "pc_case_begin";
            case pc_case_end:
                return "pc_case_end";
            case pc_case_if:
                return "pc_case_if";
            case pc_case_if_not:
                return "pc_case_if_not";
            case pc_case_next:
                return "pc_case_next";
            case pc_compare_e:
                return "pc_compare_e";
            case pc_compare_g:
                return "pc_compare_g";
            case pc_compare_ge:
                return "pc_compare_ge";
            case pc_compare_l:
                return "pc_compare_l";
            case pc_compare_le:
                return "pc_compare_le";
            case pc_compare_ne:
                return "pc_compare_ne";
            case pc_dup:
                return "pc_dup";
            case pc_dup2:
                return "pc_dup2";
            case pc_loop_ascent:
                return "pc_loop_ascent";
            case pc_loop_back:
                return "pc_loop_back";
            case pc_loop_count:
                return "pc_loop_count";
            case pc_loop_descent:
                return "pc_loop_descent";
            case pc_loop_if:
                return "pc_loop_if";
            case pc_pop:
                return "pc_pop";
            case pc_push_value:
                return "pc_push_value";
            case pc_push_variable:
                return "pc_push_variable";
            case pc_push_variable_writable:
                return "pc_push_variable_writable";
            case pc_swap:
                return "pc_swap";
            case pc_yield:
                return "pc_yield";
            default:
                return "pc_????";
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public script_engine(script_type_manager a_type_manager, string source, int funcc, function funcv)
    {
        this.type_manager = a_type_manager;
           main_block = new_block(0, bk_normal);
    
    // C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
    // ORIGINAL LINE: const char* end = &source[0] + source.size();
           char end = source[0] + source.Length;
           scanner s = new scanner(source, end);
           parser p = new parser(this, s, funcc, funcv);
    
           events = p.events;
    
           error = p.error;
           error_message = p.error_message;
           error_line = p.error_line;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public script_engine(script_type_manager a_type_manager, List<char> source, int funcc, function funcv)
    {
        this.type_manager = a_type_manager;
           main_block = new_block(0, bk_normal);
    
           if (false)
           {
               string pStart = (string) source[0];
    // C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
    // ORIGINAL LINE: char* pEnd = (char*)(&source[0] + min(source.size(), 64));
               char pEnd = (string)(source[0] + System.Math.Min(source.Count, 64));
               string str = new string(pStart, pEnd);
               // Logger::WriteTop(str);
           }
    // C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
    // ORIGINAL LINE: const char* end = &source[0] + source.size();
           char end = source[0] + source.Count;
           scanner s = new scanner(source[0], end);
           parser p = new parser(this, s, funcc, funcv);
    
           events = p.events;
    
           error = p.error;
           error_message = p.error_message;
           error_line = p.error_line;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Dispose()
    {
        blocks.clear();
    }
}