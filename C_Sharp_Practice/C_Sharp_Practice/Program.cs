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
            //텔레포트 하듯 구문을 뛰어넘어주는 점프문
            // goto 문

            Console.Write("종료 조건 (숫자)을 입력하세요 : ");

            String input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);
            int exit_number = 0;

            // 3중 for문으로 exit_number에 ++ 해주므로
            // 2 *2*3* = 12가 된다. 그안에 입력한 숫자(input_number)와 같지 못하면
            // EXIT_FOR를 만나지 않고 EXIT_PROGRAM만 만난다
            for(int i = 0; i < 2; i++)
            {
                for(int j =0; j< 2; j++)
                {
                    for(int k = 0; k <3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");

        }
    }
}
