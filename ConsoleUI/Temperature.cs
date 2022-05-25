using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Temperature : ITemperature
    {
        internal List<int> temperatures;
        internal Dictionary<int, string> wordToIntegers;

        int min;
        int max;
        double average;


        public Temperature()
        {
            temperatures = new List<int>();

            wordToIntegers = new Dictionary<int, string>
            {
                {1, "ONE" },
                {2, "TWO" },
                {3, "THREE" },
                {4, "FOUR" },
                {5, "FIVE" },
                {6, "SIX" },
                {7, "SEVEN" },
                {8, "EIGHT" },
                {9, "NINE" },
                {10, "TEN" }
            };


        }

        public void Insert(string temperature)
        {
            temperature = temperature.ToUpper();

            foreach (var item in wordToIntegers)
            {
                if (temperature == item.Value)
                {
                    temperatures.Add(item.Key);
                }
            }

            RunCalculations();
        }


        public void Insert(int temperature)
        {
            temperatures.Add(temperature);

            RunCalculations();
        }

        public void RunCalculations()
        {
            CalculateMin();
            CalculateMax();
            CalculateAverage();
        }

        public void PrintAllTemperatures()
        {
            foreach (var item in temperatures)
            {
                Console.WriteLine(item);
            }
        }

        private void CalculateMin()
        {
            min = temperatures.Min();
        }

        private void CalculateMax()
        {
            max = temperatures.Max();
        }

        private void CalculateAverage()
        {
            average = temperatures.Average();
        }

        public void DisplayCalculations()
        {
            Console.WriteLine($"Minimum Temperature: {min}");
            Console.WriteLine($"Maximum Temperature: {max}");
            Console.WriteLine($"Average Temperature: {average}");
        }
    }
}
