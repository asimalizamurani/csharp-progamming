namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            string[] cars = { "Parado", "Honda", "Tesla", "Crolla"};

            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }



        }
    }
}