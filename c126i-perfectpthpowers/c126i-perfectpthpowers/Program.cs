using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c126i_perfectpthpowers
{
    /*
     * Problem:
     * 
     * An integer X is a "perfect square power" if there is some integer Y such that Y^2 = X. 
     * An integer X is a "perfect cube power" if there is some integer Y such that Y^3 = X. 
     * We can extrapolate this where P is the power in question: an integer X is a "perfect p'th power" if there is some integer Y such that Y^P = X. 
     * Your goal is to find the highest value of P for a given X such that for some unknown integer Y, Y^P should equal X. 
     * You can expect the given input integer X to be within the range of an unsigned 32-bit integer (0 to 4,294,967,295).
     * 
     * Input Description:
     * 
     * You will be given a single integer on a single line of text through standard console input. 
     * This integer will range from 0 to 4,294,967,295 (the limits of a 32-bit unsigned integer).
     * 
     * Output Description:
     * 
     * You must print out to standard console the highest value P that fits the above problem description's requirements.
     * 
     * Sample input: 17
     * 
     * Sample output: 1 (17^1)
     */
    class Program
    {
        static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());
            Console.WriteLine(findP2(input).ToString());       
            Console.ReadKey();
        }

        // second attempt
        static uint findP2(uint x)
        {
            if (x > 0)
            {
                for (uint i = 32; i > 0; i--)
                {
                    if ((Math.Pow(x, (1.0 / i)) % 1) == 0)
                        return i;
                }
            }
            // if we get here, we did something wrong in our alg above
            return 0;
        }

        // naive first attempt
        static uint findP(uint x)
        {
            if (x == 0)
                return 0;
            for (uint i = 0; i < (x + 1); i++)
            {
                for (uint j = 0; j < 33; j++)
                {
                    if (Math.Pow(i, j) == x)
                    {
                        Console.Write("({0}^{1}) = ", i, j);
                        return j;
                    }
                }
            }
            return 0;
        }
    }
}
