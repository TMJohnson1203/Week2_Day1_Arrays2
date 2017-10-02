using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1_Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] favNumbers = { 61, 22, 3, 44, 105, 36 };
            string[] studentNames = { "Raz", "Monica", "Rashida", "Teresa", "Brad", "Mia", "Murphy" };

            Console.WriteLine(favNumbers[0]);
            Console.WriteLine(studentNames[3]);

            string[] topVacaSpots = { "Italy", "Las Vegas", "New Orleans", "Paris", "New York City", "Tampa", "Chicago", "Taos", "San Diego", "London" };
            Console.WriteLine(topVacaSpots[0] + " " + topVacaSpots[9]);

            int[] childAge = { 5, 8, 12 };
            Console.WriteLine(childAge[0] + " " + childAge[1] + " " + childAge[2]);

            double[] studentsgpa = { 3.9d, 3.3d, 3.2d, 2.9d, 3.5d, 2.5d, 2.3d, 3.1d };
            Console.WriteLine(studentsgpa[0]);

            string[] firstLetter = { "R", "D", "J", "L" };
            Console.WriteLine(firstLetter[0] + " " + firstLetter[1] + " " + firstLetter[2] + " " + firstLetter[3]);







        }
    }
}
