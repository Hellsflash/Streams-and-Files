using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Copy_Binary_File
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string ImagePath = @"../../macree.jpg";
            string destinationPath = @"../../result.txt";

            using (var source = new FileStream(ImagePath, FileMode.Open))
            {
                using (var destination = new FileStream(destinationPath, FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length];

                    while (true)
                    {
                        int bytes = source.Read(buffer, 0, buffer.Length);
                        if (bytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, buffer.Length);
                    }
                }
            }

           
        }
    }
}
