using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            // Adding values in hashtable.
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");
            // getting the specific value from hashtable.
            //string hash5 = hash.Get("5");
            hash.Remove("0");
            hash.Display();
        }
    }
}


