using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace test
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for(int i = 1; i < exponent; i++)
                result = result * myInt;

                return result;
            
        }
    }
}

namespace C_Sharp_Practice
{
    //확장 메소드
    // 기존 클래스의 기능을 확장하는 기법
    // 첫번째 매개변수는 반드시 this키워드와 함께 확장코자 하는 클래스의 인스턴스
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}^2 : {1}", 3, 3.Square());

            Console.WriteLine("{0}^{1} : {2}", 3, 4, 3.Power(4));
            Console.WriteLine("{0}^{1} : {2}", 2, 10, 2.Power(10));
        }
    }
}
