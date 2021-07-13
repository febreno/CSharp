using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn //name project
{
    class Program
    {

        static void Main(string[] args)
        {
            var phrase = "Hello world, I love the pogramming world".ToLower();
            Console.WriteLine(phrase);
            Console.WriteLine("write an word for you search:");
            var word = Console.ReadLine().ToLower();
            var result = ""; 

            if (phrase.Contains(word))
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }
                
            Console.WriteLine("Contain?" + result);
            Console.ReadLine();
        }

        //second form
        static void Main(string[] args)
        {
            var phrase = "Hello world, I love the pogramming world".ToLower();
            Console.WriteLine(phrase);
            Console.WriteLine("write an word for you search:");
            var word = Console.ReadLine().ToLower();
            var result = phrase.IndexOf(word, phrase.IndexOf(word) + 1); //search second element 

            Console.WriteLine("Location:" + result.ToString());
            Console.ReadLine();
        }
    }
}
