using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{

    class Message
    {
        public void PrintMsg(string a)
        {
            Console.WriteLine(a);
        }

        public void PrintMsg(int a)
        {
            Console.WriteLine(a);
        }
        public void PrintMsg(int a, int b)
        {
            Console.WriteLine($"{a} {b}");
        }
        public void PrintMsg(string fname, string lname)
        {
            Console.WriteLine($"{fname}, {lname}");
        }
        public void PrintMsg(int num, string name)
        {
            Console.WriteLine($"{num} {name}");
        }
        public void PrintMsg(string name, int num)
        {
            Console.WriteLine($"{name}, {num}");
        }

        public void PrintAll ()
        {
            PrintMsg("Hello bro");
            PrintMsg(12);
            PrintMsg(5, 7);
            PrintMsg("Asim", "Ali");
            PrintMsg(30, "Asim");
            PrintMsg("Asim", 15);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Message msg = new Message();
            msg.PrintAll();

        }
    }
}
