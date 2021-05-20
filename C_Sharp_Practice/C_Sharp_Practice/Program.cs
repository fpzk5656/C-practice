using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Base
    {
        protected string Name;
        //결국 밑에 모든 함수들 포함해서 이 생성자에 매개변수로 받는 것을 할당 받은
        //this.Name을 뿌려줄뿐
        public Base(string Name)    
        {
            this.Name = Name;
            Console.WriteLine("{0}.Base()", this.Name);
        }

        ~Base()
        {
            Console.WriteLine("{0}.~Base()", this.Name);
        }

        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", this.Name);
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine("{0}.Derived()", this.Name);
        }

        ~Derived()
        {
            Console.WriteLine("{0}.~Derived()", this.Name);
        }

        public void DerivedMethod()
        {
            Console.WriteLine("{0}.DerivedMethod()", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
           
        }
    }
}
