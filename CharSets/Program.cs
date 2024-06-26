﻿using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] fileNames)
        {
            HashSet<char>[] filesContent = new HashSet<char>[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++)
            {
                filesContent[i] = new HashSet<char>();
            }

            for (int i = 0; i < fileNames.Length; i++)
            {
                string path = Path.Combine("CharSets",fileNames[i]);
                using StreamReader sr = new StreamReader(path);

                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Length == 1)
                    {
                        char charS = char.Parse(s);
                        filesContent[i].Add(charS);
                    }
                    else
                    {
                        Console.WriteLine("ERRO");
                        return;
                    }

                }
            }
            
            foreach (HashSet<char> hash in filesContent)
            {
                filesContent[0].IntersectWith(hash);
            }

            List<char> finalList = new List<char>();

            foreach (char c in filesContent[0])
            {
                finalList.Add(c);
            }

            finalList.Sort();

            foreach (char c in finalList)
            {
                Console.WriteLine(c);
            }
        }
    }
}
