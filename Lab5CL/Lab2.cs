using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CL
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
            for (int i = 0; i < depth; i++)
            {
                sum = sum * 3 - 2;
            }
            return BigInteger.Abs(sum) + 2;
        }

        public string Run(string inputFile, string outputFile)
        {
            int depth = getDepthFromFile(inputFile);
            if (depth == -1) return "Error input information to the task!";

            BigInteger sum = GetSequenceSum(depth);

            Console.WriteLine("Sum: " + sum);
            File.WriteAllText(outputFile, sum.ToString());

            return sum.ToString();
        }
    }
}
