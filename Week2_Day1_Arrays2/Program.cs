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

            //int[] favNumbers = { 61, 22, 3, 44, 105, 36 };
            //string[] studentNames = { "Raz", "Monica", "Rashida", "Teresa", "Brad", "Mia", "Murphy" };

            //Console.WriteLine(favNumbers[0]);
            //Console.WriteLine(studentNames[3]);

            //string[] topVacaSpots = { "Italy", "Las Vegas", "New Orleans", "Paris", "New York City", "Tampa", "Chicago", "Taos", "San Diego", "London" };
            //Console.WriteLine(topVacaSpots[0] + " " + topVacaSpots[9]);

            //int[] childAge = { 5, 8, 12 };
            //Console.WriteLine(childAge[0] + " " + childAge[1] + " " + childAge[2]);

            //double[] studentsgpa = { 3.9d, 3.3d, 3.2d, 2.9d, 3.5d, 2.5d, 2.3d, 3.1d };
            //Console.WriteLine(studentsgpa[0]);

            //string[] firstLetter = { "R", "D", "J", "L" };
            //Console.WriteLine(firstLetter[0] + " " + firstLetter[1] + " " + firstLetter[2] + " " + firstLetter[3]);

            //int[] numbers = new int[4];

            //// creating an int array with 4 (four) blank values

            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number.");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number.");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[3]);

            // values 2 and 3 are USER entered

            //Declare and initialize a string array with the 7 days of the week as its elements.
            // Declare and initialize an array of 5 student ages using the “new” keyword

            string[] weekDays = new string[7];
            weekDays[0] = "Sunday";
            weekDays[1] = "Monday";
            weekDays[2] = "Tuesday";
            weekDays[3] = "Wednesday";
            weekDays[4] = "Thursday";
            weekDays[5] = "Friday";
            weekDays[6] = "Saturday";

            Console.WriteLine(weekDays.Length);


            //Console.WriteLine("Please enter a day of the week.");
            //weekDays[0] = "Sunday";
            //    (Console.ReadLine());
            //weekDays[1] = (Console.ReadLine());
            //weekDays[2] = (Console.ReadLine());
            //weekDays[3] = (Console)


            //   numbers[2] = int.Parse(Console.ReadLine());

            int[] studentAges = new int[4];
            studentAges[0] = 15;
            studentAges[1] = 17;
            studentAges[2] = 13;
            studentAges[3] = 11;

            //Declare and initialize an array of characters spelling out your last name. Print the length of the array.
            //Declare and initialize a string array. Using the Length property, print the second to last element in the array.

            //string[] numOfLetters = new string[7];
            //numOfLetters[0] = "J";
            //numOfLetters[1] = "O";
            //numOfLetters[2] = "H";
            //numOfLetters[3] = "N";
            //numOfLetters[4] = "S";
            //numOfLetters[5] = "O";
            //numOfLetters[6] = "N";

            //Console.WriteLine(numOfLetters[7].Length);

            char[] lastName = { 'J', 'O', 'H', 'N' };
            Console.WriteLine(lastName.Length);

            string[] exStringArray = { "This", "is", "an", "array", "of", "words", "that", "I", "have", "chosen" };

            //int index = exStringArray.Length;
            //index = index - 2;

            //Console.WriteLine(exStringArray[index]);

            ////or

            //int secondToLast = exStringArray.Length;
            //secondToLast = secondToLast - 2;

            //Console.WriteLine(exStringArray[secondToLast]);

            //Console.WriteLine("This is the last index " + (exStringArray.Length -1 ));


            Console.WriteLine(exStringArray[exStringArray.Length - 1]);

            // will give you the LAST element in the array. in this case, "chosen"











 










            














        }
    }
}
