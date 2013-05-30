using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mcarthy91
{
    // McCarthy91 function defined as
    //
    // M(n) = {n - 10,          if n >  100
    //      = {M(M(n + 11)),    if n <= 100
    //
    /*  Input Description
     * 
     *  You will be given a single integer N on standard console input. This integer will range between 0 and 2,147,483,647 (without commas).
     *  
     *  Output Description
     *  
     *  You must output what the function does on each recursion: first you must print the function the expression that is being computed, 
     *  and then print which condition it took. Simply put, you must print each recursion event in the following string format: 
     *  "<Expression being executed> since <is greater than | is equal to or less than> 100". 
     *  Note that for the first line you do not need to print the "since" string (see example below). 
     *  You should also print the final expression, which is the result (which should always be 91).
     *  
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int i_input;
            Console.WriteLine("Enter integer input: ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out i_input) && i_input >= 0)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine("M(" + input + ")");
            int output = M(i_input);
            Console.WriteLine(output.ToString());
            Console.ReadKey();
        }

        static int M(int n)
        {
            if (n > 100)
            {
                Console.WriteLine("M({0}) since {1} is greater than 100.", n - 10, n);
                return n - 10;
            }
            Console.WriteLine("M(M({0})) since {1} is equal to or less than 100.", n - 10, n);
            return M(M(n + 11));
        }
    }
}
