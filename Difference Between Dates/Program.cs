using System;

namespace Date_Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dateOne = FetchDate();//retrieve first date
            DateTime dateTwo = FetchDate();//retriece second date
            TimeSpan difference = dateTwo.Subtract(dateOne);//calculate difference
            double days = difference.Days;//convert to number

            //write answer
            Console.WriteLine();
            Console.WriteLine("The difference between the date {0} and {1} is equivalent to:", dateOne.ToShortDateString(), dateTwo.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("{0} years.", Math.Round(days/365, 2));
            Console.WriteLine("{0} months.", Math.Round(days/30, 2));
            Console.WriteLine("{0} days.", Math.Round(days, 2));
           
            Console.ReadKey();
        }
        //Retreive and validate input
        private static DateTime FetchDate()
        {
            string inputOne;
            DateTime dateValue = new DateTime();

            Console.WriteLine("Please enter a date to compare in the format MM/DD/YYYY");
            inputOne = (Console.ReadLine());

            while (!DateTime.TryParse(inputOne, out dateValue))
            {
                Console.WriteLine("Input format was invalid.  Please enter a date in the format MM/DD/YYYY");
                inputOne = Console.ReadLine();
            }
            return dateValue;
        }
    }
}
