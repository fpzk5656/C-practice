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
            // 관계 연산자

            Console.WriteLine("3 > 4 : {0}", 3 > 4);
            Console.WriteLine("3 >= 4 : {0}", 3 >= 4);
            Console.WriteLine("3 < 4 : {0}", 3 < 4);
            Console.WriteLine("3 <= 4 : {0}", 3 <= 4);
            Console.WriteLine("3 == 4 : {0}", 3 == 4);
            Console.WriteLine("3 != 4 : {0}", 3 != 4);

            // 조건 연산자
            //피연산자가 3개 이상

            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
