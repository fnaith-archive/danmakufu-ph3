/* ---------------------------------- */
/* 2004..2005 YT、mkm(本体担?ですよ)*/
/* このソースコードは煮るなり焼くなり好きにしろ?イセ?スの元で配布します。*/
/* A-3、A-4に従い、このソースを組み?んだ.exeには?イセ?スは適用されません。*/
/* ---------------------------------- */
/* NYSL Version 0.9982 */
/* A. 本ソフトウェアは Everyone'sWare です。このソフトを手にした一人一人が、*/
/*    ご自分の作ったものを扱うのと同じように、自由に?用することが出?ます。*/
/* A-1. フ?ーウェアです。作者からは使用料?を要?しません。*/
/* A-2. 有料無料や媒体の如何を問わず、自由に転載・再配布できます。*/
/* A-3. いかなる種類の 改変・他プ?グ??での?用 を行っても構いません。*/
/* A-4. 変更したものや?分的に使用したものは、?なたのものになります。*/
/*      公開する場?は、?なたの名前の下で行って下さい。*/
/* B. このソフトを?用することによって生じた損害?について、作者は */
/*    責任を?わないものとします。各自の責任においてご?用下さい。*/
/* C. ?作者人格?は ???? に帰属します。?作?は放棄します。*/
/* D. 以上の３?は、ソース・実行バイナ?の双方に適用されます。 */
/* ---------------------------------- */

#if !defined(__SCRIPT_H__)
#define __SCRIPT_H__

#pragma warning (disable:4786)	//STL Warning抑止
#pragma warning (disable:4018)	//signed と unsigned の?値を比較
#pragma warning (disable:4244)	//double' から 'float' に変換
#include<list>
#include<vector>
#include<string>
#include<map>

// debug
#include<iostream>
//#define _TRACE_VALUE
//#define _TRACE_COMMAND
//#define _TRACE_TOKEN
#define _REPORT_INFO
//#define _REPORT_OK
#define _REPORT_FAIL

//重複宣言チェックをしない
//#define __SCRIPT_H__NO_CHECK_DUPLICATED

long double fmodl2(long double i, long double j);

//-------- 汎用
namespace gstd
{
	std::string to_mbcs(std::wstring const & s);
	std::wstring to_wide(std::string const & s);

	template < typename T >
	class lightweight_vector
	{
	public:
		unsigned length;
		unsigned capacity;
		T * at;

		lightweight_vector() : length(0), capacity(0), at(NULL)
		{
		}

		lightweight_vector(lightweight_vector const & source);

		~lightweight_vector()
		{
			if(at != NULL)
			{
				delete[] at;
			}
		}

		lightweight_vector & operator = (lightweight_vector const & source);

		void expand();

		void push_back(T const & value)
		{
			if(length == capacity) expand();
			at[length] = value;
			++length;
		}

		void pop_back()
		{
			--length;

			T temp;
			at[length] = temp;
		}

		void clear()
		{
			length = 0;
		}

		void release()
		{
			length = 0;
			if(at != NULL)
			{
				delete[] at;
				at = NULL;
				capacity = 0;
			}
		}

		unsigned size() const
		{
			return length;
		}

		T & operator[] (unsigned i)
		{
			return at[i];
		}

		T const & operator[] (unsigned i) const
		{
			return at[i];
		}

		T & back()
		{
			return at[length - 1];
		}

		T * begin()
		{
			return & at[0];
		}

		void erase(T * pos);
		void insert(T * pos, T const & value);
	};

	template < typename T >
	lightweight_vector < T >::lightweight_vector(lightweight_vector const & source)
	{
		length = source.length;
		capacity = source.capacity;
		if(source.capacity > 0)
		{
			at = new T[source.capacity];
			for(int i = length - 1; i >= 0; --i)
				at[i] = source.at[i];
		}
		else
		{
			at = NULL;
		}
	}

	template < typename T >
	lightweight_vector < T > & lightweight_vector < T >::operator = (lightweight_vector < T > const & source)
	{
		if(at != NULL) delete[] at;
		length = source.length;
		capacity = source.capacity;
		if(source.capacity > 0)
		{
			at = new T[source.capacity];
			for(int i = length - 1; i >= 0; --i)
				at[i] = source.at[i];
		}
		else
		{
			at = NULL;
		}
		return * this;
	}

	template < typename T >
	void lightweight_vector < T >::expand()
	{
		if(capacity == 0)
		{
			//delete[] at;
			capacity = 4;
			at = new T[4];
		}
		else
		{
			capacity *= 2;
			T * n = new T[capacity];
			for(int i = length - 1; i >= 0; --i)
				n[i] = at[i];
			delete[] at;
			at = n;
		}
	}

