using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem_3.Word_Count
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, int>();
            string input = File.ReadAllText("../../words.txt");
            var words = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            String pattern = @"[a-zA-Z]+";
            Regex regex = new Regex(pattern);

            StreamReader reader = new StreamReader("../../text.txt");

            try
            {
                string santance = reader.ReadLine();

                while (santance != null)
                {
                    foreach (Match match in regex.Matches(santance))
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (match.Value.ToLower() == words[i] && !(dict.ContainsKey(words[i])))
                            {
                                dict.Add(words[i], 1);
                            }
                            else if (match.Value.ToLower() == words[i])
                            {
                                dict[words[i]]++;
                            }
                        }

                    }
                    santance = reader.ReadLine();
                }
            }
            finally
            {
                reader.Close();
            }

            StreamWriter writer = new StreamWriter(@"../../result.txt");
            try
            {
                foreach (var item in dict.OrderByDescending(key => key.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
