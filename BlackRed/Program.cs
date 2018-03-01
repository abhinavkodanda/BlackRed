using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 - Print numbers from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                String result = "";

                // Step 2 - Divisible by 3 print Black 
                if (i % 3 == 0)
                    result = "Black";

                // Step 3 - Divisible by 5 print Red
                if (i % 5 == 0)
                    result = result + "Red";

                // Step 4 - Divisible by 3 and 5 print BlackRed

                // Step 5 - Print the number as it is if not divisible by either 3 or 5
                if (result == "")
                    result = i.ToString();

                Console.WriteLine(result);

            }
            Console.ReadKey();
        }
    }
}
