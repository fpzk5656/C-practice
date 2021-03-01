using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Program
    {
        // ref 키워드 사용법 예시
        // 참조에 의한 전달 "Call by reference"로 넘길 수 있는 키워드이다.

        //그냥 int 매개변수에 담아서 스왑하는것만으로는 "Call by value"이기 때문에 바로 전달이 되지 않으니,
        //ref를 사용해 바로 매개변수에 복사해주는 변수에 영향을 끼칠 수 있다.
        static void Swap(ref int a ,ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine("x:{0}, y:{1}", x, y);

            Swap(ref x, ref y);

            Console.WriteLine("x:{0}, y:{1}", x, y);
        }
    }
}
