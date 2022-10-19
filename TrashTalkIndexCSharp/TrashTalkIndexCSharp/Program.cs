using System;

namespace TrashTalkIndexCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Input Values (example from rough estimates of my Infiniti Q50)
            double zeroToSixtyTime_s = 3.5;
            double quarterMileTime_s = 12.5;

            //  Model Constants (from top fuel dragster Dragy time)
            double zeroToSixtyReferenceTime_s = 0.83;
            double quarterMileReferenceTime_s = 4.73;

            //  Calculate Values
            double spdIdx = SpeedIndex(zeroToSixtyTime_s, quarterMileTime_s, zeroToSixtyReferenceTime_s, quarterMileReferenceTime_s);
            double ttIdx = TrashTalkIndexValue(spdIdx);

            //  Print Values (yes it's ugly, I just needed something to work)
            Console.WriteLine("Your vehicle's speed index is: " + spdIdx);
            Console.WriteLine("This places your Trash Talk Index value at " + ttIdx + ".");
            Console.WriteLine("\nOpen this Desmos URL and set x to " + spdIdx + ": https://www.desmos.com/calculator/i9ceyfjakm");
        }

        static double SpeedIndex(double zeroToSixtyTime_s, double quarterMileTime_s, double zeroToSixtyReferenceTime_s, double quarterMileReferenceTime_s)
        {
            double zeroToSixtyVal = zeroToSixtyReferenceTime_s / zeroToSixtyTime_s;
            double quarterMileVal = quarterMileReferenceTime_s / quarterMileTime_s;

            return (zeroToSixtyVal / 2) + (quarterMileVal / 2);
        }

        static double TrashTalkIndexValue(double SpeedIndex)
        {
            //  -sqrt(1.66x) + 1.3x^7
            return (-1 * Math.Sqrt(1.66 * SpeedIndex) + Math.Pow((1.3 * SpeedIndex), 7)) + 1;
        }
    }
}
