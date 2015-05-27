using System;
using System.IO;

namespace smunlisted
	{
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
		//Checks if a char is a lowercase letter.
		private static bool IsLower(int character)
			{
			if (character >= 'a' && character <= 'z')	// If the char is a lowercase letter from a to z.
				{ return true; }
			else
				{ return false; }
			}


		///////////////////////////////////////////////////////////////
		//Converts a lowercase letter to uppercase.
		private static int ToUpper(int character)
			{
			character = character + 'A' - 'a';
			return character;
			}

		///////////////////////////////////////////////////////////////
		// Function to capitalize letters of an input file to an output file.
		public static void Capitalize(string inputFile, string outputFile)
			{
			// Declaring this stuff here so it can go into the try-catch to test correctness, but 
			// still be seen outside the try-catch later in the function.
			FileInfo myFile;
			StreamReader sr;
			StreamWriter sw;

			// Kayyyyyy so http://stackoverflow.com/questions/14973642/how-using-try-catch-for-exception-handling-is-best-practice
			// I'll use his IO module I guess. 

			// Try the input file.
			try
				{
				myFile = new FileInfo(inputFile);		//Create a FileInfo instance representing an existing text file.
				sr = myFile.OpenText();			        //Instantiate a StreamReader to read from the text file.
				}
			catch(Exception ex)
				{
				throw new ApplicationException(string.Format("I cannot read the file {0}", inputFile), ex);
				}

			// Try the output file.
			try
				{
				sw = new StreamWriter(outputFile);		//Setup file to write too.
				}		
			catch (Exception ex)
				{ 
				throw new ApplicationException(string.Format("I cannot write to the file {0}", outputFile), ex); 
				}

			while (!sr.EndOfStream)							// Scrolling through file until end.
				{
				int charAsInt = sr.Read();					// Reads a single char.

				if (IsLower(charAsInt) == true)				// If the char is a lowercase letter from a to z.
						{ charAsInt = ToUpper(charAsInt); }

			// Try writing to the output file.
			try
				{
				sw.Write((Char)charAsInt);				// Write the character to the output file.
				}		
			catch (Exception ex)
				{ 
				throw new ApplicationException(string.Format("Failed to write to the character to file {0}", outputFile), ex); }
				}

			sr.Close();
			sw.Close();
			}
		///////////////////////////////////////////////////////////////
		}
	}
