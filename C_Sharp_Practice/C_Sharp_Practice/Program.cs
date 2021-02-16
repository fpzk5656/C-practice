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
            int e;
            e = (int)d;
            Console.WriteLine(e);
        }
    }
}
