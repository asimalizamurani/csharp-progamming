namespace conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string sign;
            int sum;
            Console.WriteLine("Enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the sign");
            sign = Console.ReadLine();

            Console.WriteLine("Enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());


            if(sign == "+")
            {
                sum = num1 + num2;
                
                Console.WriteLine($"The sum is : {sum}");
            }
            else if(sign == "-")
            {
                sum = num1 - num2;
                if (sum < 0)
                {
                    Console.WriteLine("Negative values not allowed");
                }
                else
                {
                    Console.WriteLine($"The substraction is : {sum}");
                }
            }
            else if(sign == "*")
            {
                sum = num1 * num2;
                Console.WriteLine($"The multiplication is : {sum}");
            }
            else if(sign == "/")
            {
                sum = num1 / num2;
                Console.WriteLine($"The division is : {sum}");
            }
            else if(sign == "%")
            {
                sum = num1 % num2;
                Console.WriteLine($"The reminder is : {sum}");
            }
            
            else
            {
                Console.WriteLine("Sorry bro");
            }
        }
    }
}
