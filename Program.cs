using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMoonSunRatio
{
    class Program
    {
        static void Main(string[] args)
        {
            string sunMass;
            string earthMass;
            string moonMass;

            Console.WriteLine("Please input the mass of the Sun");
            sunMass = Console.ReadLine();
            double sunMass1 = double.Parse(sunMass);

            Console.WriteLine("Please input the mass of the Earth");
            earthMass = Console.ReadLine();
            double earthMass1 = double.Parse(earthMass);

            Console.WriteLine("Please input the mass of the Moon");
            moonMass = Console.ReadLine();
            double moonMass1 = double.Parse(moonMass);
            double result1 = sunMass1 / earthMass1;

            Console.WriteLine("Sun is bigger than the Earth: {0} times", result1);
            double result2 = earthMass1 / moonMass1;
            double result3 = ( moonMass1 / earthMass1 ) * 100;

            Console.WriteLine("The Moon is smaller than the Earth: {0} times, so the Moon mass is {1}% of the Earth mass", result2, result3);
            double result4 = 1 / sunMass1;

            Console.WriteLine("The value of 1 / the mass of the Sun is " + result4);
            string ret = Console.ReadLine();
        }
    }
}
