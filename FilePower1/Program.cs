using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] fileName)
        {
            Queue<string> wordsTyped = new Queue<string>();
            string userInput = null;
            string path = Path.Combine("FilePower1",fileName[0]);

            do
            {
                if (userInput != null)
                    wordsTyped.Enqueue(userInput);
                userInput = Console.ReadLine();
            }while (userInput != ""); 

            int size = wordsTyped.Count;
            string fileText = "";

            for (int i = 0; i < size; i++)
            {
                fileText += wordsTyped.Dequeue();
                if (i != size)
                    fileText += "\n";
            }
            File.WriteAllText(path,fileText);
        }
    }
}
