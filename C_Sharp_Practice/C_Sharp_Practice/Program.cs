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
            // Nullable 형식은 값형식에 한해서만 가능, 참조형식은 불가능
            // HasValue와 Value 두 가지 속성을 지님

            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a == null);
            Console.WriteLine(a != null);
            //Console.WriteLine(a.Value); <- 이렇게 해버리면 오류 뜸. 
            //그래서 HasValue로 확인하는 것임

            Console.WriteLine("=======================");
            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a == null);
            Console.WriteLine(a.Value);
        }
    }
}
