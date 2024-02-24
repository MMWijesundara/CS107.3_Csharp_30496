using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(400);

            car1.Speed = 1;

            Console.WriteLine(car1.Speed);

            Console.ReadLine();


        }
    }

    internal class Car
    {
        private int speed;
        public Car(int _speed)
        {
            Speed= _speed;  
        }

        public int Speed
        {
            get { return speed; }   
            set { speed = value; }
        }

    }
}
