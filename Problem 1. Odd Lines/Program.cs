using System;
using System.IO;

namespace Problem_1.Odd_Lines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../OddLines.txt");

            try
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 !=0)
                    {
                        Console.WriteLine($"{line}");
                    }
                    
                    line = reader.ReadLine();

                }

            }
            finally
            {
                reader.Close();

            }

        }
    }
}
