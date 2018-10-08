using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            Single milesTraveled=0;
            Single gallonsUsed=0;
            Single MPG = 0;

            //input

            Console.WriteLine("What is the amount in miles that you traveled?");
            milesTraveled = Single.Parse(Console.ReadLine());

            Console.WriteLine("What is the amount in gallons did you use for the trip?");
            gallonsUsed = Single.Parse(Console.ReadLine());

            //process
            MPG = milesTraveled / gallonsUsed;

            //output
            Console.WriteLine("Your miles per gallon (MPG) is " + MPG + " for the " + milesTraveled + " miles you traveled");
            Console.ReadLine();
        }
    }
}
