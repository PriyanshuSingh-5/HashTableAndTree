using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable");
           // MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            // Adding values in hashtable.
            //hash.Add("0", "To");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "To");
            //hash.Add("5", "be");
            // getting the specific value from hashtable.
            //string hash5 = hash.Get("5");
            //hash.Remove("0");
            //hash.Display();


           
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

            string input = "“paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Console.WriteLine("Input Statement is: ");
            Console.WriteLine(input);
            string[] inputArray = input.Split(" ");
            foreach (string word in inputArray)
            {
                if (hash.Get(word) == 0)
                {
                    hash.Add(word, 1);

                }
                else
                {
                    int value = hash.Get(word) + 1;
                    hash.Set(word, value);
                }
            }

            string[] newInputArray = inputArray.Distinct().ToArray();
            foreach (var word in newInputArray)
            {
                Console.WriteLine("The frequency of occurrence of \"" + word + "\" is: " + hash.Get(word));
            }
        }
    }
}



