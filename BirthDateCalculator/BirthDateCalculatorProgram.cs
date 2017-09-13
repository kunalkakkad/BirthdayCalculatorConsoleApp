using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDateCalculator
{
    public static class BirthDateCalculatorProgram
    {
        public static void CalculateAge(int y, int m, int d)
        {
            try
            {
                DateTime date = Convert.ToDateTime(y + "-" + m + "-" + d);
                var bday = float.Parse(date.ToString("yyyy.MMdd"));
                var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
                float age = (now - bday);
                if (now <= bday || age >= 135)
                {
                    Console.WriteLine("Invalid Input of date");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Your Age is " + (age.ToString().Substring(0, age.ToString().LastIndexOf('.'))));
                    Console.ReadLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }

        }

        public static void Main(string[] args)
        {
            var day = "";
            var month = "";
            var year = "";
            int iDay, iMonth, iYear;
            Console.WriteLine("Hello Welcome to Birthday Calculator..!!");
            Console.WriteLine("Please Enter your Birth Day: ");
            day = Console.ReadLine();
            while (!int.TryParse(day, out iDay))
            {
                Console.WriteLine("Enter valid numeric day.");
                day = Console.ReadLine();
            }

            Console.WriteLine("Please Enter your Birth Month: ");
            month = Console.ReadLine();
            while (!int.TryParse(month, out iMonth))
            {
                Console.WriteLine("Enter valid numeric month.");
                month = Console.ReadLine();
            }

            Console.WriteLine("Please Enter your Birth Year: ");
            year = Console.ReadLine();
            while (!int.TryParse(year, out iYear))
            {
                Console.WriteLine("Enter valid numeric year.");
                year = Console.ReadLine();
            }
            CalculateAge(iYear, iMonth, iDay);
        }


    }
}
