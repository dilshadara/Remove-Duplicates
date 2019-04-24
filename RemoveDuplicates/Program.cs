using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicate();
        }

        static void RemoveDuplicate()
        {
            List<int> UnsortedList = new List<int> { 12, 11, 12, 21, 41, 43, 21 };

            for (var i = 0; i < UnsortedList.Count; i++)
            {
                for (var j = i + 1; j < UnsortedList.Count; j++)
                {
                    if (UnsortedList[i] == UnsortedList[j])
                    {
                        UnsortedList.RemoveAt(j);

                    }
                }

            }

            foreach (var val in UnsortedList)
            {
                Console.WriteLine(val);
            }
            Console.Read();
        }
    }
}