	template < typename T >
	void lightweight_vector < T >::erase(T * pos)
	{
		--length;
		for(T * i = pos; i < at + length; ++i)
		{
			* i = * (i + 1);
		}
	}

	template < typename T >
	void lightweight_vector < T >::insert(T * pos, T const & value)
	{
		if(length == capacity)
		{
			unsigned pos_index = pos - at;
			expand();
			pos = at + pos_index;
		}
		for(T * i = at + length; i > pos; --i)
		{
			* i = * (i - 1);
		}
		* pos = value;
		++length;
	}

	//-------- ここから

	class type_data
	{
	public:
		enum type_kind
		{
			tk_real, tk_char, tk_boolean, tk_array
		};

		type_data(type_kind k, type_data * t = NULL) : kind(k), element(t)
		{
		}

		type_data(type_data const & source) : kind(source.kind), element(source.element)
		{
		}

		//デスト?クタはデフォ?トに任せる

		type_kind get_kind()
		{
			return kind;
		}

		type_data * get_element()
		{
			return element;
		}

	private:
		type_kind kind;
		type_data * element;

		type_data & operator = (type_data const & source);
	};

	class value
	{
	public:
#ifdef _TRACE_VALUE
		static int counter;
		int id;
#endif
		value() : data(NULL)
		{
#ifdef _TRACE_VALUE
			id = -1;
			//if (is_target()) throw std::exception("V1");
#endif
		}

		value(type_data * t, long double v)
		{
			data = new body();
			data->ref_count = 1;
			data->type = t;
			data->real_value = v;
#ifdef _TRACE_VALUE
			id = counter++;
			//if (is_target()) throw std::exception("V2");
#endif
		}

		value(type_data * t, wchar_t v)
		{
			data = new body();
			data->ref_count = 1;
			data->type = t;
			data->char_value = v;
#ifdef _TRACE_VALUE
			id = counter++;
			//if (is_target()) throw std::exception("V3");
#endif
		}

		value(type_data * t, bool v)
		{
			data = new body();
			data->ref_count = 1;
			data->type = t;
			data->boolean_value = v;
#ifdef _TRACE_VALUE
			id = counter++;
			//if (is_target()) throw std::exception("V4");
#endif
		}

		value(type_data * t, std::wstring v);

		value(value const & source)
		{
#ifdef _TRACE_VALUE
			if (source.is_target())
			{
				std::cout << "V:assign source " << (source.id) << "=" << to_mbcs(source.as_string()) << std::endl;
			}
			id = 10000 + source.id;
			//if (is_target()) throw std::exception("V5");
#endif
			data = source.data;
			if(data != NULL)
				++(data->ref_count);
		}

		~value()
		{
			release();
		}

		value & operator = (value const & source)
		{
#ifdef _TRACE_VALUE
			if (is_target() || source.is_target())
			{
				std::cout << "V:assign this " << (this->id) << "=" << to_mbcs(this->as_string()) << std::endl;
				std::cout << "V:assign source " << (source.id) << "=" << to_mbcs(source.as_string()) << std::endl;
			}
			id = source.id;
#endif
			if(source.data != NULL)
			{
				++(source.data->ref_count);
			}
			release();
			data = source.data;
			return * this;
		}

		bool has_data() const
		{
			return data != NULL;
		}

#ifdef _TRACE_VALUE
		bool is_target() const
		{
			return false;//id == 10001;
		}
#endif

		void set(type_data * t, long double v)
		{
			unique();
			data->type = t;
			data->real_value = v;
#ifdef _TRACE_VALUE
			if (is_target())
			{
				std::cout << "V:set double " << to_mbcs(this->as_string()) << std::endl;
			}
#endif
		}

		void set(type_data * t, bool v)
		{
			unique();
			data->type = t;
			data->boolean_value = v;
#ifdef _TRACE_VALUE
			if (is_target())
			{
				std::cout << "V:set bool " << to_mbcs(this->as_string()) << std::endl;
			}
#endif
		}

		void append(type_data * t, value const & x);
		void concatenate(value const & x);

		long double as_real() const;
		wchar_t as_char() const;
		bool as_boolean() const;
		std::wstring as_string() const;
		unsigned length_as_array() const;
		value const & index_as_array(unsigned i) const;
		value & index_as_array(unsigned i);
		type_data * get_type() const;

