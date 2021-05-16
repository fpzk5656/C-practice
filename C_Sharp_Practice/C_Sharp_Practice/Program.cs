using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    // this 사용

    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            // 객체 필드인 Name과 매개변수 Name의 구분이 가능해진다.
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine("{0} {1}", pooh.GetName(),
                pooh.GetPosition());

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine("{0} {1}", tigger.GetName(),
                tigger.GetPosition());
        }
    }
}
