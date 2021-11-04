using gstd;
using System;
using System.Collections.Generic;
using System.Diagnostics;

// -------- �ėp
namespace gstd
{
    public class lightweight_vector < T > : System.IDisposable
    {
        public uint length;
        public uint capacity;
        public T[] at;

        public lightweight_vector()
        {
            this.length = 0;
            this.capacity = 0;
            this.at = null;
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        lightweight_vector(lightweight_vector source);

        public void Dispose()
        {
            if (at != null)
            {
                Arrays.DeleteArray(at);
            }
        }

// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: lightweight_vector < T > & lightweight_vector < T >::operator = (lightweight_vector < T > const & source)
        public lightweight_vector < T > & lightweight_vector < T >.CopyFrom (lightweight_vector < T > source)
        {
            if (at != null)
            {
                at = null;
            }
            GlobalMembers.length = source.length;
            capacity = source.capacity;
            if (source.capacity > 0)
            {
                at = Arrays.InitializeWithDefaultInstances<T>(source.capacity);
                for (int i = GlobalMembers.length - 1; i >= 0; --i)
                {
                    at[i] = source.at[i];
                }
            }
            else
            {
                at = null;
            }
            return  this;
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void expand();

        public void push_back(T value)
        {
            if (GlobalMembers.length == capacity)
            {
                expand();
            }
            at[GlobalMembers.length] = value;
            ++GlobalMembers.length;
        }

        public void pop_back()
        {
            --GlobalMembers.length;

            T temp = new default(T);
            at[GlobalMembers.length] = temp;
        }

        public void clear()
        {
            GlobalMembers.length = 0;
        }

        public void release()
        {
            GlobalMembers.length = 0;
            if (at != null)
            {
                at = null;
                at = null;
                capacity = 0;
            }
        }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: uint size() const
        public uint size()
        {
            return GlobalMembers.length;
        }

        public T this [uint i]
        {
            get
            {
                return at[i];
            }
            set
            {
                at[i] = value;
            }
        }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: T const & operator [] (uint i) const
        public T this [uint i]
        {
            get
            {
                return at[i];
            }
            set
            {
                at[i] = value;
            }
        }

        public T back()
        {
            return at[GlobalMembers.length - 1];
        }

        public T begin()
        {
            return  at[0];
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void erase(T pos);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void insert(T pos, T value);
    }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template < typename T >
    public lightweight_vector < T >.lightweight_vector< T >(lightweight_vector source)
    {
        GlobalMembers.length = source.length;
        capacity = source.capacity;
        if (source.capacity > 0)
        {
            at = Arrays.InitializeWithDefaultInstances<T>(source.capacity);
            for (int i = GlobalMembers.length - 1; i >= 0; --i)
            {
                at[i] = source.at[i];
            }
        }
        else
        {
            at = null;
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template < typename T >
    public void lightweight_vector < T >.expand< T >()
    {
        if (capacity == 0)
        {
            // delete[] at;
            capacity = 4;
            at = Arrays.InitializeWithDefaultInstances<T>(4);
        }
        else
        {
            capacity *= 2;
            T[] n = Arrays.InitializeWithDefaultInstances<T>(capacity);
            for (int i = GlobalMembers.length - 1; i >= 0; --i)
            {
                n[i] = at[i];
            }
            at = null;
            at = n;
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template < typename T >
    public void lightweight_vector < T >.erase< T >(T pos)
    {
        --GlobalMembers.length;
        for (T * i = pos; i < at + GlobalMembers.length; ++i)
        {
             i = * (i + 1);
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template < typename T >
    public void lightweight_vector < T >.insert< T >(T pos, T value)
    {
        if (GlobalMembers.length == capacity)
        {
            uint pos_index = pos - at;
            expand();
            pos = at + pos_index;
        }
        for (T * i = at + GlobalMembers.length; i > pos; --i)
        {
             i = * (i - 1);
        }
         pos = value;
        ++GlobalMembers.length;
    }

    // -------- ��������

    public class type_data
    {
        public enum type_kind
        {
            tk_real,
            tk_char,
            tk_boolean,
            tk_array
        }

        public type_data(type_kind k, type_data t = null)
        {
            this.kind = new gstd.type_data.type_kind(k);
            this.element = new gstd.type_data(t);
        }

        public type_data(type_data source)
        {
            this.kind = new gstd.type_data.type_kind(source.kind);
            this.element = new gstd.type_data(source.element);
        }

        // �f�X�g?�N�^�̓f�t�H?�g�ɔC����

        public type_kind get_kind()
        {
            return kind;
        }

        public type_data get_element()
        {
            return element;
        }

        private type_kind kind;
        private type_data[] element;

// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: type_data & operator = (type_data const & source);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        type_data CopyFrom (type_data source);
    }

    public class value : System.IDisposable
    {
#if _TRACE_VALUE
        public static int counter = 0;
        public int id;
#endif
        public value()
        {
            this.data = new gstd.value.body(null);
#if _TRACE_VALUE
            id = -1;
            // if (is_target()) throw std::exception("V1");
#endif
        }

        public value(type_data t, double v)
        {
            data = new body();
            data.ref_count = 1;
            data.type = t;
            data.real_value = v;
#if _TRACE_VALUE
            id = counter++;
            // if (is_target()) throw std::exception("V2");
#endif
        }

        public value(type_data t, char v)
        {
            data = new body();
            data.ref_count = 1;
            data.type = t;
            data.char_value = v;
#if _TRACE_VALUE
            id = counter++;
            // if (is_target()) throw std::exception("V3");
#endif
        }

        public value(type_data t, bool v)
        {
            data = new body();
            data.ref_count = 1;
            data.type = t;
            data.boolean_value = v;
#if _TRACE_VALUE
            id = counter++;
            // if (is_target()) throw std::exception("V4");
#endif
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        value(type_data t, string v);

        public value(value source)
        {
#if _TRACE_VALUE
            if (source.is_target())
            {
                Console.Write("V:assign source ");
                Console.Write((source.id));
                Console.Write("=");
                Console.Write(to_mbcs(source.as_string()));
                Console.Write("\n");
            }
            id = 10000 + source.id;
            // if (is_target()) throw std::exception("V5");
#endif
            data = source.data;
            if (data != null)
            {
                ++(data.ref_count);
            }
        }

        public void Dispose()
        {
            release();
        }

// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: value & operator = (value const & source)
        public value CopyFrom (value source)
        {
#if _TRACE_VALUE
            if (is_target() || source.is_target())
            {
                Console.Write("V:assign this ");
                Console.Write((this.id));
                Console.Write("=");
                Console.Write(to_mbcs(this.as_string()));
                Console.Write("\n");
                Console.Write("V:assign source ");
                Console.Write((source.id));
                Console.Write("=");
                Console.Write(to_mbcs(source.as_string()));
                Console.Write("\n");
            }
            id = source.id;
#endif
            if (source.data != null)
            {
                ++(source.data.ref_count);
            }
            release();
            data = source.data;
            return  this;
        }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool has_data() const
        public bool has_data()
        {
            return data != null;
        }

#if _TRACE_VALUE
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool is_target() const
        public bool is_target()
        {
            return false; // id == 10001;
        }
#endif

        public void set(type_data t, double v)
        {
            unique();
            data.type = t;
            data.real_value = v;
#if _TRACE_VALUE
            if (is_target())
            {
                Console.Write("V:set double ");
                Console.Write(to_mbcs(this.as_string()));
                Console.Write("\n");
            }
#endif
        }

        public void set(type_data t, bool v)
        {
            unique();
            data.type = t;
            data.boolean_value = v;
#if _TRACE_VALUE
            if (is_target())
            {
                Console.Write("V:set bool ");
                Console.Write(to_mbcs(this.as_string()));
                Console.Write("\n");
            }
#endif
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void append(type_data t, value x);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void concatenate(value x);

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: double as_real() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        double as_real();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: char as_char() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        char as_char();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool as_boolean() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        bool as_boolean();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: string as_string() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        string as_string();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: uint length_as_array() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        uint length_as_array();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: value const & index_as_array(uint i) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        value index_as_array(uint i);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        value index_as_array(uint i);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: type_data * get_type() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        type_data get_type();

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: void unique() const
        public void unique()
        {
            if (data == null)
            {
                data = new body();
                data.ref_count = 1;
                data.type = null;
            }
            else if (data.ref_count > 1)
            {
                --(data.ref_count);
                data = new body data;
                data.ref_count = 1;
            }
#if _TRACE_VALUE
            if (is_target())
            {
                Console.Write("V:unique ");
                Console.Write(to_mbcs(this.as_string()));
                Console.Write("\n");
            }
#endif
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void overwrite(value source); //�댯�I�O����ĂԂ�

        private void release()
        {
            if (data != null)
            {
                --(data.ref_count);
                if (data.ref_count == 0)
                {
                    data = null;
                }
            }
        }
        private class body
        {
            public int ref_count;
            public type_data[] type;
            public lightweight_vector< value > array_value = new lightweight_vector< value >();

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//            union
//            {
//                double real_value;
//                char char_value;
//                bool boolean_value;
//            };
        }

        private body[] data;
    }

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class script_engine;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class script_machine;

    public delegate value callback(script_machine machine, int argc, value argv);

    public class function
    {
        public readonly string name;
        public callback func;
        public uint arguments;
    }

    public class script_type_manager
    {
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_type_manager();

        public type_data get_real_type()
        {
            return real_type;
        }

        public type_data get_char_type()
        {
            return char_type;
        }

        public type_data get_boolean_type()
        {
            return boolean_type;
        }

        public type_data get_string_type()
        {
            return string_type;
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        type_data get_array_type(type_data element);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_type_manager(script_type_manager UnnamedParameter);
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: script_type_manager & operator = (script_type_manager const & source);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_type_manager CopyFrom (script_type_manager source);

        private LinkedList< type_data > types = new LinkedList< type_data >(); // ?�g�̃|�C?�^��g���̂ŃA�h?�X���ς��Ȃ��悤��list
        private type_data real_type;
        private type_data char_type;
        private type_data boolean_type;
        private type_data string_type;
    }

    public class script_engine : System.IDisposable
    {
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_engine(script_type_manager a_type_manager, string source, int funcc, function funcv);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_engine(script_type_manager a_type_manager, System.Collections.Generic.List<char> source, int funcc, function funcv);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        public void Dispose();

        public object[] data; // �N?�C�A?�g�p���

        public bool get_error()
        {
            return error;
        }

        public string get_error_message()
        {
            return error_message;
        }

        public int get_error_line()
        {
            return error_line;
        }

        public script_type_manager get_type_manager()
        {
            return type_manager;
        }

        // compatibility
        public type_data get_real_type()
        {
            return type_manager.get_real_type();
        }

        public type_data get_char_type()
        {
            return type_manager.get_char_type();
        }

        public type_data get_boolean_type()
        {
            return type_manager.get_boolean_type();
        }

        public type_data get_array_type(type_data element)
        {
            return type_manager.get_array_type(element);
        }

        public type_data get_string_type()
        {
            return type_manager.get_string_type();
        }

    #if ! _MSC_VER
    #endif

        // �R�s�[�A���?�Z�q�̎��������𖳌���
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_engine(script_engine source);
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: script_engine & operator = (script_engine const & source);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_engine CopyFrom (script_engine source);

        // �G?�[
        private bool error;
        private string error_message = "";
        private int error_line;

        // �^
        private script_type_manager type_manager;

        // ?�ԃR�[�h
        private enum command_kind
        {
            pc_assign,
            pc_assign_writable,
            pc_break_loop,
            pc_break_routine,
            pc_call,
            pc_call_and_push_result,
            pc_case_begin,
               pc_case_end,
               pc_case_if,
               pc_case_if_not,
               pc_case_next,
               pc_compare_e,
               pc_compare_g,
               pc_compare_ge,
               pc_compare_l,
               pc_compare_le,
               pc_compare_ne,
               pc_dup,
               pc_dup2,
               pc_loop_ascent,
               pc_loop_back,
               pc_loop_count,
               pc_loop_descent,
               pc_loop_if,
               pc_pop,
               pc_push_value,
               pc_push_variable,
               pc_push_variable_writable,
               pc_swap,
               pc_yield
        }
#if _TRACE_COMMAND
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        static string command_kind_to_name(command_kind the_command);
#endif

// C++ TO C# CONVERTER TODO TASK: The implementation of the following type could not be found:
//        struct block;

        private class code
        {
            public command_kind command;
            public int line; // �\�[�X�R�[�h��̍s
            public value data = new value(); // pc_push_value��push����f�[�^

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//            union
//            {
//                struct
//                {
//                    int level; //assign/push_variable�̕�?�̊��ʒu
//                    uint variable; //assign/push_variable�̕�?�̃C?�f�b�N�X
//                };
//                struct
//                {
//                    block * sub; //call/call_and_push_result�̔�ѐ�
//                    uint arguments; //call/call_and_push_result�̈�?��?
//                };
//                struct
//                {
//                    int ip; //loop_back�̖߂��
//                };
//            };

            public code()
            {
            }

            public code(int the_line, command_kind the_command)
            {
                this.line = the_line;
                this.command = new gstd.script_engine.command_kind(the_command);
#if _TRACE_COMMAND
                Console.Write("C1:");
                Console.Write(script_engine.command_kind_to_name(the_command));
                Console.Write("\n");
#endif
            }

            public code(int the_line, command_kind the_command, int the_level, uint the_variable)
            {
                this.line = the_line;
                this.command = new gstd.script_engine.command_kind(the_command);
                this.level = the_level;
                this.variable = the_variable;
#if _TRACE_COMMAND
                Console.Write("C2:");
                Console.Write(script_engine.command_kind_to_name(the_command));
                Console.Write("\n");
#endif
            }

            public code(int the_line, command_kind the_command, block the_sub, int the_arguments)
            {
                this.line = the_line;
                this.command = new gstd.script_engine.command_kind(the_command);
                this.sub = the_sub;
                this.arguments = the_arguments;
#if _TRACE_COMMAND
                Console.Write("C3:");
                Console.Write(script_engine.command_kind_to_name(the_command));
                Console.Write("\n");
#endif
            }

            public code(int the_line, command_kind the_command, int the_ip)
            {
                this.line = the_line;
                this.command = new gstd.script_engine.command_kind(the_command);
                this.ip = the_ip;
#if _TRACE_COMMAND
                Console.Write("C4:");
                Console.Write(script_engine.command_kind_to_name(the_command));
                Console.Write("\n");
#endif
            }

            public code(int the_line, command_kind the_command, value the_data)
            {
                this.line = the_line;
                this.command = new gstd.script_engine.command_kind(the_command);
                this.data = new gstd.value(the_data);
#if _TRACE_COMMAND
                Console.Write("C5:");
                Console.Write(script_engine.command_kind_to_name(the_command));
                Console.Write("\n");
#endif
            }
        }

        private enum block_kind
        {
            bk_normal,
            bk_loop,
            bk_sub,
            bk_function,
            bk_microthread
        }

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend struct block;


        private class block
        {
            public int level;
            public int arguments;
            public string name = "";
            public callback func;
            public codes_t codes = new codes_t();
            public block_kind kind;

            public block(int the_level, block_kind the_kind)
            {
                this.level = the_level;
                this.arguments = 0;
                this.name = new string();
                this.func = null;
                this.codes = new codes_t();
                this.kind = new gstd.script_engine.block_kind(the_kind);
            }
        }

        private LinkedList< block > blocks = new LinkedList< block >(); // ?�g�̃|�C?�^��g���̂ŃA�h?�X���ς��Ȃ��悤��list
        private block main_block;
        private SortedDictionary< string, block  > events = new SortedDictionary< string, block  >();

        private block new_block(int level, block_kind kind)
        {
            block x = new block(level, kind);
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'insert' method in C#:
            return  * blocks.insert(blocks.end(), x);
        }

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend class parser;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend class script_machine;
    }

    public class script_machine : System.IDisposable
    {
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_machine(script_engine the_engine);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        public void Dispose();

        public object[] data; // �N?�C�A?�g�p���

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void run();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void call(string event_name);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void resume();

        public void stop()
        {
            finished = true;
            stopped = true;
        }

        public bool get_stopped()
        {
            return stopped;
        }

        public bool get_resuming()
        {
            return resuming;
        }

        public bool get_error()
        {
            return error;
        }

        public string get_error_message()
        {
            return error_message;
        }

        public int get_error_line()
        {
            return error_line;
        }

        public void raise_error(string message)
        {
            error = true;
            error_message = message;
            finished = true;
        }
        public void terminate(string message)
        {
            bTerminate = true;
            error = true;
            error_message = message;
            finished = true;
        }

        public script_engine get_engine()
        {
            return engine;
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        bool has_event(string event_name);

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        int get_current_line();

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_machine();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_machine(script_machine source);
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: script_machine & operator = (script_machine const & source);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        script_machine CopyFrom (script_machine source);

        private script_engine engine;

        private bool error;
        private string error_message = "";
        private int error_line;

        private bool bTerminate;


        private class environment
        {
            public environment pred; // �o����??�N?�X�g
            public environment succ;
            public environment parent;
            public int ref_count;
            public script_engine.block sub;
            public uint ip;
            public variables_t variables = new variables_t();
            public stack_t stack = new stack_t();
            public bool has_result;
        }

        private LinkedList<environment > call_start_parent_environment_list = new LinkedList<environment >();
        private environment first_using_environment;
        private environment last_using_environment;
        private environment first_garbage_environment;
        private environment last_garbage_environment;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        environment new_environment(environment parent, script_engine::block b);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void dispose_environment(environment @object);


        private lightweight_vector< environment  > threads = new lightweight_vector< environment  >();
        private uint current_thread_index;
        private bool finished;
        private bool stopped;
        private bool resuming;

        private void yield()
        {
            if (current_thread_index > 0)
            {
                --current_thread_index;
            }
            else
            {
                current_thread_index = threads.size() - 1;
            }
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void advance();

        public int get_thread_count()
        {
            return (int)threads.size();
        }
    }

// C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
// ORIGINAL LINE: template < int num >
    public class constant < int num >
    {
        public static value func(script_machine machine, int argc, value argv)
        {
            return new value(machine.get_engine().get_real_type(), (double) num);
        }
    }

}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)


#if _MSC_VER
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define for if(0);else for
#define for
namespace std
{
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::wcstombs;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::mbstowcs;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::isalpha;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::fmodl;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::powl;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::swprintf;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::atof;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::isdigit;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::isxdigit;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::floorl;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::ceill;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::fabsl;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::iswdigit;
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    using::iswalpha;
}

#endif




/* value */
#if _TRACE_VALUE
#endif



// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: double value::as_real() const

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: char value::as_char() const

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool value::as_boolean() const

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: string value::as_string() const

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: uint value::length_as_array() const

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: value const & value::index_as_array(uint i) const


// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: type_data * value::get_type() const


// --------------------------------------

/* parser_error */

public class parser_error : gstd.wexception
{
    public parser_error(string the_message) : base(the_message)
    {
    }


}

/* lexical analyzer */

public enum token_kind
{
    tk_end,
    tk_invalid,
    tk_word,
    tk_real,
    tk_char,
    tk_string,
    tk_open_par,
    tk_close_par,
    tk_open_bra,
    tk_close_bra,
    tk_open_cur,
       tk_close_cur,
       tk_open_abs,
       tk_close_abs,
       tk_comma,
       tk_semicolon,
       tk_tilde,
       tk_assign,
       tk_plus,
       tk_minus,
       tk_inc,
       tk_dec,
       tk_asterisk,
       tk_slash,
       tk_percent,
       tk_caret,
       tk_e,
       tk_g,
       tk_ge,
       tk_l,
       tk_le,
       tk_ne,
       tk_exclamation,
       tk_ampersand,
       tk_and_then,
       tk_vertical,
       tk_or_else,
       tk_at,
       tk_add_assign,
       tk_subtract_assign,
       tk_multiply_assign,
       tk_divide_assign,
       tk_remainder_assign,
       tk_power_assign,
       tk_range,
       tk_ALTERNATIVE,
       tk_ASCENT,
       tk_BREAK,
       tk_CASE,
       tk_DESCENT,
       tk_ELSE,
       tk_FUNCTION,
       tk_IF,
       tk_IN,
       tk_LET,
       tk_LOCAL,
       tk_LOOP,
       tk_OTHERS,
       tk_REAL,
       tk_RETURN,
       tk_SUB,
       tk_TASK,
       tk_TIMES,
       tk_WHILE,
       tk_YIELD
}
#if _TRACE_COMMAND
#endif

public class scanner
{
    private int encoding;
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
    private readonly char * current;
    private readonly string endPoint;

    private char current_char()
    {
        char res = '\0';
        if (encoding == Encoding.UTF16LE)
        {
            res = (char)current[0];
        }
        else
        {
            res = * current;
        }
        return res;
    }

    private char index_from_current_char(int index)
    {
        char res = '\0';
        if (encoding == Encoding.UTF16LE)
        {
            string pos = current + GlobalMembers.index * 2;
            if (pos >= endPoint)
            {
                return '\0';
            }
            res = (char)current[GlobalMembers.index * 2];
        }
        else
        {
            string pos = current + GlobalMembers.index;
            if (pos >= endPoint)
            {
                return '\0';
            }
            res = current[GlobalMembers.index];
        }

        return res;
    }

    private char next_char()
    {
        if (encoding == Encoding.UTF16LE)
        {
            current += 2;
        }
        else
        {
            ++current;
        }

        char res = current_char();
        return res;
    }

    public token_kind next;
    public string word = "";
    public double real_value;
    public char char_value;
    public string string_value = "";
    public int line;

    public scanner(string source, string end)
    {
        this.current = source;
        this.line = 1;
        endPoint = end;
        encoding = Encoding.SHIFT_JIS;
        if (Encoding.IsUtf16Le(source, 2))
        {
            encoding = Encoding.UTF16LE;

            int bomSize = Encoding.GetBomSize(source, 2);
            current += bomSize;
        }

        advance();
    }

    public scanner(scanner source)
    {
        this.encoding = source.encoding;
        this.current = source.current;
        this.endPoint = source.endPoint;
        this.next = new token_kind(source.next);
        this.word = source.word;
        this.line = source.line;
    }

    public void skip()
    {
        // ��?���΂�
        char ch1 = current_char();
        char ch2 = index_from_current_char(1);
        while (ch1 == '\r' || ch1 == '\n' || ch1 == '\t' || ch1 == ' ' || ch1 == '#' || (ch1 == '/' && (ch2 == '/' || ch2 == '*')))
        {
               // �R??�g���΂�
               if (ch1 == '#' || (ch1 == '/' && (ch2 == '/' || ch2 == '*')))
               {
                   if (ch1 == '#' || ch2 == '/')
                   {
                       do
                       {
                           ch1 = next_char();
                       } while (ch1 != '\r' && ch1 != '\n');
                   }
                   else
                   {
                       next_char();
                       ch1 = next_char();
                       ch2 = index_from_current_char(1);
                       while (ch1 != '*' || ch2 != '/')
                       {
                           if (ch1 == '\n')
                           {
                               ++line;
                           }
                           ch1 = next_char();
                           ch2 = index_from_current_char(1);
                       }
                       ch1 = next_char();
                       ch1 = next_char();
                   }
               }
               else if (ch1 == '\n')
               {
                   ++line;
                   ch1 = next_char();
               }
               else
               {
                   ch1 = next_char();
               }
               ch2 = index_from_current_char(1);
        }
    }

    public void advance()
    {
        skip();

        char ch = current_char();
        if (ch == '\0' || current >= endPoint)
        {
            next = token_kind.tk_end;
            return;
        }

        switch (ch)
        {
            case '[':
                next = token_kind.tk_open_bra;
                ch = next_char();
                break;
            case ']':
                next = token_kind.tk_close_bra;
                ch = next_char();
                break;
            case '(':
                next = token_kind.tk_open_par;
                ch = next_char();
                if (ch == '|')
                {
                    next = token_kind.tk_open_abs;
                    ch = next_char();
                }
                break;
            case ')':
                next = token_kind.tk_close_par;
                ch = next_char();
                break;
            case '{':
                next = token_kind.tk_open_cur;
                ch = next_char();
                break;
            case '}':
                next = token_kind.tk_close_cur;
                ch = next_char();
                break;
            case '@':
                next = token_kind.tk_at;
                ch = next_char();
                break;
            case ',':
                next = token_kind.tk_comma;
                ch = next_char();
                break;
            case ';':
                next = token_kind.tk_semicolon;
                ch = next_char();
                break;
            case '~':
                next = token_kind.tk_tilde;
                ch = next_char();
                break;
            case '*':
                next = token_kind.tk_asterisk;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_multiply_assign;
                    ch = next_char();
                }
                break;
            case '/':
                next = token_kind.tk_slash;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_divide_assign;
                    ch = next_char();
                }
                break;
            case '%':
                next = token_kind.tk_percent;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_remainder_assign;
                    ch = next_char();
                }
                break;
            case '^':
                next = token_kind.tk_caret;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_power_assign;
                    ch = next_char();
                }
                break;
            case '=':
                next = token_kind.tk_assign;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_e;
                    ch = next_char();
                }
                break;
            case '>':
                next = token_kind.tk_g;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_ge;
                    ch = next_char();
                }
                break;
            case '<':
                next = token_kind.tk_l;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_le;
                    ch = next_char();
                }
                break;
            case '!':
                next = token_kind.tk_exclamation;
                ch = next_char();
                if (ch == '=')
                {
                    next = token_kind.tk_ne;
                    ch = next_char();
                }
                break;
            case '+':
                next = token_kind.tk_plus;
                ch = next_char();
                if (ch == '+')
                {
                    next = token_kind.tk_inc;
                    ch = next_char();
                }
                else if (ch == '=')
                {
                    next = token_kind.tk_add_assign;
                    ch = next_char();
                }
                break;
            case '-':
                next = token_kind.tk_minus;
                ch = next_char();
                if (ch == '-')
                {
                    next = token_kind.tk_dec;
                    ch = next_char();
                }
                else if (ch == '=')
                {
                    next = token_kind.tk_subtract_assign;
                    ch = next_char();
                }
                break;
            case '&':
                next = token_kind.tk_ampersand;
                ch = next_char();
                if (ch == '&')
                {
                    next = token_kind.tk_and_then;
                    ch = next_char();
                }
                break;
            case '|':
                next = token_kind.tk_vertical;
                ch = next_char();
                if (ch == '|')
                {
                    next = token_kind.tk_or_else;
                    ch = next_char();
                }
                else if (ch == ')')
                {
                    next = token_kind.tk_close_abs;
                    ch = next_char();
                }
                break;
            case '.':
                ch = next_char();
                if (ch == '.')
                {
                    next = token_kind.tk_range;
                    ch = next_char();
                }
                else
                {
                    string error;
                    error += "It's script does not allow to alone period\r\n";
                    error += "(�P�Ƃ̃s?�I�h�͂��̃X�N?�v�g�ł͎g���܂���)";
                    throw new parser_error(error);
                }
                break;

            case '\'':
            case '\"':
            {
                    char q = current_char();
                    next = (q == '\"') ? token_kind.tk_string : token_kind.tk_char;
                    ch = next_char();
                    char pre = next;
                    if (encoding == Encoding.UTF16LE)
                    {
                        string s;
                        while (true)
                        {
                            if (ch == q && pre != '\\')
                            {
                                break;
                            }

                            if (ch == '\\')
                            {
                                if (pre == '\\')
                                {
                                    s += ch;
                                }
                            }
                            else
                            {
                                s += ch;
                            }

                            pre = ch;
                            ch = next_char();
                        }
                        ch = next_char();
                        string_value = s;
                    }
                    else
                    {
                        string s;
                        while (true)
                        {
                            if (ch == q && pre != '\\')
                            {
                                break;
                            }

                            if (ch == '\\')
                            {
                                if (pre == '\\')
                                {
                                    s += *current;
                                }
                            }
                            else
                            {
                                s += *current;
                            }

                            pre = ch;

                            if (IsDBCSLeadByteEx(Encoding.CP_SHIFT_JIS, ch))
                            {
                                ch = next_char();
                                s += ch;
                            }
                            ch = next_char();
                        }
                        ch = next_char();
                        string_value = to_wide(s);
                    }

                    if (q == '\'')
                    {
                        if (string_value.Length == 1)
                        {
                            char_value = string_value[0];
                        }
                        else
                        {
                            throw new parser_error("��?�^�̒l�̒�����1�����ł�");
                        }
                    }
            }
                break;
            case '\\':
            {
                    ch = next_char();
                    next = token_kind.tk_char;
                    char c = ch;
                    ch = next_char();
                    switch (c)
                    {
                        case '0':
                            char_value = '\0';
                            break;
                        case 'n':
                            char_value = '\n';
                            break;
                        case 'r':
                            char_value = '\r';
                            break;
                        case 't':
                            char_value = '\t';
                            break;
                        case 'x':
                            char_value = 0;
                            while (StringFunctions.IsXDigit(ch))
                            {
                                char_value = char_value * 16 + (ch >= 'a') ? ch - 'a' + 10 : (ch >= 'A') ? ch - 'A' + 10 : ch - '0';
                                ch = next_char();
                            }
                            break;
                        default:
                        {
                                string error;
                                error += "There is a strange character.\r\n";
                                error += "���ꕶ?���ςł�(�u\"...\"�v��Y��Ă��܂���)";
                                throw new parser_error(error);
                        }
                    }
            }
                break;
            default:
                if (char.IsDigit(ch))
                {
                    next = token_kind.tk_real;
                    real_value = 0.0;
                    do
                    {
                        real_value = real_value * 10.0 + (ch - '0');
                        ch = next_char();
                    } while (char.IsDigit(ch));

                    char ch2 = index_from_current_char(1);
                    if (ch == '.' && char.IsDigit(ch2))
                    {
                        ch = next_char();
                        double d = 1;
                        while (char.IsDigit(ch))
                        {
                            d = d / 10;
                            real_value = real_value + d * (ch - '0');
                            ch = next_char();
                        }
                    }
                }
                else if (char.IsLetter(ch) || ch == '_')
                {
                    next = token_kind.tk_word;
                    if (encoding == Encoding.UTF16LE)
                    {
                        word = "";
                        do
                        {
                            word += (char)ch;
                            ch = next_char();
                        } while (char.IsLetter(ch) || ch == '_' || char.IsDigit(ch));
                    }
                    else
                    {
                        string pStart = (string)current;
                        string pEnd = pStart;
                        do
                        {
                            ch = next_char();
                            pEnd = (string)current;
                        } while (char.IsLetter(ch) || ch == '_' || char.IsDigit(ch));
                        word = new string(pStart, pEnd);
                    }

                    if (word == "alternative")
                    {
                        next = token_kind.tk_ALTERNATIVE;
                    }
                    else if (word == "ascent")
                    {
                        next = token_kind.tk_ASCENT;
                    }
                    else if (word == "break")
                    {
                        next = token_kind.tk_BREAK;
                    }
                    else if (word == "case")
                    {
                        next = token_kind.tk_CASE;
                    }
                    else if (word == "descent")
                    {
                        next = token_kind.tk_DESCENT;
                    }
                    else if (word == "else")
                    {
                        next = token_kind.tk_ELSE;
                    }
                    else if (word == "function")
                    {
                        next = token_kind.tk_FUNCTION;
                    }
                    else if (word == "if")
                    {
                        next = token_kind.tk_IF;
                    }
                    else if (word == "in")
                    {
                        next = token_kind.tk_IN;
                    }
                    else if (word == "let" || word == "var")
                    {
                        next = token_kind.tk_LET;
                    }
                    else if (word == "local")
                    {
                        next = token_kind.tk_LOCAL;
                    }
                    else if (word == "loop")
                    {
                        next = token_kind.tk_LOOP;
                    }
                    else if (word == "others")
                    {
                        next = token_kind.tk_OTHERS;
                    }
                    else if (word == "real")
                    {
                        next = token_kind.tk_REAL;
                    }
                    else if (word == "return")
                    {
                        next = token_kind.tk_RETURN;
                    }
                    else if (word == "sub")
                    {
                        next = token_kind.tk_SUB;
                    }
                    else if (word == "task")
                    {
                        next = token_kind.tk_TASK;
                    }
                    else if (word == "times")
                    {
                        next = token_kind.tk_TIMES;
                    }
                    else if (word == "while")
                    {
                        next = token_kind.tk_WHILE;
                    }
                    else if (word == "yield")
                    {
                        next = token_kind.tk_YIELD;
                    }
                }
                else
                {
                    next = token_kind.tk_invalid;
                }
                break;
        }

    }

public void AddLog(ref string data)
{
    {
        string pStart = (string)current;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* pEnd = (char*)(current + min(16, endPoint - current));
        char pEnd = (string)(current + System.Math.Min(16, endPoint - current));
        string wstr = new string(pStart, pEnd);
        // Logger::WriteTop(StringUtility::Format(L"%s current=%d, endPoint=%d, val=%d, ch=%s", data, pStart, endPoint, (wchar_t)*current, wstr.c_str()));
    }
}
}

/* parser */

// C++ TO C# CONVERTER WARNING: The original type declaration contained unconverted modifiers:
// ORIGINAL LINE: class gstd::parser
public class parser : System.IDisposable
{
    public class symbol
    {
        public int level;
        public script_engine.block sub;
        public int variable;
    }

    public class scope : SortedDictionary< string, symbol >
    {
        public script_engine.block_kind kind;

        public scope(script_engine.block_kind the_kind)
        {
            this.kind = new gstd.script_engine.block_kind(the_kind);
        }
    }

    public List< scope > frame = new List< scope >();
    public scanner lex;
    public script_engine engine;
    public bool error;
    public string error_message = "";
    public int error_line;
    public SortedDictionary< string, script_engine.block  > events = new SortedDictionary< string, script_engine.block  >();

    public parser(script_engine e, scanner s, int funcc, function[] funcv)
    {
        this.engine = e;
        this.lex = s;
        this.frame = new List< scope >();
        this.error = false;
        frame.Add(new scope(script_engine.bk_normal));

        if (false)
        {
            ;
        }
        else
        {
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: for(int i = 0; i < sizeof(operations) / sizeof(function); ++i) register_function(operations[i]);
            for (int i = 0; i < GlobalMembers.operations.Length; ++i) register_function(GlobalMembers.operations[i]);
        }

        if (false)
        {
            ;
        }
        else
        {
            for (int i = 0; i < funcc; ++i) register_function(funcv[i]);
        }

        try
        {
            scan_current_scope(0, null, false);
            parse_statements(engine.main_block);
            if (lex.next != token_kind.tk_end)
            {
                string error;
                error += "Unable to be interpreted (Don't forget \";\"s).\r\n";
                error += "(���߂ł��Ȃ����̂�?��܂�(�u;�v��Y��Ă��܂���))";
                throw new parser_error(error);
            }
        }
        catch (parser_error e)
        {
            error = true;
            error_message = e.what();
            error_line = lex.line;
        }
    }

    public virtual void Dispose()
    {
    }

    public void parse_parentheses(script_engine.block block)
    {
        if (lex.next != token_kind.tk_open_par)
        {
            string error;
            error += "\"(\" is nessasary.\r\n";
            error += "(\"(\"���K�v�ł�)";
            throw new parser_error(error);
        }
        lex.advance();

        parse_expression(block);

        if (lex.next != token_kind.tk_close_par)
        {
            string error;
            error += "\")\" is nessasary.\r\n";
            error += "(\")\"���K�v�ł�)";
            throw new parser_error(error);
        }
        lex.advance();
    }

    public void parse_clause(script_engine.block block)
    {
        if (lex.next == token_kind.tk_real)
        {
            block.codes.push_back(new code(lex.line, script_engine.pc_push_value, new value(engine.get_real_type(), lex.real_value)));
            lex.advance();
        }
        else if (lex.next == token_kind.tk_char)
        {
            block.codes.push_back(new code(lex.line, script_engine.pc_push_value, new value(engine.get_char_type(), lex.char_value)));
            lex.advance();
        }
        else if (lex.next == token_kind.tk_string)
        {
            string str = lex.string_value;
            lex.advance();
            while (lex.next == token_kind.tk_string || lex.next == token_kind.tk_char)
            {
                str += (lex.next == token_kind.tk_string) ? lex.string_value : (new string() + lex.char_value);
                lex.advance();
            }

            block.codes.push_back(new code(lex.line, script_engine.pc_push_value, new value(engine.get_string_type(), str)));
        }
        else if (lex.next == token_kind.tk_word)
        {
            symbol s = search(lex.word);
            if (s == null)
            {
                string error;
                error += StringUtility.FormatToWide("%s is not defined.\r\n", lex.word);
                error += StringUtility.FormatToWide("(%s�͖���`�̎��ʎq�ł�)", lex.word);
                throw new parser_error(error);
            }

            lex.advance();

            if (s.sub != null)
            {
                if (s.sub.kind != script_engine.bk_function)
                {
                    string error;
                    error += "sub and task cannot call in the statement.\r\n";
                    error += "(sub��task�͎�?�ŌĂׂ܂���)";
                    throw new parser_error(error);
                }

                int argc = parse_arguments(block);

                if (argc != s.sub.arguments)
                {
                    string error;
                    error += StringUtility.FormatToWide("%s incorrect number of parameters. Check to make sure you have the correct number of parameters.\r\n", s.sub.name);
                    error += StringUtility.FormatToWide("(%s�̈�?��?���Ⴂ�܂�)", s.sub.name);
                    throw new parser_error(error);
                }

                block.codes.push_back(new code(lex.line, script_engine.pc_call_and_push_result, s.sub, argc));
            }
            else
            {
                // ��?
                block.codes.push_back(new code(lex.line, script_engine.pc_push_variable, s.level, s.variable));
            }
        }
        else if (lex.next == token_kind.tk_open_bra)
        {
            lex.advance();
            block.codes.push_back(new code(lex.line, script_engine.pc_push_value, new value(engine.get_string_type(), new string())));
            while (lex.next != token_kind.tk_close_bra)
            {
                parse_expression(block);
                write_operation(block, "append", 2);
                if (lex.next != token_kind.tk_comma)
                {
                    break;
                }
                lex.advance();
            }
            if (lex.next != token_kind.tk_close_bra)
            {
                string error;
                error += "\"]\" is nessasary.\r\n";
                error += "(\"]\"���K�v�ł�)";
                throw new parser_error(error);
            }
            lex.advance();
        }
        else if (lex.next == token_kind.tk_open_abs)
        {
            lex.advance();
            parse_expression(block);
            write_operation(block, "absolute", 1);
            if (lex.next != token_kind.tk_close_abs)
            {
                string error;
                error += "\"|\" is nessasary.\r\n";
                error += "(\"|)\"���K�v�ł�)";
                throw new parser_error(error);
            }
            lex.advance();
        }
        else if (lex.next == token_kind.tk_open_par)
        {
            parse_parentheses(block);
        }
        else
        {
            string error;
            error += "Invalid expression.\r\n";
            error += "(?�Ƃ��Ė����Ȏ���?��܂�)";
            throw new parser_error(error);
        }
    }

    public void parse_prefix(script_engine.block block)
    {
        if (lex.next == token_kind.tk_plus)
        {
            lex.advance();
            parse_prefix(block); // �ċA
        }
        else if (lex.next == token_kind.tk_minus)
        {
            lex.advance();
            parse_prefix(block); // �ċA
            write_operation(block, "negative", 1);
        }
        else if (lex.next == token_kind.tk_exclamation)
        {
            lex.advance();
            parse_prefix(block); // �ċA
            write_operation(block, "not", 1);
        }
        else
        {
            parse_suffix(block);
        }
    }

    public void parse_suffix(script_engine.block block)
    {
        parse_clause(block);
        if (lex.next == token_kind.tk_caret)
        {
            lex.advance();
            parse_suffix(block); // �ċA
            write_operation(block, "power", 2);
        }
        else
        {
            while (lex.next == token_kind.tk_open_bra)
            {
                lex.advance();
                parse_expression(block);

                if (lex.next == token_kind.tk_range)
                {
                    lex.advance();
                    parse_expression(block);
                    write_operation(block, "slice", 3);
                }
                else
                {
                    write_operation(block, "index_", 2);
                }

                if (lex.next != token_kind.tk_close_bra)
                {
                    string error;
                    error += "\"]\" is nessasary.\r\n";
                    error += "(\"]\"���K�v�ł�)";
                    throw new parser_error(error);
                }
                lex.advance();
            }
        }
    }

    public void parse_product(script_engine.block block)
    {
        parse_prefix(block);
        while (lex.next == token_kind.tk_asterisk || lex.next == token_kind.tk_slash || lex.next == token_kind.tk_percent)
        {
            string name = (lex.next == token_kind.tk_asterisk) ? "multiply" : (lex.next == token_kind.tk_slash) ? "divide" : "remainder";
            lex.advance();
            parse_prefix(block);
            write_operation(block, name, 2);
        }
    }

    public void parse_sum(script_engine.block block)
    {
        parse_product(block);
        while (lex.next == token_kind.tk_tilde || lex.next == token_kind.tk_plus || lex.next == token_kind.tk_minus)
        {
            string name = (lex.next == token_kind.tk_tilde) ? "concatenate" : (lex.next == token_kind.tk_plus) ? "add" : "subtract";
            lex.advance();
            parse_product(block);
            write_operation(block, name, 2);
        }
    }

    public void parse_comparison(script_engine.block block)
    {
        parse_sum(block);
        switch (lex.next)
        {
            case token_kind.tk_assign:
            {
                string error;
                error += "Do you not mistake it for \"==\"?\r\n";
                error += "(\"==\"�ƊԈႦ�Ă܂��񂩁H)";
                throw new parser_error(error);
            }

            case token_kind.tk_e:
            case token_kind.tk_g:
            case token_kind.tk_ge:
            case token_kind.tk_l:
            case token_kind.tk_le:
            case token_kind.tk_ne:
                token_kind op = lex.next;
                lex.advance();
                parse_sum(block);
                write_operation(block, "compare", 2);
                switch (op)
                {
                    case token_kind.tk_e:
                        block.codes.push_back(new code(lex.line, script_engine.pc_compare_e));
                        break;
                    case token_kind.tk_g:
                        block.codes.push_back(new code(lex.line, script_engine.pc_compare_g));
                        break;
                    case token_kind.tk_ge:
                        block.codes.push_back(new code(lex.line, script_engine.pc_compare_ge));
                        break;
                    case token_kind.tk_l:
                        block.codes.push_back(new code(lex.line, script_engine.pc_compare_l));
                        break;
                    case token_kind.tk_le:
                        block.codes.push_back(new code(lex.line, script_engine.pc_compare_le));
                        break;
                    case token_kind.tk_ne:
                        block.codes.push_back(new code(lex.line, script_engine.pc_compare_ne));
                        break;
                }
                break;
        }
    }

    public void parse_logic(script_engine.block block)
    {
        parse_comparison(block);
        while (lex.next == token_kind.tk_and_then || lex.next == token_kind.tk_or_else)
        {
            script_engine.command_kind cmd = (lex.next == token_kind.tk_and_then) ? script_engine.pc_case_if_not : script_engine.pc_case_if;
            lex.advance();

            block.codes.push_back(new code(lex.line, script_engine.pc_dup));
            block.codes.push_back(new code(lex.line, script_engine.pc_case_begin));
            block.codes.push_back(new code(lex.line, cmd));
            block.codes.push_back(new code(lex.line, script_engine.pc_pop));

            parse_comparison(block);

            block.codes.push_back(new code(lex.line, script_engine.pc_case_end));
        }
    }

    public void parse_expression(script_engine.block block)
    {
        parse_logic(block);
    }

    public int parse_arguments(script_engine.block block)
    {
        int result = 0;
        if (lex.next == token_kind.tk_open_par)
        {
            lex.advance();
            while (lex.next != token_kind.tk_close_par)
            {
                ++result;
                parse_expression(block);
                if (lex.next != token_kind.tk_comma)
                {
                    break;
                }
                lex.advance();
            }
            if (lex.next != token_kind.tk_close_par)
            {
                string error;
                error += "\")\" is nessasary.\r\n";
                error += "(\")\"���K�v�ł�)";
                throw new parser_error(error);
            }
            lex.advance();
        }
        return result;
    }

    public void parse_statements(script_engine.block block)
    {
        if (false)
        {
            ;
        }
        else
        {
            for (; ;)
            {
            bool need_semicolon = true;
#if _TRACE_TOKEN
            Console.Write("P:");
            Console.Write(GlobalMembers.token_kind_to_name(lex.next));
            Console.Write("\n");
#endif
            if (lex.next == token_kind.tk_word)
            {
                symbol s = search(lex.word);
                if (s == null)
                {
                    string error;
                    error += StringUtility.FormatToWide("%s is not defined.\r\n", lex.word);
                    error += StringUtility.FormatToWide("(%s�͖���`�̎��ʎq�ł�)", lex.word);
                    throw new parser_error(error);
                }
                lex.advance();
                switch (lex.next)
                {
                    case token_kind.tk_assign:
                        lex.advance();
                        parse_expression(block);
                        block.codes.push_back(new code(lex.line, script_engine.pc_assign, s.level, s.variable));
                        break;

                    case token_kind.tk_open_bra:
                        block.codes.push_back(new code(lex.line, script_engine.pc_push_variable_writable, s.level, s.variable));
                        lex.advance();
                        parse_expression(block);
                        if (lex.next != token_kind.tk_close_bra)
                        {
                            string error;
                            error += "\"]\" is nessasary.\r\n";
                            error += "(\"]\"���K�v�ł�)";
                            throw new parser_error(error);
                        }
                        lex.advance();
                        write_operation(block, "index!", 2);
                        if (lex.next != token_kind.tk_assign)
                        {
                            string error;
                            error += "\"=\" is nessasary.\r\n";
                            error += "(\"=\"���K�v�ł�)";
                            throw new parser_error(error);
                        }
                        lex.advance();
                        parse_expression(block);
                        block.codes.push_back(new code(lex.line, script_engine.pc_assign_writable));
                        break;

                    case token_kind.tk_add_assign:
                    case token_kind.tk_subtract_assign:
                    case token_kind.tk_multiply_assign:
                    case token_kind.tk_divide_assign:
                    case token_kind.tk_remainder_assign:
                    case token_kind.tk_power_assign:
                    {
                            string f;
                            switch (lex.next)
                            {
                                case token_kind.tk_add_assign:
                                    f = "add";
                                    break;
                                case token_kind.tk_subtract_assign:
                                    f = "subtract";
                                    break;
                                case token_kind.tk_multiply_assign:
                                    f = "multiply";
                                    break;
                                case token_kind.tk_divide_assign:
                                    f = "divide";
                                    break;
                                case token_kind.tk_remainder_assign:
                                    f = "remainder";
                                    break;
                                case token_kind.tk_power_assign:
                                    f = "power";
                                    break;
                            }
                            lex.advance();

                            block.codes.push_back(new code(lex.line, script_engine.pc_push_variable, s.level, s.variable));

                            parse_expression(block);
                            write_operation(block, f, 2);

                            block.codes.push_back(new code(lex.line, script_engine.pc_assign, s.level, s.variable));
                    }
                        break;

                    case token_kind.tk_inc:
                    case token_kind.tk_dec:
                    {
                            string f = (lex.next == token_kind.tk_inc) ? "successor" : "predecessor";
                            lex.advance();

                            block.codes.push_back(new code(lex.line, script_engine.pc_push_variable, s.level, s.variable));
                            write_operation(block, f, 1);
                            block.codes.push_back(new code(lex.line, script_engine.pc_assign, s.level, s.variable));
                    }
                        break;
                    default:
                        // ��?, sub�ďo��
                        if (s.sub == null)
                        {
                            string error;
                            error += "You cannot call a variable as if it were a function or a subroutine.\r\n";
                            error += "(��?�͊�?��sub�̂悤�ɂ͌Ăׂ܂���)";
                            throw new parser_error(error);
                        }

                        int argc = parse_arguments(block);

                        if (argc != s.sub.arguments)
                        {
                            string error;
                            error += StringUtility.FormatToWide("%s incorrect number of parameters. Check to make sure you have the correct number of parameters.\r\n", s.sub.name);
                            error += StringUtility.FormatToWide("(%s�̈�?��?���Ⴂ�܂�)", s.sub.name);
                            throw new parser_error(error);
                        }

                        block.codes.push_back(new code(lex.line, script_engine.pc_call, s.sub, argc));
                        break;
                }
            }
            else if (lex.next == token_kind.tk_LET || lex.next == token_kind.tk_REAL)
            {
                lex.advance();

                if (lex.next != token_kind.tk_word)
                {
                    string error;
                    error += "Symbol name is nessasary.\r\n";
                    error += "(���ʎq���K�v�ł�)";
                    throw new parser_error(error);
                }

                symbol s = search(lex.word);

                lex.advance();
                if (lex.next == token_kind.tk_assign)
                {
                    lex.advance();
                    parse_expression(block);
                    block.codes.push_back(new code(lex.line, script_engine.pc_assign, s.level, s.variable));
                }
            }
            else if (lex.next == token_kind.tk_LOCAL)
            {
                lex.advance();
                parse_inline_block(block, script_engine.bk_normal);
                need_semicolon = false;
            }
            else if (lex.next == token_kind.tk_LOOP)
            {
                lex.advance();
                if (lex.next == token_kind.tk_open_par)
                {
                    parse_parentheses(block);
                    int ip = block.codes.length;
                    block.codes.push_back(new code(lex.line, script_engine.pc_loop_count));
                    parse_inline_block(block, script_engine.bk_loop);
                    block.codes.push_back(new code(lex.line, script_engine.pc_loop_back, ip));
                    block.codes.push_back(new code(lex.line, script_engine.pc_pop));
                }
                else
                {
                    int ip = block.codes.length;
                    parse_inline_block(block, script_engine.bk_loop);
                    block.codes.push_back(new code(lex.line, script_engine.pc_loop_back, ip));
                }
                need_semicolon = false;
            }
            else if (lex.next == token_kind.tk_TIMES)
            {
                lex.advance();
                parse_parentheses(block);
                int ip = block.codes.length;
                if (lex.next == token_kind.tk_LOOP)
                {
                    lex.advance();
                }
                block.codes.push_back(new code(lex.line, script_engine.pc_loop_count));
                parse_inline_block(block, script_engine.bk_loop);
                block.codes.push_back(new code(lex.line, script_engine.pc_loop_back, ip));
                block.codes.push_back(new code(lex.line, script_engine.pc_pop));
                need_semicolon = false;
            }
            else if (lex.next == token_kind.tk_WHILE)
            {
                lex.advance();
                int ip = block.codes.length;
                parse_parentheses(block);
                if (lex.next == token_kind.tk_LOOP)
                {
                    lex.advance();
                }
                block.codes.push_back(new code(lex.line, script_engine.pc_loop_if));
                parse_inline_block(block, script_engine.bk_loop);
                block.codes.push_back(new code(lex.line, script_engine.pc_loop_back, ip));
                need_semicolon = false;
            }
            else if (lex.next == token_kind.tk_ASCENT || lex.next == token_kind.tk_DESCENT)
            {
                bool back = lex.next == token_kind.tk_DESCENT;
                lex.advance();

                if (lex.next != token_kind.tk_open_par)
                {
                    string error;
                    error += "\"(\" is nessasary.\r\n";
                    error += "(\"(\"���K�v�ł�)";
                    throw new parser_error(error);
                }
                lex.advance();

                if (lex.next == token_kind.tk_LET || lex.next == token_kind.tk_REAL)
                {
                    lex.advance();
                }

                if (lex.next != token_kind.tk_word)
                {
                    string error;
                    error += "The symbol name is nessasary.\r\n";
                    error += "(���ʎq���K�v�ł�)";
                    throw new parser_error(error);
                }

                string s = lex.word;

                lex.advance();

                if (lex.next != token_kind.tk_IN)
                {
                    string error;
                    error += "\"in\" is nessasary.\r\n";
                    error += "(in���K�v�ł�)";
                    throw new parser_error(error);
                }
                lex.advance();

                parse_expression(block);

                if (lex.next != token_kind.tk_range)
                {
                    string error;
                    error += "\"..\" is nessasary.\r\n";
                    error += "(\"..\"���K�v�ł�)";
                    throw new parser_error(error);
                }
                lex.advance();

                parse_expression(block);

                if (lex.next != token_kind.tk_close_par)
                {
                    string error;
                    error += "\")\" is nessasary.\r\n";
                    error += "(\")\"���K�v�ł�)";
                    throw new parser_error(error);
                }
                lex.advance();

                if (lex.next == token_kind.tk_LOOP)
                {
                    lex.advance();
                }

                if (!back)
                {
                    block.codes.push_back(new code(lex.line, script_engine.pc_swap));
                }

                int ip = block.codes.length;

                block.codes.push_back(new code(lex.line, script_engine.pc_dup2));
                write_operation(block, "compare", 2);

                block.codes.push_back(new code(lex.line, back ? script_engine.pc_loop_descent : script_engine.pc_loop_ascent));

                if (back)
                {
                    write_operation(block, "predecessor", 1);
                }

                script_engine.block b = engine.new_block(block.level + 1, script_engine.bk_loop);
                List< string > counter = new List< string >();
                counter.Add(s);
                parse_block(b, counter, false);
                block.codes.push_back(new code(lex.line, script_engine.pc_dup));
                block.codes.push_back(new code(lex.line, script_engine.pc_call, b, 1));

                if (!back)
                {
                    write_operation(block, "successor", 1);
                }

                block.codes.push_back(new code(lex.line, script_engine.pc_loop_back, ip));
                block.codes.push_back(new code(lex.line, script_engine.pc_pop));
                block.codes.push_back(new code(lex.line, script_engine.pc_pop));

                need_semicolon = false;
            }
            else if (lex.next == token_kind.tk_IF)
            {
                lex.advance();
                block.codes.push_back(new code(lex.line, script_engine.pc_case_begin));

                parse_parentheses(block);
                block.codes.push_back(new code(lex.line, script_engine.pc_case_if_not));
                parse_inline_block(block, script_engine.bk_normal);
                while (lex.next == token_kind.tk_ELSE)
                {
                    lex.advance();
                    block.codes.push_back(new code(lex.line, script_engine.pc_case_next));
                    if (lex.next == token_kind.tk_IF)
                    {
                        lex.advance();
                        parse_parentheses(block);
                        block.codes.push_back(new code(lex.line, script_engine.pc_case_if_not));
                        parse_inline_block(block, script_engine.bk_normal);
                    }
                    else
                    {
                        parse_inline_block(block, script_engine.bk_normal);
                        break;
                    }
                }

                block.codes.push_back(new code(lex.line, script_engine.pc_case_end));
                need_semicolon = false;
            }
            else if (lex.next == token_kind.tk_ALTERNATIVE)
            {
                lex.advance();
                parse_parentheses(block);
                block.codes.push_back(new code(lex.line, script_engine.pc_case_begin));
                while (lex.next == token_kind.tk_CASE)
                {
                    lex.advance();

                    if (lex.next != token_kind.tk_open_par)
                    {
                        string error;
                        error += "\"(\" is nessasary.\r\n";
                        error += "(\"(\"���K�v�ł�)";
                        throw new parser_error(error);
                    }
                    block.codes.push_back(new code(lex.line, script_engine.pc_case_begin));
                    do
                    {
                        lex.advance();

                        block.codes.push_back(new code(lex.line, script_engine.pc_dup));
                        parse_expression(block);
                        write_operation(block, "compare", 2);
                        block.codes.push_back(new code(lex.line, script_engine.pc_compare_e));
                        block.codes.push_back(new code(lex.line, script_engine.pc_dup));
                        block.codes.push_back(new code(lex.line, script_engine.pc_case_if));
                        block.codes.push_back(new code(lex.line, script_engine.pc_pop));

                    } while (lex.next == token_kind.tk_comma);
                    block.codes.push_back(new code(lex.line, script_engine.pc_push_value, new value(engine.get_boolean_type(), false)));
                    block.codes.push_back(new code(lex.line, script_engine.pc_case_end));
                    if (lex.next != token_kind.tk_close_par)
                    {
                        string error;
                        error += "\")\" is nessasary.\r\n";
                        error += "(\")\"���K�v�ł�)";
                        throw new parser_error(error);
                    }
                    lex.advance();

                    block.codes.push_back(new code(lex.line, script_engine.pc_case_if_not));
                    block.codes.push_back(new code(lex.line, script_engine.pc_pop));
                    parse_inline_block(block, script_engine.bk_normal);
                    block.codes.push_back(new code(lex.line, script_engine.pc_case_next));
                }
                if (lex.next == token_kind.tk_OTHERS)
                {
                    lex.advance();
                    block.codes.push_back(new code(lex.line, script_engine.pc_pop));
                    parse_inline_block(block, script_engine.bk_normal);
                }
                else
                {
                    block.codes.push_back(new code(lex.line, script_engine.pc_pop));
                }
                block.codes.push_back(new code(lex.line, script_engine.pc_case_end));
                need_semicolon = false;
            }
            else if (lex.next == token_kind.tk_BREAK)
            {
                lex.advance();
                block.codes.push_back(new code(lex.line, script_engine.pc_break_loop));
            }
            else if (lex.next == token_kind.tk_RETURN)
            {
                lex.advance();
                switch (lex.next)
                {
                    case token_kind.tk_end:
                    case token_kind.tk_invalid:
                    case token_kind.tk_semicolon:
                    case token_kind.tk_close_cur:
                        break;
                    default:
                        parse_expression(block);
                        symbol s = search_result();
                        if (s == null)
                        {
                            string error;
                            error += "\"return\" can call in function only.\r\n";
                            error += "(������function��?�ł�?��܂���)";
                            throw new parser_error(error);
                        }

                        block.codes.push_back(new code(lex.line, script_engine.pc_assign, s.level, s.variable));
                        break;
                }
                block.codes.push_back(new code(lex.line, script_engine.pc_break_routine));
            }
            else if (lex.next == token_kind.tk_YIELD)
            {
                lex.advance();
                block.codes.push_back(new code(lex.line, script_engine.pc_yield));
            }
            else if (lex.next == token_kind.tk_at || lex.next == token_kind.tk_SUB || lex.next == token_kind.tk_FUNCTION || lex.next == token_kind.tk_TASK)
            {
                bool is_event = lex.next == token_kind.tk_at;

                lex.advance();
                if (lex.next != token_kind.tk_word)
                {
                    string error;
                    error += "Symbol name is nessasary.\r\n";
                    error += "(���ʎq���K�v�ł�)";
                    throw new parser_error(error);
                }

                symbol s = search(lex.word);

                if (is_event)
                {
                    if (s.sub.level > 1)
                    {
                        string error;
                        error += "\"@\" cannot use in inner function and task.\r\n";
                        error += "(�C�x?�g��[���K�w�ɋL�q���邱�Ƃ͂ł��܂���)";
                        throw new parser_error(error);
                    }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: events[s->sub->name] = s->sub;
                    events[s.sub.name].CopyFrom(s.sub);
                }

                lex.advance();

                List< string > args = new List< string >();
                if (s.sub.kind != script_engine.bk_sub)
                {
                    if (lex.next == token_kind.tk_open_par)
                    {
                        lex.advance();
                        while (lex.next == token_kind.tk_word || lex.next == token_kind.tk_LET || lex.next == token_kind.tk_REAL)
                        {
                            if (lex.next == token_kind.tk_LET || lex.next == token_kind.tk_REAL)
                            {
                                lex.advance();
                                if (lex.next != token_kind.tk_word)
                                {
                                    string error;
                                    error += "Function parameter is nessasary.\r\n";
                                    error += "(����?���K�v�ł�)";
                                    throw new parser_error(error);
                                }
                            }
                            args.Add(lex.word);
                            lex.advance();
                            if (lex.next != token_kind.tk_comma)
                            {
                                break;
                            }
                            lex.advance();
                        }
                        if (lex.next != token_kind.tk_close_par)
                        {
                            string error;
                            error += "\")\" is nessasary.\r\n";
                            error += "(\")\"���K�v�ł�)";
                            throw new parser_error(error);
                        }
                        lex.advance();
                    }
                }
                else
                {
                    // �݊����̂��ߋ��?�ʂ���?��
                    if (lex.next == token_kind.tk_open_par)
                    {
                        lex.advance();
                        if (lex.next != token_kind.tk_close_par)
                        {
                            string error;
                            error += "\")\" is nessasary.\r\n";
                            error += "(\")\"���K�v�c�Ƃ�����\"(\"�v���ł�)";
                            throw new parser_error(error);
                        }
                        lex.advance();
                    }
                }
                parse_block(s.sub, args, s.sub.kind == script_engine.bk_function);
                need_semicolon = false;
            }

            // �Z�~�R??�������ƌp�����Ȃ�
            if (need_semicolon && lex.next != token_kind.tk_semicolon)
            {
                break;
            }

            if (lex.next == token_kind.tk_semicolon)
            {
                lex.advance();
            }
            }
        }
    }

    public void parse_inline_block(script_engine.block block, script_engine.block_kind kind)
    {
        script_engine.block b = engine.new_block(block.level + 1, kind);
        parse_block(b, null, false);
        block.codes.push_back(new code(lex.line, script_engine.pc_call, b, 0));
    }

    public void parse_block(script_engine.block block, List< string > args, bool adding_result)
    {
        if (lex.next != token_kind.tk_open_cur)
        {
            string error;
            error += "\"{\" is nessasary.\r\n";
            error += "(\"{\"���K�v�ł�)";
            throw new parser_error(error);
        }
        lex.advance();

        frame.Add(new scope(block.kind));

        scan_current_scope(block.level, args, adding_result);

        if (args != null)
        {
            if (false)
            {
                ;
            }
            else
            {
                for (uint i = 0; i < args.Count; ++i)
                {
                symbol s = search(args[i]);
                block.codes.push_back(new code(lex.line, script_engine.pc_assign, s.level, s.variable));
                }
            }
        }
        parse_statements(block);

        frame.RemoveAt(frame.Count - 1);

        if (lex.next != token_kind.tk_close_cur)
        {
            string error;
            error += "\"}\" is nessasary.\r\n";
            error += "(\"}\"���K�v�ł�)";
            throw new parser_error(error);
        }
        lex.advance();
    }

    private void register_function(function func)
    {
        symbol s = new symbol();
        s.level = 0;
        s.sub = engine.new_block(0, script_engine.bk_function);
        s.sub.arguments = (int)func.arguments;
        s.sub.name = func.name;
        s.sub.func = func.func;
        s.variable = -1;
        frame[0][func.name] = s;
    }

    private parser.symbol search(string name)
    {
        if (false)
        {
            ;
        }
        else
        {
            for (int i = frame.Count - 1; i >= 0; --i)
            {
            if (frame[i].ContainsKey(name))
            {
                return  (frame[i][name]);
            }
            }
        }
        return null;
    }

    private parser.symbol search_result()
    {
        if (false)
        {
            ;
        }
        else
        {
            for (int i = frame.Count - 1; i >= 0; --i)
            {
            if (frame[i].ContainsKey("result"))
            {
                return  (frame[i]["result"]);
            }
            if (frame[i].kind == script_engine.bk_sub || frame[i].kind == script_engine.bk_microthread)
            {
                return null;
            }
            }
        }
        return null;
    }

    private void scan_current_scope(int level, List< string > args, bool adding_result)
    {
        // ��ǂ݂��Ď��ʎq��o�^����
        scanner lex2 = new scanner(lex);
        try
        {
            scope current_frame = frame[frame.Count - 1];
            int cur = 0;
            int @var = 0;

            if (adding_result)
            {
                symbol s = new symbol();
                s.level = level;
                s.sub = null;
                s.variable = @var;
                ++@var;
                 current_frame["result"] = s;
            }

            if (args != null)
            {
                if (false)
                {
                    ;
                }
                else
                {
                    for (uint i = 0; i < args.Count; ++i)
                    {
                    symbol s = new symbol();
                    s.level = level;
                    s.sub = null;
                    s.variable = @var;
                    ++@var;
                     current_frame[args[i]] = s;
                    }
                }
            }

            while (cur >= 0 && lex2.next != token_kind.tk_end && lex2.next != token_kind.tk_invalid)
            {
                switch (lex2.next)
                {
                    case token_kind.tk_open_cur:
                        ++cur;
                        lex2.advance();
                        break;
                    case token_kind.tk_close_cur:
                        --cur;
                        lex2.advance();
                        break;
                    case token_kind.tk_at:
                    case token_kind.tk_SUB:
                    case token_kind.tk_FUNCTION:
                    case token_kind.tk_TASK:
                    {
                            token_kind type = lex2.next;
                            lex2.advance();
                            if (cur == 0)
                            {
                                if (current_frame.find(lex2.word) !=  current_frame.end())
                                {
                                    string error;
                                    error += "Functions and variables of the same name are declared in the same scope.\r\n";
                                    error += "(�����X�R�[�v�œ�����?�[�`?����?�錾����Ă��܂�)";
                                    throw new parser_error(error);
                                }
                                script_engine.block_kind kind = (type == token_kind.tk_SUB || type == token_kind.tk_at) ? script_engine.bk_sub : (type == token_kind.tk_FUNCTION) ? script_engine.bk_function : script_engine.bk_microthread;

                                symbol s = new symbol();
                                s.level = level;
                                s.sub = engine.new_block(level + 1, kind);
                                s.sub.name = lex2.word;
                                s.sub.func = null;
                                s.variable = -1;
                                 current_frame[lex2.word] = s;
                                lex2.advance();
                                if (kind != script_engine.bk_sub && lex2.next == token_kind.tk_open_par)
                                {
                                    lex2.advance();
                                    while (lex2.next == token_kind.tk_word || lex2.next == token_kind.tk_LET || lex2.next == token_kind.tk_REAL)
                                    {
                                        ++(s.sub.arguments);
                                        if (lex2.next == token_kind.tk_LET || lex2.next == token_kind.tk_REAL)
                                        {
                                            lex2.advance();
                                        }
                                        if (lex2.next == token_kind.tk_word)
                                        {
                                            lex2.advance();
                                        }
                                        if (lex2.next != token_kind.tk_comma)
                                        {
                                            break;
                                        }
                                        lex2.advance();
                                    }
                                }
                            }
                    }
                        break;
                    case token_kind.tk_REAL:
                    case token_kind.tk_LET:
                        lex2.advance();
                        if (cur == 0)
                        {
#if __SCRIPT_H__NO_CHECK_DUPLICATED
                if (lex2.word == "result")
                {
#endif
                              if (current_frame.find(lex2.word) !=  current_frame.end())
                              {
                                string error;
                                error += "Variables of the same name are declared in the same scope.\r\n";
                                error += "(�����X�R�[�v�œ����̕�?����?�錾����Ă��܂�)";
                                throw new parser_error(error);
                              }
#if __SCRIPT_H__NO_CHECK_DUPLICATED
                }
#endif
                            symbol s = new symbol();
                            s.level = level;
                            s.sub = null;
                            s.variable = @var;
                            ++@var;
                             current_frame[lex2.word] = s;

                            lex2.advance();
                        }
                        break;
                    default:
                        lex2.advance();
                        break;
                }
            }
        }
        catch
        {
            lex.line = lex2.line;
            throw;
        }
    }

    private void write_operation(script_engine.block block, string name, int clauses)
    {
        symbol s = search(name);
        Debug.Assert(s != null);
        if (s.sub.arguments != clauses)
        {
            string error;
            error += "Overwriting function does not allow to different argument count.\r\n";
            error += "(?�Z�q�ɑ�?�����?����?����`����܂�������?��?���Ⴂ�܂�)";
            throw new parser_error(error);
        }

        block.codes.push_back(new script_engine.code(lex.line, script_engine.pc_call_and_push_result, s.sub, clauses));
    }

}

/* script_type_manager */



/* script_engine */




/* script_machine */










