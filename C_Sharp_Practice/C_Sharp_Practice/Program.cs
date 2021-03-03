﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }

            Console.WriteLine("Name : {0}, Phone : {1}", name, phone);
        }

        static void Main(string[] args)
        {
            //재귀호출 예시

            Console.WriteLine("10번째 피보나치 수 : {0}", Fibonacci(10));

            PrintProfile("", "123-4567");
            PrintProfile("이창규", "456-1230");
        }
    }
}
