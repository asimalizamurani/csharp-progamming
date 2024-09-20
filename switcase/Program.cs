using System.Linq.Expressions;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch case statement");

            int num1, num2;
            string sign;
            int sum;

            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a sign [ +, -, *, / ]");
            sign = Console.ReadLine();

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch(sign)
            {
               case "+":
                    sum = num1 + num2;
                    Console.WriteLine($"The addition is : {sum}");
                    break;
                case "-":
                    sum = num1 - num2;
                    Console.WriteLine($"The substraction is : {sum}");
                    break;
                case "*":
                    sum = num1 * num2;
                    Console.WriteLine($"The multiplication is : {sum}");
                    break;
                case "/":
                    sum = num1 / num2;
                    Console.WriteLine($"The division is : {sum}");
                    break;
                default:
                    Console.WriteLine("Sorry Calculation failed");
                    break;

            }
            
        }
    }
}
