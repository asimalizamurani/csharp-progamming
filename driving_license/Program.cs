namespace driving_license
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int value;
            Console.WriteLine("Welcome to Driving License");
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} your age is {age} ");

            if(age > 18)
            {
                Console.WriteLine("Please select 1 for car and 0 for bike");
                value = Convert.ToInt16(Console.ReadLine());

                if(value == 1)
                {
                    Console.WriteLine("Your car appointment is confirmed");
                }
                else if(value == 0)
                {
                    Console.WriteLine("Your bike appointment is confirmed");
                }
            }

            else if (age == 18)
            {
                Console.WriteLine("You need to wait for 1 year");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are not eligible");
            }
            else
            {
                Console.WriteLine("Its time to drink milk not for riding and driving");
            }
        }
    }
}
