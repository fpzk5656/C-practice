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

            //C#은 강력한 형식언어라서 깐깐하게 검사를 하는 언어 이지만,
            // 약한 형식을 제공하기도 한다 var 이라는 키워드를 통해!
            //var은 선언과 동시에 반드시 초기화 시켜줘야 하며,
            //지역변수로만 사용가능
            //..애초에 C#은 전역 변수를 지원하지 않도록 설계 되어 있다 함

            var a = 201;
            var b = 27.826;
            var c = "Hello";
            var d = new int[] { 1, 7, 9 };
            //프로그래머가 일일이 형식을 지정하는게 아닌,
            //컴파일러가 알아서 지정해주는 키워드

            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);
            foreach (var e in d)
                Console.Write("{0} ", e);

            Console.WriteLine();

        }
    }
}
