// Program to read the contents of a file character by character. 
// If the char is lowercase then we'll capitalize it.
using System;
using System.Text;
using System.IO;

class ProfDevi
	{
	static void Main(string[] args)
		{
		FileInfo MyFile = new FileInfo(@"c:\work\FileOutput\input.txt");      //Create a FileInfo instance representing an existing text file.
		StreamReader sr = MyFile.OpenText();                                  //Instantiate a StreamReader to read from the text file.
		StreamWriter sw = new StreamWriter(@"C:\work\FileOutput\output.txt"); //Setup file to write too.

		while (!sr.EndOfStream)												  // Scrolling through file until end.
			{
			int CharAsInt = sr.Read();										  // Reads a single char.

			if ((Char)CharAsInt >= 'a' && (Char)CharAsInt <= 'z')			  // If the char is a lowercase letter from a to z.
				{ CharAsInt = CharAsInt + 'A' - 'a'; }

			sw.Write((Char)CharAsInt);										  // Write the character to the output file.
			}
		
		sr.Close();
		sw.Close();
		}
	}
