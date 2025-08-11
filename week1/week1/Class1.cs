using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class Class1
    {


        //exercise 1
        public static void Name()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }



        //exercise 2
        //פרמטרים בתוכנית עצמה
        public static void EvenOrOdd1()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("The number: " + num + " is even");
            else
                Console.WriteLine("The number: " + num + " is odd");
        }
        //פרמטרים מתקבלים בקריאה לתוכנית מ-main
        public static void EvenOrOdd2(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("The number: " + num + " is even");
            else
                Console.WriteLine("The number: " + num + " is odd");
        }



        //exercise 3
        public static void TenToOne()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }



        //exersice 4
        //פרמטרים בתוכנית עצמה
        public static void GreatestNum1()
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                if (num1 > num3)
                    Console.WriteLine("The greatest number is: " + num1);
                else
                    Console.WriteLine("The greatest number is: " + num3);
            else
                Console.WriteLine("The greatest number is: " + num2);
        }
        //פרמטרים מתקבלים בקריאה לתוכנית מ-main
        public static void GreatestNum2(int num1, int num2, int num3)
        {
            if (num1 > num2)
                if (num1 > num3)
                    Console.WriteLine("The greatest number is: " + num1);
                else
                    Console.WriteLine("The greatest number is: " + num3);
            else
                Console.WriteLine("The greatest number is: " + num2);
        }



        //exersice 5
        //פרמטרים בתוכנית עצמה
        public static void Op1()
        {
            Console.Write("Enter your first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Choose operation: (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {number1 * number2}");
                    break;
                case "/":
                    if (number2 != 0)
                        Console.WriteLine($"Result: {number1 / number2}");
                    else
                        Console.WriteLine("Error- Division by zero");
                    break;
                default:
                    Console.WriteLine("Invaild operation");
                    break;
            }
        }
        //פרמטרים מתקבלים בקריאה לתוכנית מ-main
        public static void Op2(int number1, int number2, string op)
        {
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {number1 * number2}");
                    break;
                case "/":
                    if (number2 != 0)
                        Console.WriteLine($"Result: {number1 / number2}");
                    else
                        Console.WriteLine("Error- Division by zero");
                    break;
                default:
                    Console.WriteLine("Invaild operation");
                    break;
            }
        }



        //exercise 6
        public static void MaxValue()
        {
            int[] arr = new int[5];     //מערך בגודל 5 
            for (int i = 0; i < arr.Length; i++)    //קליטת הערכים למערך
            {
                Console.Write($"Enter number {i + 1} ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxV = arr[0];      //אתחול משתנה המקסימום לערך הראשון במערך
            for (int i = 1; i < arr.Length; i++)    //מציאת המספר הגדול ביותר
            {
                if (arr[i] > maxV)
                    maxV = arr[i];
            }
            Console.WriteLine($"The greatest number is: {maxV}");
        }



        //exercise 7
        public static void GradesAvg()
        {
            List<int> list = new List<int>();
            Console.Write("Enter your number of grades: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int avg = 0;
            for (int i = 0; i < y; i++)
            {
                Console.Write("Enter your grade: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
                avg += list[i];
            }
            Console.WriteLine($"The averge of the grades is: {avg} : {y} = {avg / y}");
        }



        //exercise 8
        public static void PositOrNeg(int number)
        {
            switch (number)     //בדיקה אם המספר שווה ל-0, שלילי או חיובי
            {
                case 0:
                    Console.WriteLine("The number is zero"); break;
                case > 0:
                    Console.WriteLine($"The number is positive {number}"); break;
                case < 0:
                    Console.WriteLine($"The number is negative {number}"); break;
            }
        }



        //exercise 9    //לוח הכפל עד 10 עם מספר שהמשתמש השים
        //option 1:
        public static void MultTable1()
        {
            Console.Write("Enter your number (multiplication table) : ");
            int mulNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{mulNum} * {i} = {mulNum * i}");
            }
        }
        //option 2:
        public static void MultTable2()
        {
            Console.Write("Enter your number (multiplication table) : ");
            string mulNum1 = Console.ReadLine();
            if (int.TryParse(mulNum1, out int num22))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num22} * {i} = {num22 * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }



        //exercise 10
        //public static void SumTilZero()
        //{
        //    Console.Write("Enter a number (or 0 to stop) : ");
        //    if (int.TryParse(Console.ReadLine(), out numA))     //קליטת מספר מהמשתמש ובדיקה אם int או string
        //    {
        //        int sumA = 0;

        //        while (numA != 0)   //כל עוד שונה מ-0
        //        {
        //            sumA += numA;
        //            Console.Write("Enter a number (or 0 to stop) : ");
        //            if (!int.TryParse(Console.ReadLine(), out numA))     //קליטה בתוך הלולאה ובדיקה אם לא מספר
        //            {
        //                Console.WriteLine("Invalid input! Please enter a valid number.");
        //                numA = 0;    //מסיים את הלולאה במקרה של קלט לא תקין
        //            }
        //        }
        //        Console.Write($"The sum of your numbers is: {sumA}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input! Please enter a valid number.");
        //    }
        //}



        //exercise 11
        public static void PrimeNum()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num <= 1)
                {
                    Console.WriteLine($"{num} is not a prime number");
                    return;
                }

                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine($"{num} is a prime number");
                else
                    Console.WriteLine($"{num} is not a prime number");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }



        //exercise 12
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }


        //exercise 13
        public static double Avg(int num1, int num2, int num3)
        {
            double avg = ((num1 + num2 + num3) / 3.0);
            return avg;
        }


        //exercise 14
        public static void PowerTable(int n)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{n} ^ {i} = {Math.Pow(n, i)}");
            }
        }







    }
}
