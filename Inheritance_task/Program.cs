using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_task
{

    class Values
    {
        public int num1 = 5, num2 = 3;
    }

    class Addition : Values
    {
      public int add()
        {
           return this.num1 + this.num2;
        }
    }

    class Substract : Values
    {
        public int subst()
        {
            return this.num1 - this.num2;
        }
    }

    class Multiply : Values
    {
        public int multi()
        {
            return this.num1 * this.num2;
        }
    }

    class Division : Values
    {
        public int div()
        {
            return this.num1 / this.num2;
        }
    }

    class Result : Division
    {
        public void printDetails()
        {
            Addition addt = new Addition();
            Substract sub = new Substract();
            Multiply mult = new Multiply();
            Division div = new Division();
            Console.WriteLine($"The addition is {addt.add()}");
            Console.WriteLine($"The substration is {sub.subst()}");
            Console.WriteLine($"The multi is {mult.multi()}");
            Console.WriteLine($"The division is {div.div()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Result rest = new Result();
            rest.printDetails();
        }
    }
}
