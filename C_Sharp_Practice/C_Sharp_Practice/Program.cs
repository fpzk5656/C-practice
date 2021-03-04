using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            //out은 ref랑 비슷하지만 참조한 매개변수에 영향을 주지 않으면 에러가 뜬다.

            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            int c;
            int d;

            Divide(a, b, out c, out d);

            Console.WriteLine("a:{0}, b:{1}, a/b:{2}, a%b:{3}", a, b, c, d);
        }
    }
}
