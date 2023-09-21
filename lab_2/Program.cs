//
// VAR - 62, Kivlyuk Yuriy IPZ-41
//
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

    static void GetSequence(int start, int end, int depth, List<int> sequence)
    {
        if (depth == 0)
        {
            sequence.Add(start);
            return;
        }
        GetSequence(start, start + end, depth - 1, sequence);
        GetSequence(start + end, start, depth - 1, sequence);
    }

    static void Main()
    {
        int depth = getDepthFromFile();
        if (depth == -1) return;
        Console.WriteLine("Depth: " + depth);

        List<int> sequence = new List<int>();
        GetSequence(1, 1, depth, sequence);

        int sequenceSum = sequence.Sum() + 1;
        Console.WriteLine("Sum: " + sequenceSum);
        File.WriteAllText(OUTPUT_FILE, sequenceSum.ToString());
    }
}