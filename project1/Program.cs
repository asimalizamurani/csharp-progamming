namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int sum;

            string fname, lname;

            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine($"The sum is : {sum}");

            Console.WriteLine("Enter your first name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lname = Console.ReadLine();

            Console.WriteLine($"Your Full Name is {fname} {lname}");

            Console.WriteLine($"Hey Mr/Miss {fname} How are you doing");
        }
    }
}
