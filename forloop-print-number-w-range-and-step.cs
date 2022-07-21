using System;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            
            // (datatype name = value; name "i want it to run intil (value)"; name"will run in this increment" (++ means 1)
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }

            // Example 2
            for (int counter = 0; counter < 50; counter+= 5)
            {
                Console.WriteLine(counter);
            }

            Console.Read();
        }
    }
}
