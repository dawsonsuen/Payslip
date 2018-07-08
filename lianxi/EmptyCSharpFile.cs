using System;
namespace PayslipApplication
{
    
    class PayslipCalculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input First Name: ");
            string f = Console.ReadLine();
            Console.WriteLine("Input Last Name: ");
            string l = Console.ReadLine();
            Console.WriteLine("Input Annual Salary: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Super Rate: ");
            string r = Console.ReadLine();
            Console.WriteLine("Input Payment Month: ");
            string d = Console.ReadLine();
            double gross = s / 12;
            double tax=0;
            if (s <= 18200)
            {
                tax = 0;
            }
            else if (s >= 18201 && s <= 37000)
            {
                tax = (s - 18200) * 0.19/12;
            }
            else if (s >= 37001 && s <= 87000)
            {
                tax = (3572 + (s - 37000) * 0.325)/12;
            }
            else if (s >= 87001 && s <= 180000)
            {
                tax = (19822 + (s - 87000) * 0.37)/12;
            }
            else if (s >= 180001)
            {
                tax = (54232 + (s - 180000) * 0.45)/12;
            }
            Console.WriteLine("Name: {0} {1}", f, l);
            Console.WriteLine("Payment period: Month of {0}", d);
            Console.WriteLine("Gross Income: {0}", Math.Round(gross));
            Console.WriteLine("Income Tax: {0}", Math.Round(tax));
            Console.WriteLine("Net Income: {0}", Math.Round(gross - tax));
            Console.WriteLine("Super: {0}", Math.Round(gross * Convert.ToDouble(r.Trim('%'))/100));

        }
    }
}