using System;
using ARConverter.Utils;

namespace ARConverter;
public static class Program
{
    static void Main(string[] args)
    {
        string src_path = args[0] ?? InputPath(); // 拖入文件时直接解析
        

    }

    static string InputPath()
    {
        Console.WriteLine("请输入文件路径：");
        string input = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("路径不能为空，请重新输入！");
            return InputPath();
        }
        return input;
    }
}