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
            //중첩 for문 이용한 별찍기

            for(int i = 0; i <5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    //j가 i와 같아질 때까지
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
