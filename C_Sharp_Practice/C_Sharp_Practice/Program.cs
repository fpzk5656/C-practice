using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Program
    {
        enum DialogResult { YES = 10, NO, CANCEL = 62, CONFIRM, OK = 99 }
        static void Main(string[] args)
        {
            //.NET 공용 형식 시스템 (Common Type System 이하 CTS) C#에서 활용 예시]

            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type: {0}. value: {1}", a.GetType().ToString(), a);
            Console.WriteLine("b type: {0}. value: {1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type: {0}. value: {1}", c.GetType().ToString(), c);
            Console.WriteLine("d type: {0}. value: {1}", d.GetType().ToString(), d);

        }
    }
}
