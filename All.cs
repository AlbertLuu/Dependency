using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class All
    {
        public All()
        {
        }

        public void find(string loc, string keyword) //finds files that have a specific keyward at that location
        {

                var application = Directory.EnumerateFiles(loc, "*", SearchOption.AllDirectories);
                foreach (string currentFile in application)
                {
                    try
                    {   // Open the text file using a stream reader
                        using (StreamReader sr = new StreamReader(currentFile))
                        {
                            // Read the stream to a string, and write the string to the console.
                            string line = sr.ReadToEnd();
                            if (line.Contains(keyword))
                            {
                                Console.WriteLine(currentFile);
                                Console.WriteLine("\n");

                            }
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read");
                        Console.WriteLine(e.Message);
                    }


                }
            }
        }
    
}
