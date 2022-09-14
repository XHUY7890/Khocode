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
            int t = Convert.ToInt32(Console.ReadLine());
            int[] mang= new int[1002];
            int t1 = t;
            while (t > 0) 
            {
                mang[t] = Convert.ToInt32(Console.ReadLine());
                t--;
            }
            while (t1 > 0)
            {
                Console.WriteLine("{0}", sumdiv(mang[t1]));
                t1--;
            }
            Console.ReadLine();
           
        }
        static long sumdiv(int x)
        {
            long sum = 0;
            long i = 1;
            while (i <= Math.Round(Math.Sqrt(x)))
            {
                if((x%i==0) && (i!= Math.Sqrt(x)))
                {
                    sum = sum + i + x/i;
                    
                }
                if ((x % i == 0) && (i == Math.Sqrt(x))) sum = sum + i;
                i++;
            }
            return sum;
        }
       
    }
}