using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDataAndDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName1 = "defaultInput.txt";
            string outputFileName2 = "defaultOutput.txt";
            string inputFileName = "defaultInput.txt";
            if (args.Length == 3)
            {
                inputFileName = args[0];
                outputFileName = args[1];
            }

            using (StreamReader inputFile = new StreamReader(inputFileName))
            using(StreamWriter outputFile = new StreamWriter(outputFileName))
            {
                string line;
                while((line = inputFile.ReadLine()) != null)
                {
                    string outputLine = "***" + line;
                    Console.WriteLine("Write line: " + outputLine);
                    outputFile.WriteLine(outputLine);
                }
            }
        }
    }
}
