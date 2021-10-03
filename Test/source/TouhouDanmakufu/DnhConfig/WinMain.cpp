#include <array>
#include <string>
#include <fstream>
#include <streambuf>
#include <iostream>
#include <vector>

#include"../../GcLib/gstd/GstdUtility.hpp"
#include"../../GcLib/gstd/Script.hpp"

using namespace gstd;

std::string read_func(std::string file_path)
{
	std::ifstream t(file_path);
	std::string str((std::istreambuf_iterator<char>(t)), std::istreambuf_iterator<char>());
	return str;
}

class TestResult {
public:
	bool engine_error;
	bool machine_error;
	TestResult(bool engine_error_, bool machine_error_) : engine_error(engine_error_), machine_error(machine_error_) {}
};

TestResult parse_script(std::string file_path)
{
	script_type_manager* type_manager = new script_type_manager();
	std::string source = read_func(file_path);
	int funcc = 0;
	function* funcv = {};
	script_engine* engine = new script_engine(type_manager, source, funcc, funcv);
	TestResult result(engine->get_error(), false);
	return result;
}

TestResult run_script(std::string file_path)
{
	script_type_manager* type_manager = new script_type_manager();
	std::string source = read_func(file_path);
	int funcc = 0;
	function* funcv = {};
	script_engine* engine = new script_engine(type_manager, source, funcc, funcv);
	script_machine* machine = new script_machine(engine);
	machine->run();
	TestResult result(engine->get_error(), machine->get_error());
	return result;
}

void test_ok_syntax(std::string test_dir_path)
{
	std::string script_file_paths[] = {
		"syntax/ok/Array.txt",
		"syntax/ok/Branch.txt",
		"syntax/ok/Comment.txt",
		"syntax/ok/EmptyFile.txt",
		"syntax/ok/Escape.txt",
		"syntax/ok/ExpressionsAndOperators.txt",
		"syntax/ok/Include.txt",
		"syntax/ok/LocalScope.txt",
		"syntax/ok/Loop.txt",
		"syntax/ok/MicroThread.txt",
		"syntax/ok/SampleA01.txt",
		"syntax/ok/SemicolonOnly.txt",
		"syntax/ok/Statement.txt",
		"syntax/ok/Subroutine.txt",
		"syntax/ok/UserDefineFunction.txt",
		"syntax/ok/Variable.txt"
	};
	std::cout << "ok syntax :" << std::endl;
	for (const std::string &script_file_path : script_file_paths)
	{
		TestResult result = parse_script(test_dir_path + script_file_path);
		if (result.engine_error)
		{
			std::cout << "\terror : " << script_file_path << std::endl;
			continue;
		}
		std::cout << "\tok : " << script_file_path << std::endl;
	}
}

void test_fail_syntax(std::string test_dir_path)
{
	std::string script_file_paths[] = {
		"syntax/fail/Lesson-4-LocalAndGlobalVariable-1.txt",
		"syntax/fail/Lesson-4-LocalAndGlobalVariable-2.txt",
		"syntax/fail/Lesson-4-LocalAndGlobalVariable-3.txt",
		"syntax/fail/Lesson-4-LocalAndGlobalVariable-4.txt",
		"syntax/fail/Lesson-4-LocalAndGlobalVariable-5.txt",
		"syntax/fail/Lesson-4-MathematicalOperation-1.txt",
		"syntax/fail/Lesson-4-MathematicalOperation-2.txt",
		"syntax/fail/Lesson-4-MathematicalOperation-3.txt",
		"syntax/fail/Lesson-4-Variable-1.txt",
		"syntax/fail/Lesson-4-Variable-2.txt",
	};
	std::cout << "fail syntax :" << std::endl;
	for (const std::string &script_file_path : script_file_paths)
	{
		TestResult result = parse_script(test_dir_path + script_file_path);
		if (!result.engine_error)
		{
			std::cout << "\terror : " << script_file_path << std::endl;
			continue;
		}
		std::cout << "\tok : " << script_file_path << std::endl;
	}
}

void test_ok_script(std::string test_dir_path)
{
	std::string script_file_paths[] = {
		"script/ok/Lesson-1-Init.txt",
		"script/ok/Lesson-4-Array.txt",
		"script/ok/Lesson-4-Comment.txt",
		"script/ok/Lesson-4-LocalAndGlobalVariable.txt",
		"script/ok/Lesson-4-MathematicalOperation.txt",
		"script/ok/Lesson-4-String.txt",
		"script/ok/Lesson-4-Variable.txt",
		"script/ok/Lesson-5-Boolean.txt",
		"script/ok/Lesson-5-Function.txt",
		"script/ok/Lesson-5-IfElse.txt",
		"script/ok/Lesson-5-Loop.txt",
		"script/ok/Task.txt"
	};
	std::cout << "ok script :" << std::endl;
	for (const std::string &script_file_path : script_file_paths)
	{
		TestResult result = run_script(test_dir_path + script_file_path);
		if (result.engine_error)
		{
			std::cout << "\tengine error : " << script_file_path << std::endl;
			continue;
		}
		if (result.machine_error)
		{
			std::cout << "\tmachine error : " << script_file_path << std::endl;
			continue;
		}
		std::cout << "\tok : " << script_file_path << std::endl;
	}
}

void test_fail_script(std::string test_dir_path)
{
	std::string script_file_paths[] = {
		"syntax/fail/Lesson-4-ChangeType.txt",
		"script/fail/Lesson-4-Array-1.txt",
		"script/fail/Lesson-4-Array-2.txt",
		"script/fail/Lesson-4-Array-3.txt",
		"script/fail/Lesson-5-Subroutine.txt"
	};
	std::cout << "fail script :" << std::endl;
	for (const std::string &script_file_path : script_file_paths)
	{
		TestResult result = run_script(test_dir_path + script_file_path);
		if (result.engine_error)
		{
			std::cout << "\tengine error : " << script_file_path << std::endl;
			continue;
		}
		if (!result.machine_error)
		{
			std::cout << "\tmachine error : " << script_file_path << std::endl;
			continue;
		}
		std::cout << "\tok : " << script_file_path << std::endl;
	}
}

int main(int argc, char *argv[])
{
	std::string test_dir_path = "D:/Repository/danmakufu-ph3/Test/test/";
	test_ok_syntax(test_dir_path);
	test_fail_syntax(test_dir_path);
	test_ok_script(test_dir_path);
	test_fail_script(test_dir_path);

	return 0;
}
