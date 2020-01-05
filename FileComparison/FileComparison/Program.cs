//Blaine Smith
//1-4-2020
//Bellevue University
//Assignment 9.3
//This program shows how to find the size of two files in bytes and displays this back to the user.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FileComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtFile = @"C:\Users\Ringo\Desktop\Docs\History.txt";
            string wordFile = @"C:\Users\Ringo\Desktop\Docs\History.docx";

            FileInfo fileInfo = new FileInfo(txtFile);
            long textSize = fileInfo.Length;

            FileInfo fileInfo1 = new FileInfo(wordFile);
            long wordSize = fileInfo1.Length;

            double ratioTxtToDoc = ((double)textSize / wordSize);
            int ratioDocToTxt = ((int)wordSize / (int)textSize);

            Display(textSize, wordSize, ratioDocToTxt, ratioTxtToDoc);
        }

        public static void Display(long textSize, long wordSize, int ratioDocToText, double ratioTxtToDoc)
        {
            Console.WriteLine("File Name: History.txt Size: {0}", textSize);
            Console.WriteLine("File Name: History.docx Size: {0}", wordSize);
            Console.WriteLine("Text to Word Ratio: {0}", ratioTxtToDoc);
            Console.WriteLine("Word to Text Ratio: {0}", ratioDocToText);
            Console.ReadLine();
        }
    }
}
