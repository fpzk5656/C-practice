using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 그리디 알고리즘
            //500원, 100원, 50원, 10원 짜리들로 최적의 해를 구하는..

            int n, result = 0;
            n = Int32.Parse(Console.ReadLine());

            result += n / 500;
            n %= 500;
            result += n / 100;
            n %= 100;
            result += n / 50;
            n %= 50;
            result += n / 10;

            Console.WriteLine(result);
        }
    }
}
