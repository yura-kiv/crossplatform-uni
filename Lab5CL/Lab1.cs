﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab5CL
{
    public class Lab1
    {
        private bool IsValidInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You cannot enter an empty line into a program.");
                return false;
            }

            if (!Regex.IsMatch(input, "^[a-zA-Z0-9]+$"))
            {
                Console.WriteLine("One or both lines contain invalid characters.");
                return false;
            }

            return true;
        }

        private int CheckStrInStr(string str1, string str2)
        {
            int index = str1.IndexOf(str2);

            if (index == -1)
                return 0;

            str1 = str1.Substring(0, 1).ToUpper() + str1.Substring(1);
            str1 = str1.Remove(index, 1).Insert(index, str1[index].ToString().ToUpper());

            Console.Write(str1);

            return 1;
        }

        private int CalcStrInStr(string str1, string str2)
        {
            int str1Lenght = str1.Length;
            int str2Lenght = str2.Length;
            bool flag;

            for (int j = 1; j < str1Lenght; j++)
            {
                flag = true;
                for (int i = 0; (i < str1Lenght - j) && (i < str2Lenght); i++)
                {
                    if (str1[j + i] != str2[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    return j;
            }
            return str1Lenght;
        }

         private string GetResult(string str1, string str2, int index)
        {
            str1 = str1.Substring(0, 1).ToUpper() + str1.Substring(1);
            str2 = str2.Substring(0, 1).ToUpper() + str2.Substring(1);

            str1 = str1.Remove(index);

            Console.WriteLine("Result present sign: " + str1 + str2);
            return str1 + str2;
        }

        public string Run(string inputFile, string outputFile)
        {
            try
            {
                using (StreamReader reader = new StreamReader(inputFile))
                {
                    using (StreamWriter writer = new StreamWriter(outputFile))
                    {
                        string name1 = reader.ReadLine();
                        string name2 = reader.ReadLine();

                        if (!IsValidInput(name1) || !IsValidInput(name2))
                            return "Input information is not valid!";
                        
                        string name1Lower = name1.ToLower();
                        string name2Lower = name2.ToLower();

                        if (CheckStrInStr(name1Lower, name2Lower) == 1 || CheckStrInStr(name2Lower, name1Lower) == 1)
                            return "Some problem to read infaromation for the task!";

                        int index1 = CalcStrInStr(name1Lower, name2Lower);
                        int index2 = CalcStrInStr(name2Lower, name1Lower);

                        if (index1 < index2)
                        {
                            string result = GetResult(name1Lower, name2Lower, index1);
                            writer.Write(result);
                            return result;
                        }
                        else
                        {
                            string result = GetResult(name2Lower, name1Lower, index2);
                            writer.Write(result);
                            return result;
                        }
                    }
                }
            }
            catch
            {
                return "There was a problem reading the file...";
            }
        }
    }
}
