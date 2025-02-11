/* reads a file of words and then prints them sorted*/
using System.Reflection.Metadata.Ecma335;
using static System.Console;
namespace FunWithWordFile20250205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter path to file: ");
            string path = ReadLine();
            string line;
            List<string> words = new List<string>();
            string[] parts;
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine().Trim();
                            if (line.Length == 0)
                            {
                                continue;
                            }
                            parts = line.Split(" ");
                            foreach (string part in parts)
                            {
                                words.Add(part);
                            }
                        }
                    }
                    words.Sort();
                    foreach (string word in words)
                    {
                        WriteLine(word);
                    }
                }
            } catch (Exception ex)
            {
                WriteLine("Failed to read the file.");
            }
        }
    }
}
