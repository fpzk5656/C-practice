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

            string a = "안녕하세요?";
            string b = "선을로 입니다";
            bool c = true;
            object d = a + b + c;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine();

            //크기가 서로 다른 부동 소수점 형식 사이의 변환
            float i = 69.6875f;
            Console.WriteLine("i : {0}", i);

            double j = (double)i;
            Console.WriteLine("j : {0}", j);

            Console.WriteLine("69.6875 == j : {0}", 69.6875 == j);
            float x = 0.1f;
            Console.WriteLine("x : {0}", x);

            double y = (double)x;
            Console.WriteLine("y : {0}", y);

            Console.WriteLine("0.1 == y : {0}", 0.1 == y);
        }
    }
}
