using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;
using Dependency;

class Program
{

    private static void Main(string[] args)
    {
        //Specification inputs

        Console.WriteLine("State types of files to search. If you need multiple, separate types with a space.\nIf you want all types, type ALL.\n \ncs, csproj, dtsx, rdl, data, sql, cs, aspx, ALL");
        string type = Console.ReadLine();
        var kArray = new List<string>(type.Split(' '));
        Console.WriteLine("\n");

        Console.WriteLine("Specify a keyword to search");
        string keyword = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("Specify location. example: C:\\Users\\Example\\Desktop");
        string location = Console.ReadLine();
        Console.WriteLine("\n");


        string loc = @location;


        All all = new All();
        Specific specific = new Specific();



        if (kArray[0] != "ALL" || kArray[0] != "all" || kArray[0] != "All") //if "all", then display everything in directory
            all.find(loc, keyword);
        else
            specific.find(loc, kArray, keyword);

        Console.WriteLine("Done");
        Console.ReadLine();


    }
}


/*   string sCA = @"C:\Users\aluu\Desktop\code\Scouting_Console_Apps";
     string sISP = @"C:\Users\aluu\Desktop\code\Scouting_Integration_Services_Packages";
     string sRS = @"C:\Users\aluu\Desktop\code\Scouting_Reporting_Services";
     string sS = @"C:\Users\aluu\Desktop\code\Scouting_SQL";
     string sT = @"C:\Users\aluu\Desktop\code\TOSS";

     //string archiveDirectory = @"C:\archive";

     try
     {
         var consoleApps = Directory.EnumerateFiles(sCA, "*.cs", SearchOption.AllDirectories);
         var consoleApps2 = Directory.EnumerateFiles(sCA, "*.csproj", SearchOption.AllDirectories);
         var storedProc = Directory.EnumerateFiles(sISP, "*.dtsx", SearchOption.AllDirectories);
         var reportingServ = Directory.EnumerateFiles(sRS, "*.rdl", SearchOption.AllDirectories); //.data
         var reportingServ2 = Directory.EnumerateFiles(sRS, "*.data", SearchOption.AllDirectories);
         var sql = Directory.EnumerateFiles(sS, "*.sql", SearchOption.AllDirectories);
         var toss = Directory.EnumerateFiles(sT, "*.cs", SearchOption.AllDirectories);
         var toss2 = Directory.EnumerateFiles(sT, "*.aspx", SearchOption.AllDirectories);

         foreach (string currentFile in consoleApps)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                     // Read the stream to a string, and write the string to the console.
                     String line = sr.ReadToEnd();
                     if (line.Contains(keyword))
                     {
                         Console.WriteLine(currentFile);
                         Console.WriteLine("\n");

                     }
                 }
             }

             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }


         }

         foreach (string currentFile in consoleApps2)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                     // Read the stream to a string, and write the string to the console.
                     String line = sr.ReadToEnd();
                     if (line.Contains(keyword))
                     {
                         Console.WriteLine(currentFile);
                         Console.WriteLine("\n");

                     }
                 }
             }

             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }


         }
         /*foreach (string currentFile in storedProc)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                     // Read the stream to a string, and write the string to the console.
                     String line = sr.ReadToEnd();
                     if (line.Contains(keyword))
                     {
                         Console.WriteLine(currentFile);
                         Console.WriteLine("\n");
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }


         }
         foreach (string currentFile in reportingServ)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                     // Read the stream to a string, and write the string to the console.
                     String line = sr.ReadToEnd();
                     if (line.Contains(keyword))
                     {
                         Console.WriteLine(currentFile);
                         Console.WriteLine("\n");
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }


         }

         foreach (string currentFile in reportingServ2)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                     // Read the stream to a string, and write the string to the console.
                     String line = sr.ReadToEnd();
                     if (line.Contains(keyword))
                     {
                         Console.WriteLine(currentFile);
                         Console.WriteLine("\n");
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }


         }
         foreach (string currentFile in sql)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    if (line.Contains(keyword))
                    {
                        Console.WriteLine(currentFile);
                        Console.WriteLine("\n");
                    }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }


         }
         foreach (string currentFile in toss)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                     // Does a text search and outputs in what files that string is found
                     String line = sr.ReadToEnd();
                     if (line.Contains(keyword))
                     {
                         Console.WriteLine(currentFile);
                         Console.WriteLine("\n");
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }

         }

         foreach (string currentFile in toss2)
         {
             //Console.WriteLine(currentFile.Substring(sT.Length + 1));
             try
             {   // Open the text file using a stream reader
                 using (StreamReader sr = new StreamReader(currentFile))
                 {
                     // Does a text search and outputs in what files that string is found
                     String line = sr.ReadToEnd();
                     if (line.Contains(keyword))
                     {
                         Console.WriteLine(currentFile);
                         Console.WriteLine("\n");
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }

         }
     }


     catch (Exception e)
     {
         Console.WriteLine(e.Message);
     }
     Console.ReadLine();
 }

}*/