using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print out welcome message
            Console.WriteLine("Welcome to Temperature Converter");
            //print out the prompt to ask for temperature input
            Console.WriteLine("Enter the temperature: ");
            //collect the user input for temperature
            float fahr = Convert.ToInt32(Console.ReadLine());

            //calculates celsius using conversion formula
            float cels = (fahr - 32) * 5/9;

            //print out message saying what the perimeter is
            Console.WriteLine($"{fahr}°F is equivalent to {cels}°F");

            //pause screen to read output
            Console.ReadLine();
        }
    }
}
