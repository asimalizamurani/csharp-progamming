namespace oop
{

    class calculation
    {
        int num1;
        int num2;
        int sum;

        public void sumfnc()
        {
            Console.WriteLine("Enter the first number");
            this.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            this.num2 = Convert.ToInt32(Console.ReadLine());

            this.sum = this.num1 + this.num2;
            Console.WriteLine($"The sum is {this.sum}");
        }

        public void function2()
        {
            Console.WriteLine("This is class two");
        }

    }

    class Carshop
    {
        string firstName;
        string lastName;
        string[] cars = { "Tesla", "Crolla", "Civics", "Prado", "SkyLine", "Accord"};
        string car;

        public void chooseYourCar()
        {
            Console.WriteLine("Enter your first name");
            this.firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            this.lastName = Console.ReadLine();

            Console.WriteLine("Choose your car");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            this.car = Console.ReadLine();
        }

        public void getYourCar()
        {
            Console.WriteLine($"Hello Mr {this.firstName} {this.lastName}");
            Console.WriteLine($"Wow you have choosen {car} car");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Calass name, object, = new Class name()*/
            /*
             calculation asim = new calculation();
            asim.sumfnc();
             */

            Carshop carObjOne = new Carshop();
            carObjOne.chooseYourCar();
            carObjOne.getYourCar();


        }
    }
}