		void unique() const
		{
			if(data == NULL)
			{
				data = new body();
				data->ref_count = 1;
				data->type = NULL;
			}
			else if(data->ref_count > 1)
			{
				--(data->ref_count);
				data = new body(* data);
				data->ref_count = 1;
			}
#ifdef _TRACE_VALUE
			if (is_target())
			{
				std::cout << "V:unique " << to_mbcs(this->as_string()) << std::endl;
			}
#endif
		}

		void overwrite(value const & source);	//危険！外から呼ぶな

	private:
		inline void release() 
		{
			if(data != NULL)
			{
				--(data->ref_count);
				if(data->ref_count == 0)
				{
					delete data;
				}
			}
		}
		struct body
		{
			int ref_count;
			type_data * type;
			lightweight_vector < value > array_value;

			union
			{
				long double real_value;
				wchar_t char_value;
				bool boolean_value;
			};
		};

		mutable body * data;
	};

	class script_engine;
	class script_machine;

	typedef value(* callback) (script_machine * machine, int argc, value const * argv);

	struct function
	{
		char const * name;
		callback func;
		unsigned arguments;
	};

	class script_type_manager
	{
	public:
		script_type_manager();

		type_data * get_real_type()
		{
			return real_type;
		}

		type_data * get_char_type()
		{
			return char_type;
		}

		type_data * get_boolean_type()
		{
			return boolean_type;
		}

		type_data * get_string_type()
		{
			return string_type;
		}

		type_data * get_array_type(type_data * element);
	private:
		script_type_manager(script_type_manager const &);
		script_type_manager & operator = (script_type_manager const & source);

		std::list < type_data > types;	//?身のポイ?タを使うのでアド?スが変わらないようにlist
		type_data * real_type;
		type_data * char_type;
		type_data * boolean_type;
		type_data * string_type;
	};

	class script_engine
	{
	public:
		script_engine(script_type_manager * a_type_manager, std::string const & source, int funcc, function const * funcv);
		script_engine(script_type_manager * a_type_manager, std::vector<char> const & source, int funcc, function const * funcv);
		virtual ~script_engine();

		void * data;	//ク?イア?ト用空間

		bool get_error()
		{
			return error;
		}

		std::wstring & get_error_message()
		{
			return error_message;
		}

		int get_error_line()
		{
			return error_line;
		}

		script_type_manager * get_type_manager()
		{
			return type_manager;
		}

		//compatibility
		type_data * get_real_type()
		{
			return type_manager->get_real_type();
		}

		type_data * get_char_type()
		{
			return type_manager->get_char_type();
		}

		type_data * get_boolean_type()
		{
			return type_manager->get_boolean_type();
		}

		type_data * get_array_type(type_data * element)
		{
			return type_manager->get_array_type(element);
		}

		type_data * get_string_type()
		{
			return type_manager->get_string_type();
		}

	#ifndef _MSC_VER
	private:
	#endif

		//コピー、代入?算子の自動生成を無効に
		script_engine(script_engine const & source);
		script_engine & operator = (script_engine const & source);

		//エ?ー
		bool error;
		std::wstring error_message;
		int error_line;

		//型
		script_type_manager * type_manager;

		//?間コード
		enum command_kind
		{
			pc_assign, pc_assign_writable, pc_break_loop, pc_break_routine, pc_call, pc_call_and_push_result, pc_case_begin,
			   pc_case_end, pc_case_if, pc_case_if_not, pc_case_next, pc_compare_e, pc_compare_g, pc_compare_ge, pc_compare_l,
			   pc_compare_le, pc_compare_ne, pc_dup, pc_dup2, pc_loop_ascent, pc_loop_back, pc_loop_count, pc_loop_descent, pc_loop_if,
			   pc_pop, pc_push_value, pc_push_variable, pc_push_variable_writable, pc_swap, pc_yield
		};
#ifdef _TRACE_COMMAND
		static std::string command_kind_to_name(command_kind the_command);
#endif

		struct block;

		struct code
		{
			command_kind command;
			int line;	//ソースコード上の行
			value data;	//pc_push_valueでpushするデータ

			union
			{
				struct
				{
					int level;	//assign/push_variableの変?の環境位置
					unsigned variable;	//assign/push_variableの変?のイ?デックス
				};
				struct
				{
					block * sub;	//call/call_and_push_resultの飛び先
					unsigned arguments;	//call/call_and_push_resultの引?の?
				};
				struct
				{
					int ip;	//loop_backの戻り先
				};
			};

			code()
			{
			}

