using System;
using System.IO;

public class FileOps
	{
	///////////////////////////////////////////////////////////////
	public FileOps()
		{
		// Blank constructor
		}

	///////////////////////////////////////////////////////////////
	~FileOps()
		{
		// Might as well make a blank destructor too.
		}

	///////////////////////////////////////////////////////////////
	// A function to check if the file input exists. 
	public static bool FileWorks(string file)
		{
		// If that doesn't happen then I guess it will catch any other Exception.
		try										// I guess try will try to open the file. 
			{
			StreamReader sr = File.OpenText(file);
			sr.Close();
			}
		catch (Exception e)						// If that doesn't happen then I guess it will catch any other Exception.
			{
			Console.WriteLine("The {0} doesn't exist. Please create it or enter a correct path to it.", file);
			Console.WriteLine("An error occurred: '{0}'", e);
			return false;
			}
		
		return true;
		}

	///////////////////////////////////////////////////////////////
	//Checks if a char is a lowercase letter.
	static bool CheckIfLowercase(int character)
		{
		if (character >= 'a' && character <= 'z')	// If the char is a lowercase letter from a to z.
			{ return true; }
		else
			{ return false; }
		}


	///////////////////////////////////////////////////////////////
	//Converts a lowercase letter to uppercase.
	static int ToUpperCase(int character)
		{
		character = character + 'A' - 'a';
		return character;
		}

	///////////////////////////////////////////////////////////////
	// Function to capitalize letters of an input file to an output file.
	public static void CapitalizeToFile(string inputFile, string outputFile)
		{
		FileInfo myFile = new FileInfo(inputFile);		//Create a FileInfo instance representing an existing text file.
		StreamReader sr = myFile.OpenText();            //Instantiate a StreamReader to read from the text file.
		StreamWriter sw = new StreamWriter(outputFile); //Setup file to write too.

		while (!sr.EndOfStream)							// Scrolling through file until end.
			{
			int charAsInt = sr.Read();					// Reads a single char.

			if (CheckIfLowercase(charAsInt) == true)	// If the char is a lowercase letter from a to z.
					{ charAsInt = ToUpperCase(charAsInt); }

			sw.Write((Char)charAsInt);					// Write the character to the output file.
			}

		sr.Close();
		sw.Close();
		}
	///////////////////////////////////////////////////////////////
	}
