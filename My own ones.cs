//My own: Gets a string as input from the user and prints to the console the word many times starting with the first letter and then adding one letter per time
//Continues with priting the same word each time with one less letter until it only has its' first one. 
//eg. "Egg"
//E
//Eg
//Egg
//Eg
//E
        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something");
            string input = Console.ReadLine();
            Console.Clear();
            for (int i = 1; i < input.Length; i++)
            {
                string newStr = input.Remove(input.Length - (input.Length-i));
                Console.WriteLine(newStr);
            }
            Console.WriteLine(input);
            for (int i = 0; i < input.Length; i++)
            {
                string newStr = input.Remove(input.Length - (i + 1));
                Console.WriteLine(newStr);
            }
        }
    }
    
}
    
