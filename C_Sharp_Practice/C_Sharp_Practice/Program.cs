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
            //열거형식의 자동 정수 할당과 bool값으로 이용
            Console.WriteLine((int)DialogResult.YES);

            DialogResult dia = DialogResult.NO;
            Console.WriteLine((int)dia);

            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            Console.WriteLine(dia == DialogResult.NO);
            Console.WriteLine(dia == DialogResult.YES);
        }
    }
}
