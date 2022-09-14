using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demtu
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.Trim();
            if (s == "") Console.WriteLine(0);
            else
            {
                int i = 0;
                while (i < s.Length)
                {
                    if ((s[i] == ' ') && (s[i + 1] == ' '))
                    {
                        s = s.Remove(i, 1);
                        i--; ;
                    }
                    i++;
                }
                // Console.WriteLine("{0}", s);
                var s1 = s.Split(' ');
                int count = s1.Length;
                Console.WriteLine("{0}", count);
                Console.ReadLine();
            }
           
        }
    }
}