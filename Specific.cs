﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Specific
    {
        public Specific()
        {
        }

        public void find(String loc, List<String> kArray, String keyword) //find files at a location with an array of different extensions and a keyword
        {
            foreach (string t in kArray)
            {

                var application = Directory.EnumerateFiles(loc, "*." + kArray, SearchOption.AllDirectories);
                foreach (string currentFile in application)
                {
                    try
                    {   // Open the text file using a stream reader
                        using (StreamReader sr = new StreamReader(currentFile))
                        {
                            // Read the stream to a string, and write the string to the console.
                            String line = sr.ReadToEnd();
                            if (line.Contains(keyword))

                                Console.WriteLine(currentFile);
                            Console.WriteLine("\n");

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
}
