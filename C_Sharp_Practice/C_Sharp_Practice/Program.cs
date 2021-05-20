using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    // 생성자는 기반 클래스 -> 파생 클래스 순서지만,
    // 소멸자는 파생 클래스 -> 기반 클래스 순이다.

        //ef는 실험용으로 소멸자가 데이터를 소멸하기 전에 소멸자 안의 내용을 실행하나 궁금해서 실험함
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base()");
        }
        ~Base()
        {
            Console.WriteLine("~Base()");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived()");
            Console.WriteLine(ef);
        }
        int ef = 7;
        ~Derived()
        {
            Console.WriteLine(ef);
            Console.WriteLine("~Derived()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
        }
    }
}
