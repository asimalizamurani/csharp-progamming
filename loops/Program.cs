namespace demoproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");
            // For Loop
            /*
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i);
            }
            */

            // While Loop
            /*
            int b = 1;
            while (b < 10)
            {
                Console.WriteLine(b);
                b++;
            }
            */

            /* Do While Loop */
            /* Console.WriteLine("Do While Loop");*/
            /*int c = 1;
            do
            {
                Console.WriteLine(c);

                c++;

            } while (c < 10);*/


            /* Multiplication Table */
            int n;

            Console.WriteLine("Enter a number to print its table");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }


        }
    }
}
