namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Task One */
            /*int num;
            Console.WriteLine("Enter a number to print its table");
            num = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }*/


            /* Task Two */

            /*int tableOne;
            int tableTwo;
            Console.WriteLine("Enter First Table Number");
            tableOne = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Second Table Number");
            tableTwo = Convert.ToInt16(Console.ReadLine());

            for (int j = tableOne; j <= tableTwo; j++)
            {
                for (int k = 1; k <=10; k++)
                {
                    Console.WriteLine($"{j} * {k} = {j * k}");
                }
            }*/

            /*  Task Three  */

            String userName = "asim";
            String userPassword = "password";

            String username;
            String password;

            Console.WriteLine("Enter username");
            username = Console.ReadLine();

            Console.WriteLine("Enter password");
            password = Console.ReadLine();

            if(userName == username && password == userPassword)
            {
                Console.WriteLine($"Your username is {username}");
                Console.WriteLine($"Your password is {password}");
            }
            else if (userName != username && userPassword != password)
            {
                for (int i = 1; i <= 3; i++)
                {

                    Console.WriteLine("Enter username");
                    username = Console.ReadLine();

                    Console.WriteLine("Enter password");
                    password = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            



        }
    }
}
