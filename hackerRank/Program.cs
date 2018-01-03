using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerRank
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int[] test1 = {2, 3, 3, 1, 5, 2};
            int[] test2 = {2, 4, 3, 5, 1};
            int[] test3 = {8, 4, 6, 2, 6, 4, 7, 9, 5, 8};
            int ans1 = firstDuplicate(test1);
            int ans2 = firstDuplicate(test2);
            int ans3 = firstDuplicate(test3);
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
            Console.WriteLine(ans3);

            Console.ReadKey();
        }

        static int firstDuplicate(int[] a)
        {

            Dictionary<int, int> x = new Dictionary<int, int>();
            foreach (int i in a)
            {
                if (x.ContainsKey(i))
                    return i;
                else
                    x.Add(i, i);
            }
            return -1;
        }
    }
}
