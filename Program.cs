using System;

namespace SonarSweepSecondPart
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\j.gullung\source\repos\SonarSweepFirstPart\input.txt");
            int[] depths = Array.ConvertAll(lines, s => int.Parse(s));
            int previousThreeMeasurement = depths[0] + depths[1] + depths[2];
            int increases = 0;

            for (int i = 0; i < depths.Length - 2; i++)
            {
                int threeMeasurement = depths[i] + depths[i + 1] + depths[i + 2];

                if (previousThreeMeasurement < threeMeasurement)
                {
                    increases++;
                }
                previousThreeMeasurement = threeMeasurement;
            }
            Console.WriteLine(increases);
        }
    }
}
