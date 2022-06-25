using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace punktuacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputpath = "D:\\SolutionsForSpaceApp\\2045\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2045\\output.txt";

            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();
            string line;
            using (StreamReader reader = new StreamReader(inputpath))
            {
                line = reader.ReadLine();
            }

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    while (i < line.Length && line[i] == ' ')
                    {
                        i++;
                    }
                    if (line[i] == ',' || line[i] == '.' || line[i] == '!' || line[i] == '?')
                    {
                        if (i + 1 < line.Length && line[i + 1] == ' ') Console.Write(line[i]);
                        else Console.Write(line[i] + " ");
                    }
                    else Console.Write(" " + line[i]);
                }
                else if (line[i] != ',' && line[i] != '.' && line[i] != '!' && line[i] != '?')
                {
                    Console.Write(line[i]);
                }
                else
                if (i + 1 < line.Length && line[i + 1] == ' ') Console.Write(line[i]);
                else Console.Write(line[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
