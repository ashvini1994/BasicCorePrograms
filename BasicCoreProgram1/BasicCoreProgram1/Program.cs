using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    class FlipCoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin \n2.LeapYear \n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Leap leapyear = new Leap();
                    leapyear.LeapYear(Convert.ToInt32(Console.ReadLine()));
                    break;

            }

        }

        private class Leap
        {
        }
    }
}
