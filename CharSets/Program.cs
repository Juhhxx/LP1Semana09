using System;
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

        }
    }
}
