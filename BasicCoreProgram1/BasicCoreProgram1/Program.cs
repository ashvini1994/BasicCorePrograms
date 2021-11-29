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

            Console.WriteLine("Please choose anyone below\n1.FlipCoin \n2.LeapYear \n3.Power of Two " +
              "\n4.Harmonic Value\n5.Prime Factor\n6.Division\n7.Swap Numbers\n8.Even or Odd\n9.VowelOrConsonant\n ");
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
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.PowerofNumber(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    Harmonic harmonicNo = new Harmonic();
                    harmonicNo.HarmonicValue(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.PrimeFactors(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 6:
                    QuotientAndRemainder remainder = new QuotientAndRemainder();
                    remainder.Division(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    break;
                case 7:
                    SwapNumbers swap = new SwapNumbers();
                    swap.Swap(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    break;
                case 8:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.EvenOdd(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 9:
                    VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                    vowelOrConsonant.VowelConsonant(Convert.ToChar(Console.ReadLine()));
                    break;
            }
        }
    }
}
