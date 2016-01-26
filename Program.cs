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

        Console.WriteLine("Finished when it says Done\n");


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