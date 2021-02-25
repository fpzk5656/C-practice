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
            //반복문에서의 점프문

            // continue;
            for(int i= 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine("{0} : 홀수", i);
            }
            // break;
            while(true)
            {
                Console.Write("계속할까요? (예 / 아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    return;

            }


        }
    }
}
