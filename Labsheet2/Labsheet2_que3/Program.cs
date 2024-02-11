using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class TemperatureTracker
    {

        public double[] Temperature = new double[7];



        public void InputTemp()
        {
            for (int i = 0; i < Temperature.Length; i++)
            {
                Console.WriteLine($"Enter temperature for day {i + 1}: ");
                Temperature[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }

        public void DisplayTemp()
        {

        }

        static void Main(string[] args)
        {
            TemperatureTracker week1 = new TemperatureTracker();

            week1.InputTemp();

            for (int i = 0; i < 7; i++)
            {

                Console.WriteLine(week1.Temperature[i]);


            }
            Console.ReadLine();
        }
    }
}
