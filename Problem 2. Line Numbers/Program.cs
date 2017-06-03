using System;
using System.IO;

namespace Problem_2.Line_Numbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("LineNumbers.txt");

            try
            {
                for (int i = 1; i <=10; i++)
                {
                    writer.WriteLine(i);
                }

            }
            finally
            {
                writer.Close();
                
            }

            StreamReader reader = new StreamReader("LineNumbers.txt");
            
            try
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine($"Line {lineNumber} : {line}");
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
