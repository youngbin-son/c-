﻿using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Test01_Hello
{
    static class MyLib
    {
        public static string GetToken(string str, int n, char ch)    //(str) : "1 2 3 " "1,2,3", (n):n번째,  (ch)','
        {
            return str.Split(ch)[n];
        }
    }
    class Point
    {
        int x, y;
        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public double Dist(Point p1)
        {
            int d1 = p1.x - x;
            int d2 = p1.y - y;
            return Math.Sqrt(Math.Pow(d1, 2)+Math.Pow(d2, 2));
        }
        public static double operator - (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2));
        }   
        public static double operator * (Point p1, Point p2)
        {
            int d1 = Math.Abs(p1.x - p2.x);
            int d2 = Math.Abs(p1.y - p2.y);
            return d1 * d2;
        }
    }
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
        delegate void cbTest();
        void f1() { WriteLine("delegate Test 01");}
        void f2() { WriteLine("delegate Test 02");}
        void f3() { WriteLine("delegate Test 03");}
        void Func_DelegateTest()
        {
            cbTest cb1;
            cb1 = new cbTest(f1); cb1();
            cb1 = new cbTest(f2); cb1();
            cb1 = new cbTest(f3); cb1();
          
        }
        public Test01()
        {
            //Console.WriteLine("Hello world...!");
        }
        public void Func_PointTest()
        {
            Point p1 = new Point(10,20);
            Point p2 = new Point(30,40);
            WriteLine($"두 점 P1(10,20)과 P2(30,40)의 거리는 DIST {p1.Dist(p2):F2}  [{p1-p2}]입니다.");
            WriteLine($"두 점 P1(10,20)과 P2(30,40)의 사각형 넓이는 [{p1*p2}]입니다.");
            string s1 = "Good ";
            string s2 = "morning";
            string s3 = s1 + s2;
            WriteLine(s3);
        }
        public void Func_ReadWrite()
        {
            //Func1();return;
            int i = 10, j = 20;
            var v = i * 10;
            double d = 1.5, e = 3.1;
            Object o = i + 1;
            WriteLine("Hello World({0},{1},{4},{5})\nMain Function({2},{3})", i, j, d, e, o, v);  // printf 함수와 동일
            o = d + 0.5;
            //v = d * 10; //오류  var v = i * 10에서 v의 자료형은 int로 고정됨 
            v = j * 10;
            int k = sizeof(int);
            WriteLine("Hello World({0},{1})\nMain Function({2},{3},{4})", i, j, d, e, o);  // printf 함수와 동일
            WriteLine("i:{0}, j:{1}, d:{2}, e:{3}, o:{4}", i, j, d, e, o);
            WriteLine($"i:{sizeof(int)}, d:{sizeof(double)}");

            int[] arr = new int[i];
            for (int i1 = 0; i1 < 10; i1++) arr[i1] = i1;

            //MyLib my = new MyLib(); 
            //while (true)
            {
                try
                {
                    WriteLine("2개의 정수를 입력하세요.");
                    string str = Console.ReadLine();    // str = "10 20"
                    //i = int.Parse(str.Split(' ')[0]);
                    //j = int.Parse(str.Split(' ')[1]);
                    i = int.Parse(MyLib.GetToken(str, 0, ' '));
                    j = int.Parse(MyLib.GetToken(str, 1, ' '));
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
        public const int v = 0;
        int ArrSum(int[] arr)   // int 배열 요소의 합
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        void PrintArr<T>(T[]arr)
        {
            int i = 0;
            foreach (T a in arr)
            {
                Write($"[{i++}]{a}"); 
            }
        }
        void InitArr(out int[] arr, int n)
        {
            arr = new int[n];
            foreach (int a in arr) arr[a] = a;
        }
        void CallArr(int[] arr)
        {
            arr[2] = 100;
            arr[4] = 200;
            
        }
        public void Func_ArrayTest()
        {
            int[] arr;// = new int[10];
            int[] arr1 = { 0, 1, 2, 3, 4 };
            double[] drr = { 0.1, 0.2, 0.3, 0.4, 0.5 };
            Point[] parr = new Point[10];
            int[,] brr = { { 10, 11, 12, 13, 14 }, { 20, 21, 22, 23, 24 } };
            int[][] crr =
            {
               new int [] {1,2,3,4,5},
               new int [] {6,7,8,9,10}
            };
            //WriteLine($"{ArrSum(drr)}");
  
            InitArr(out arr, 10);
            for(int i =0; i < 10; i++)
            {
                Write($"arr[{i}]:{arr[i]}  ");
            }
            WriteLine("");
            CallArr(arr);
            Array.Copy(crr[0], arr, 5);
            for (int i = 0; i < 10; i++)
            {
                Write($"arr[{i}]:{arr[i]}\n");
            }

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < crr[i].Length; j++)
                {
                    Write($"crr[{i},{j}]:{crr[i][j]} ");
                }
                WriteLine("");
            }
                WriteLine("");

            crr[0].CopyTo(arr, 0);
            for (int i = 0; i < 10; i++)
            {
                Write($"arr[{i}]:{arr[i]}\n");
            }

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Write($"brr[{i},{j}]:{brr[i, j]}  ");
                }
                WriteLine("");
            }

            WriteLine($"Sum of [arr] : {ArrSum(arr1)}");
            WriteLine($"Length of [arr] : {arr.Length}");
            arr.Append<int>(1);
            WriteLine($"Length of [arr] : {arr.Length}");
        }
        public void MainFunc()  //주 진입점 (실행 함수)
        {
            //Func_PointTest();return;
            //Func_ReadWrite();return;
            Func_DelegateTest();return;
        }   
    }
}
