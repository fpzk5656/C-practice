using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK = 99 }
        static void Main(string[] args)
        {
            //열거형식을 정수로  출력 해보기
            Console.WriteLine((int)DialogResult.YES);

            DialogResult dia = DialogResult.NO;
            Console.WriteLine((int)dia);

            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            Console.WriteLine("열거형은 C++과 그다지 차이가 없는듯");
        }
    }
}
