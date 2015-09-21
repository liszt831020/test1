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
            string inputFileName1 = "data.txt";
            string outputFileName = "result.txt";
            string inputFileName2 = "template.txt";
            if (args.Length == 3)
            {
                inputFileName1 = args[0];
                inputFileName2 = args[1];
                outputFileName = args[2];
            }

            using (StreamReader inputFile1 = new StreamReader(inputFileName1))
            using (StreamReader inputFile2 = new StreamReader(inputFileName2))
            using(StreamWriter outputFile = new StreamWriter(outputFileName))
            {
                string line;
                while((line = inputFile1.ReadLine()) != null)
                {
                    string outputLine = "***" + line;
                    Console.WriteLine("Write line: " + outputLine);
                    outputFile.WriteLine(outputLine);
                } while ((line = inputFile2.ReadLine()) != null)
                {
                    string outputLine = "***" + line;
                    Console.WriteLine("Write line: " + outputLine);
                    outputFile.WriteLine(outputLine);
                }
            }
        }
    }
}
