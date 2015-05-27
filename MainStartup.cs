// Program to read the contents of a file character by character and capitalize all the letters.
using System;
using System.IO;

class ProfDevi
	{
	static void Main(string[] args)
		{
		if (args.Length < 2) // Did user provide an argument?
			{ System.Console.WriteLine("Please enter both an input file and an output file."); }

		if (FileOps.FileWorks(args[0]) == true && FileOps.FileWorks(args[1]) == true) // If input and output file exist.
			{ FileOps.CapitalizeToFile(args[0], args[1]); } // Capitalize the letters. 
		}
	} 

///If the input file did not exist, look up exceptions and try catch blocks. DONE
///If file input and output has problems, you will throw exceptions. DONE
///Create a class in a seperate file called FileOps. Leave the constructor blank. DONE
///Move the code over into FileOps class as an object member. DONE
///Rename the function as bool ToUpperCase(string infile, string outfile). DONE 
///Place try catch blocks are io ops to catch mistakes. Your function will return true if successful. DONE
///If it fails it should return false. Cleanup the output file if your code fails. DONE
///You don't need to go to console to pass arguments. You can do it on the project properties debug option. DONE