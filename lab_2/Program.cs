//
// VAR - 62, Kivlyuk Yuriy IPZ-41
//
using System.Collections.Generic;
using System.Numerics;

/*
!!! Пояснення !!!

1 a b c d 1

1 (1+a) a (a+b) b (b+c) c (c+d) d (d+1) 1
----|------------(S-2)--------------|----

a b c - входить до суми в 3 екземплярах кожного разу
1 (по сторонам) - входять в суму кожного разу по два рази

S - загальна сума буковок
S-2 - сума без одиничок

(S-2) * 3 + 4 -> S*3 - 2 <- Solution...

*/

namespace lab_2
{
    public class Lab2
    {
        static int getDepthFromFile(string inputFile)
        {
            int depth = -1;
            try
            {
                string inputText = File.ReadAllText(inputFile);
                if (int.TryParse(inputText, out depth) && depth >= 0 && depth <= 100)
                {
                    return depth;
                }
                else
                {
                    Console.WriteLine("Invalid value in file. Only integer values between 0 and 100 are valid.");
                    return -1;
                }
            }
            catch
            {
                Console.WriteLine("There was a problem reading the file..");
                return -1;
            }
        }

        static BigInteger GetSequenceSum(int depth)
        {
            if (depth <= 0) return 0;
            BigInteger sum = BigInteger.Zero;
            for(int i = 0; i < depth; i++)
            {
                sum = sum * 3 - 2;
            }
            return BigInteger.Abs(sum) + 2;
        }

        public void Run(string inputFile, string outputFile)
        {
            int depth = getDepthFromFile(inputFile);
            if (depth == -1) return;
            Console.WriteLine("Depth: " + depth);

            BigInteger sum = GetSequenceSum(depth);

            Console.WriteLine("Sum: " + sum);
            File.WriteAllText(outputFile, sum.ToString());        
        }
    }

    public class Program
    {
        static void Main()
        {
            const string def_inputFile = "../../../input.txt";
            const string def_outputFile = "../../../output.txt";
            Lab2 lab2 = new Lab2();
            lab2.Run(def_inputFile, def_outputFile);
        }
    }
}
