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
            int[] test1 = { 2, 3, 3, 1, 5, 2 };
            int ans = firstDuplicate(test1);
            Console.WriteLine("The duplicate is " + ans + ".");

            Console.ReadKey();
        }

        static int firstDuplicate(int[] a)
        {
            Object obj = new Object();

            for (int i = 0; i < a.Length; i++ )
            {
                if(obj.Equals(a[i]))
                {
                    return a[i];
                }
                else
                {
                    obj = a[i]; 
                }
            }


                return -1;

        
        }
    }
}
