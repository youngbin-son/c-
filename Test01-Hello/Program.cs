using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Program pgm = new Program();
            //int i = pgm.function();
            Test01 sub = new Test01();
            sub.MainFunc();
        }
        //int function()
        //{
        //    while (true) { }
        //    return 1;
        //}
    }
    class Test01    // main class
    {
        public Test01()
        {
            //Console.WriteLine("Hello world...!");
        }
        public void MainFunc()
        {
            var v = 100;
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;
            Object o = i + 1;
            WriteLine("Hello World({0},{1},{4},{5})\nMain Function({2},{3})",i,j,d,e,o,v);  // printf 함수와 동일
            o = d + 0.5;
            WriteLine("Hello World({0},{1})\nMain Function({2},{3},{4})",i,j,d,e,o);  // printf 함수와 동일
            while (true)
            {
                try
                {
                    WriteLine("2개의 정수를 입력하세요.");
                    string str = Console.ReadLine();    // str = "10 20"
                    i = int.Parse(str.Split(' ')[0]);
                    j = int.Parse(str.Split(' ')[1]);
                    WriteLine($"Hello World({i},{j})");  // printf 함수와 동일

                    WriteLine("2개의 실수를 입력하세요.");
                    str = ReadLine();
                    d = double.Parse(str.Split(' ')[0]);
                    e = double.Parse(str.Split(' ')[1]);
                    WriteLine($"Hello World({d},{e})");  // printf 함수와 동일
                    //string str = "STX" + i.ToString() + "ETX";
                    //string st1 = $"STX{i,5}ETX";
                    //WriteLine(str); Console.WriteLine(st1);
                }
                catch (Exception e1)
                {
                    WriteLine(e1.Message);
                }
            }
        }
    }
}
