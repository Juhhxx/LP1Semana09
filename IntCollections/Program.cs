using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listTest = new List<int>();
            Stack<int> stackTest = new Stack<int>();
            Queue<int> queueTest = new Queue<int>();
            HashSet<int> setTest = new HashSet<int>();

            int[] numberArray = new int[] {1, 10, -30, 10, -5};

            foreach (int n in numberArray)
            {
                listTest.Add(n);
                stackTest.Append(n);
                queueTest.Append(n);
                setTest.Add(n);
            }

            Console.WriteLine(PrintCollection("List",listTest));
        }
        private static string PrintCollection(string name, IEnumerable<int> collection)
        {
            string colString = $"{name}: ";
            int indexCounter = 0;

            foreach (int i in collection)
            {
                if (indexCounter < collection.Count()-1) 
                    colString += $"{i}, ";
                else 
                    colString += $"{i}";
                
                indexCounter++;
            }
            
            return colString;
        }
    }
}
