using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    // 얕은 복사 vs 깊은 복사

    class MyClass
    {
        public int MyField1;
        public int MyField2;

        // 여기서 클래스 반환 함수에
        // 일일이 자신의 멤버를 복사해넣는다.
        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //얕은 복사는 서로 같은 힙 메모리를 공유함
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine("{0} {1}", source.MyField1,source.MyField2);
                Console.WriteLine("{0} {1}", target.MyField1, target.MyField2);
            }

            //깊은 복사는 서로 다른 힙 메모리를 지님
            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine("{0} {1}", source.MyField1, source.MyField2);
                Console.WriteLine("{0} {1}", target.MyField1, target.MyField2);
            }
        }
    }
}
