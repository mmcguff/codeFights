using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNotRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans = firstNotRepeatingCharacter("abacabad");
            Console.WriteLine(ans);
            Console.ReadKey();
        }

        static char firstNotRepeatingCharacter(String s)
        {
            int count;
            foreach(char i in s)
            {
               count = s.Count(f => f == i);
               if(count == 1)
               {
                   return i;
               }
            }
            return '_';
        }
    }
}
