using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime r;
            Console.Write("Enter Your Name: ");
            string s = Console.ReadLine();
            Console.Write("Enter Your Date Of Birth(mm/dd/yyyy hh:mm:ss): ");
            string dob = Console.ReadLine();
            r = DateTime.Parse(dob, System.Globalization.CultureInfo.InvariantCulture);
            DateTime today = DateTime.Now;
            Console.WriteLine("Your day of Birthday is : " + r.DayOfWeek);
            Console.WriteLine("Your date of Birthday in Indian Format: " + r.ToString("dd-MM-yyyy"));
            Console.WriteLine("No of days since your birthday: " + (DateTime.Now - r).Days);
            DateTime next = r.AddYears(today.Year - r.Year);
            if (next < today)
                next = next.AddYears(1);
            int numDays = (next - today).Days;
            Console.WriteLine("No of days to celebrate your next birthday : " + numDays);
            Console.ReadKey();
        }
    }
}
