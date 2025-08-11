namespace week1

{
    using System;
    using week1;
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 myClass = new Class1();

            //קריאה לתוכניות מהמחלקה
            Class1.Name();
            Class1.EvenOrOdd1();
            Class1.EvenOrOdd2(7);   //חייב לקבל ערך אפשר גם לשים בתוכנית כפרמטר שהמשתמש השים לו ערך
            Class1.TenToOne();
            Class1.GreatestNum1();
            Class1.GreatestNum2(19, 59, 2);
            Class1.Op1();
            Class1.Op2(3, 5, "+");
            Class1.MaxValue();
            Class1.GradesAvg();
            Class1.PositOrNeg((-44));
            Class1.MultTable1();
            Class1.MultTable2();
            //Class1.SumTilZero();
            Class1.PrimeNum();
            Class1.PowerTable(2);






            //exercise 12
            Console.WriteLine("Enter your number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (Class1.IsEven(num) is true)
                {
                    Console.WriteLine($"The number {num} is even!");
                }
                else
                {
                    Console.WriteLine($"The number {num} is odd!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }


            //exercise 13
            Console.WriteLine("Enter number 1: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Enter number 2: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Enter number 3: ");
                    if (int.TryParse(Console.ReadLine(), out int num3))
                    {
                        Console.WriteLine($"The avarge of your numbers is: {Class1.Avg(num1, num2, num3)} ");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }



























        }
    }
}
