using System;
using System.Collections.Generic;
using System.Linq;

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
        }
    }
}