			code(int the_line, command_kind the_command) : line(the_line), command(the_command)
			{
#ifdef _TRACE_COMMAND
				std::cout << "C1:" << script_engine::command_kind_to_name(the_command) << std::endl;
#endif
			}

			code(int the_line, command_kind the_command, int the_level, unsigned the_variable) : line(the_line), command(the_command), level(the_level), variable(the_variable)
			{
#ifdef _TRACE_COMMAND
				std::cout << "C2:" << script_engine::command_kind_to_name(the_command) << std::endl;
#endif
			}

			code(int the_line, command_kind the_command, block * the_sub, int the_arguments) : line(the_line), command(the_command), sub(the_sub),
			   arguments(the_arguments)
			   {
#ifdef _TRACE_COMMAND
				std::cout << "C3:" << script_engine::command_kind_to_name(the_command) << std::endl;
#endif
			}

			code(int the_line, command_kind the_command, int the_ip) : line(the_line), command(the_command), ip(the_ip)
			{
#ifdef _TRACE_COMMAND
				std::cout << "C4:" << script_engine::command_kind_to_name(the_command) << std::endl;
#endif
			}

			code(int the_line, command_kind the_command, value const & the_data) : line(the_line), command(the_command), data(the_data)
			{
#ifdef _TRACE_COMMAND
				std::cout << "C5:" << script_engine::command_kind_to_name(the_command) << std::endl;
#endif
			}
		};

		enum block_kind
		{
			bk_normal, bk_loop, bk_sub, bk_function, bk_microthread
		};

		friend struct block;

		typedef lightweight_vector < code > codes_t;

		struct block
		{
			int level;
			int arguments;
			std::string name;
			callback func;
			codes_t codes;
			block_kind kind;

			block(int the_level, block_kind the_kind) : level(the_level), arguments(0), name(), func(NULL), codes(), kind(the_kind)
			{
			}
		};

		std::list < block > blocks;	//?身のポイ?タを使うのでアド?スが変わらないようにlist
		block * main_block;
		std::map < std::string, block * > events;

		block * new_block(int level, block_kind kind)
		{
			block x(level, kind);
			return & * blocks.insert(blocks.end(), x);
		}

		friend class parser;
		friend class script_machine;
	};

	class script_machine
	{
	public:
		script_machine(script_engine * the_engine);
		virtual ~script_machine();

		void * data;	//ク?イア?ト用空間

		void run();
		void call(std::string event_name);
		void resume();

		void stop()
		{
			finished = true;
			stopped = true;
		}

		bool get_stopped()
		{
			return stopped;
		}

		bool get_resuming()
		{
			return resuming;
		}

		bool get_error()
		{
			return error;
		}

		std::wstring & get_error_message()
		{
			return error_message;
		}

		int get_error_line()
		{
			return error_line;
		}

		void raise_error(std::wstring const & message)
		{
			error = true;
			error_message = message;
			finished = true;
		}
		void terminate(std::wstring const & message)
		{
			bTerminate = true;
			error = true;
			error_message = message;
			finished = true;
		}

		script_engine * get_engine()
		{
			return engine;
		}

		bool has_event(std::string event_name);

		int get_current_line();

	private:
		script_machine();
		script_machine(script_machine const & source);
		script_machine & operator = (script_machine const & source);

		script_engine * engine;

		bool error;
		std::wstring error_message;
		int error_line;

		bool bTerminate;

		typedef lightweight_vector < value > variables_t;
		typedef lightweight_vector < value > stack_t;

		struct environment
		{
			environment * pred, * succ;	//双方向??ク?スト
			environment * parent;
			int ref_count;
			script_engine::block * sub;
			unsigned ip;
			variables_t variables;
			stack_t stack;
			bool has_result;
		};

		std::list<environment *> call_start_parent_environment_list;
		environment * first_using_environment;
		environment * last_using_environment;
		environment * first_garbage_environment;
		environment * last_garbage_environment;
		environment * new_environment(environment * parent, script_engine::block * b);
		void dispose_environment(environment * object);

		typedef lightweight_vector < environment * > threads_t;

		threads_t threads;
		unsigned current_thread_index;
		bool finished;
		bool stopped;
		bool resuming;

		void yield()
		{
			if(current_thread_index > 0)
				--current_thread_index;
			else
				current_thread_index = threads.size() - 1;
		}

		void advance();

	public:
		int get_thread_count(){return threads.size();}
	};

	template < int num >
	class constant
	{
	public:
		static value func(script_machine * machine, int argc, value const * argv)
		{
			return value(machine->get_engine()->get_real_type(), (long double) num);
		}
	};

}

#endif
