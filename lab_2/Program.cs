//
// VAR - 62, Kivlyuk Yuriy IPZ-41
//
using System.Collections.Generic;
using System.Numerics;

class Program
{
    const string INPUT_FILE = "../../../input.txt";
    const string OUTPUT_FILE = "../../../output.txt";

    static int getDepthFromFile()
    {
        int depth = -1;
        try
        {
            string inputText = File.ReadAllText(INPUT_FILE);
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

    static BigInteger GetSequenceSum(int start, int end, int depth, BigInteger sum)
    {
        if (depth == 0)
        {
            return sum + start;
        }
        sum = GetSequenceSum(start, start + end, depth - 1, sum);
        sum = GetSequenceSum(start + end, end, depth - 1, sum);

        return sum;
    }

    static void Main()
    {
        int depth = getDepthFromFile();
        if (depth == -1) return;
        Console.WriteLine("Depth: " + depth);

        BigInteger sum = GetSequenceSum(1, 1, depth, 0) + 1;

        Console.WriteLine("Sum: " + sum);
        File.WriteAllText(OUTPUT_FILE, sum.ToString());        
    }
}