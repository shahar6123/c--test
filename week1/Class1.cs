using System;

namespace week1

public class Class1
{
	public Class1()
	{
        Console.Write("Enter a number (or 0 to stop) : ");
        if (int.TryParse(Console.ReadLine(), out numA))     //קליטת מספר מהמשתמש ובדיקה אם int או string
        {
            int sumA = 0;

            while (numA != 0)   //כל עוד שונה מ-0
            {
                sumA += numA;
                Console.Write("Enter a number (or 0 to stop) : ");
                if (!int.TryParse(Console.ReadLine(), out numA))     //קליטה בתוך הלולאה ובדיקה אם לא מספר
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    numA = 0;    //מסיים את הלולאה במקרה של קלט לא תקין
                }
            }
            Console.Write($"The sum of your numbers is: {sumA}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }



    }
}
