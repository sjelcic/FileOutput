// Program to read the contents of a file character by character and capitalize all the letters.
// To use this program you must use the command line and provide the file name. 
// Build the program using the Developer Command Prompt and using that terminal you can run the .exe generated and enter the argument.
// More instructions here: https://msdn.microsoft.com/en-us/library/cb20e19t.aspx
using System;
using System.Text;
using System.IO;

class ProfDevi
	{
	// Function to read characters in a file, capitalize the 
	static void CapitalizeToFile(string path)
		{
		FileInfo myFile = new FileInfo(path);      //Create a FileInfo instance representing an existing text file.
		StreamReader sr = myFile.OpenText();                                  //Instantiate a StreamReader to read from the text file.
		StreamWriter sw = new StreamWriter("/work/FileOutput/output.txt"); //Setup file to write too.
	
		while (!sr.EndOfStream)												  // Scrolling through file until end.
			{
			int charAsInt = sr.Read();										  // Reads a single char.
		
			if (charAsInt >= 'a' && charAsInt <= 'z')			  // If the char is a lowercase letter from a to z.
				{ charAsInt = charAsInt + 'A' - 'a'; }
			
			sw.Write((Char)charAsInt);										  // Write the character to the output file.
			}

		sr.Close();
		sw.Close();
		}

	static void Main(string[] args)
		{
		if (args.Length == 0) // Did user provide an argument?
			{
			System.Console.WriteLine("Please enter a path like /work/fileoutput/input.txt");
			}
		else if (!File.Exists(args[0])) // Does that file actually exist?
			{ System.Console.WriteLine("That file doesn't exist. Make sure you include the suffix (.txt, etc.)."); }
		else
			{ CapitalizeToFile(args[0]); } // If there is an argument capitalize the letters.
		
		}
	}

///////////////////////////////////////////////
/// Notes:
/// Chars are unicode and are 16 bits wide. 
/// A stream reader/writer hides the details of an ASCII vs. Unicode file.
/// THere may be problems in the code with bite ordering.
/// 


/// Changes to make:
/// Make file get put in from the command line (args array) DONE
/// Don't name local variables with upper case. Upper case is for class names DONE
/// Don't cast the integer into char for int statement. Upcast to integer. DONE
/// Write code for cases where the file doesn't exist. DONE
/// Don't use "@". "Use / chars instead. To meet cross platform Dev, use /work/... Don't use c:." DONE
