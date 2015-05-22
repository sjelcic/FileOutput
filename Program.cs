using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
// Program to read the contents of a file, capitalize every letter, and output the contents to a file.
class ProfDevi
	{
		static void Main(string[] args)
			{
			StreamWriter sw = new StreamWriter(@"C:\work\FileOutput\output.txt");
			string text = System.IO.File.ReadAllText(@"C:\work\FileOutput\input.txt"); // Strings are immutable so we can't edit text.
			StringBuilder newText = new StringBuilder(text);
			for (int k = 0; k < text.Length; k++)
				{
				if (text[k] >= 'a' && text[k] <= 'z') // If the char is a letter from a to z, lowercase.
					{
					newText[k] = Char.ToUpper(text[k]);
					}
				}
			sw.WriteLine(newText);
			sw.Close();
			}
	}
