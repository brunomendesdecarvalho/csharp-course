using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;

namespace ExDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> votes = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] candidate = sr.ReadLine().Split(',');
                        if (votes.ContainsKey(candidate[0]))
                        {
                            votes[candidate[0]] += int.Parse(candidate[1]);
                        }
                        else
                        {
                            votes[candidate[0]] = int.Parse(candidate[1]);
                        }
                    }

                    foreach (var vote in votes)
                    {
                        Console.WriteLine(vote.Key + ": " + vote.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
