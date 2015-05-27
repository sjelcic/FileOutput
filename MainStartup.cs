// Program to read the contents of a file character by character and capitalize all the letters.
using System;
using System.IO;

class ProfDevi
	{
	static void Main(string[] args)
		{
		if (args.Length < 2) // Did user provide an argument?
			{ System.Console.WriteLine("Please enter both an input file and an output file."); }
		else
			{ smunlisted.FileOps.Capitalize(args[0], args[1]); } // Capitalize the letters. 
		}
	} 
