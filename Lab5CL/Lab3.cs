using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CL
{
    public class Lab3
    {
        static string Fold(string str, int pos)
        {
            string value = str + "_";
            bool flag = true, first = true;
            while (flag)
            {
                flag = false;
                int cnt = 1;
                for (int i = 1; i < value.Length; i++)
                {
                    if (value[i] == value[i - 1])
                    {
                        cnt++;
                    }
                    else
                    {
                        if (cnt > 2 && (!first || (i - cnt <= pos && pos < i)))
                        {
                            value = value.Substring(0, i - cnt) + value.Substring(i);
                            flag = true;
                            break;
                        }
                        cnt = 1;
                    }
                }
                first = false;
            }
            return value.Substring(0, value.Length - 1);
        }

        public void Run(string inputFile, string outputFile)
        {
            string[] inputLine = null;
            try
            {
                inputLine = File.ReadAllLines(inputFile);
            }
            catch
            {
                Console.WriteLine("Some error with reading the file");
                return;
            }
            string input = "_" + inputLine[0];

            List<string> rowVariants = new List<string> { input };
            Dictionary<string, (int, string, char, int)> rowVariantsData = new Dictionary<string, (int, string, char, int)>();
            rowVariantsData[input] = (0, input.Substring(1), '_', 0);

            Console.WriteLine("Initial: " + rowVariantsData[input] + "\n");

            int ind = 0;
            while (ind < rowVariants.Count)
            {
                string curVal = rowVariants[ind];
                ind++;
                for (int i = 1; i < curVal.Length; i++)
                {
                    if (curVal[i] != curVal[i - 1])
                    {
                        string nextVal = Fold(curVal.Substring(0, i + 1) + curVal.Substring(i), i);
                        if (!rowVariantsData.ContainsKey(nextVal))
                        {
                            rowVariantsData[nextVal] = (rowVariantsData[curVal].Item1 + 1, curVal, curVal[i], i - 1);
                            rowVariants.Add(nextVal);
                        }
                    }
                }
            }

            Console.WriteLine("\n*******************************************");
            foreach (var kvp in rowVariantsData)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.WriteLine("*******************************************\n");


            string current = "_";
            List<string> ans = new List<string>();
            while (rowVariantsData[current].Item1 > 0)
            {
                ans.Add(rowVariantsData[current].Item3.ToString() + rowVariantsData[current].Item4);
                current = rowVariantsData[current].Item2;
            }

            ans.Reverse();
            string result = rowVariantsData["_"].Item1 + " " + string.Join(" ", ans);
            Console.WriteLine("\nResult:");
            Console.WriteLine(result);
            File.Delete(outputFile);
            File.WriteAllText(outputFile, result);
        }
    }
}
