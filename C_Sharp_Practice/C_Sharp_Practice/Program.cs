using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    //얕은 복사 예시
    class MyClass
    {
        public int A;
        public int B;
    }

    // 클래스는 태생이 참조 형식이기 때문에
    // 클래스 객체를 다른 클래스 객체에 할당하면,
    // 둘은 같은 힙 메모리 주소를 갖게 되서,
    // 서로에게 영향을 끼치게 됌
    class Program
    {
        static void Main(string[] args)
        {
            MyClass source = new MyClass();
            source.A = 10;
            source.B = 20;

            MyClass target = source;
            target.B = 30;

            Console.WriteLine("{0} {1}", source.A, source.B);
            Console.WriteLine("{0} {1}", target.A, target.B);
        }
    }
}
