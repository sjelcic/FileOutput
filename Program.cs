// Program to read the contents of a file character by character. 
// If the char is lowercase then we'll capitalize it.
using System;
using System.Text;
using System.IO;

class ProfDevi
	{
	static void Main(string[] args)
		{
		FileInfo MyFile = new FileInfo(@"c:\work\FileOutput\input.txt"); //Create a FileInfo instance representing an existing text file.
		StreamReader sr = MyFile.OpenText(); //Instantiate a StreamReader to read from the text file.
		StreamWriter sw = new StreamWriter(@"C:\work\FileOutput\output.txt"); // Write to a file.

		while (!sr.EndOfStream) // Scrolling through file until end.
			{
			int Temp = sr.Read(); // Reads a single char.


			Char WriteToFile = (Char)Temp; // Convert the int to a char.

			//if (WriteToFile >= 'a' && WriteToFile <= 'z') // If the char is a lowercase letter from a to z.
				//{ WriteToFile = WriteToFile + 'A' - 'a'; }

			sw.Write(WriteToFile);
			}
		
		sr.Close();
		sw.Close();
		}
	}
