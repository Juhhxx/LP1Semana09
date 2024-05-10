using System;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] fileName)
        {
            string userInput = null;
            string path = Path.Combine("FilePower2",fileName[0]);
            using StreamWriter sw = new StreamWriter(path);

            do
            {
                userInput = Console.ReadLine();
                if (userInput != "")
                    sw.WriteLine(userInput);
            } while (userInput != ""); 
        }
    }
}
