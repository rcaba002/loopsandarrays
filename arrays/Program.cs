using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many items? ");
            int foo = Convert.ToInt32(Console.ReadLine());
            string[] bucket = new string[foo];

            for (int i = 0; i < bucket.Length; i++) 
            {
                bucket[i] = Console.ReadLine();
            }

            Console.WriteLine("================");

            foreach (string item in bucket)
            {
                Console.WriteLine("Values: {0}", item);
            }

            Console.ReadLine();
        }
    }
}
