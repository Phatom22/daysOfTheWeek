using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter day of a week");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {

                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                
            }
                 if(day == 5 || day ==6 || day == 7)
                    {
                        Console.WriteLine("it is a weekend");
                    }
                    else
                    {
                        Console.WriteLine("please enter a week day");
                    }

            Console.ReadLine();
           

        }
    }
}
