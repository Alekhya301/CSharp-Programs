using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class OddandEvenInArray
    {
        public static void Main()
        {
            int[] arr = new int[6];

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("element-{0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int number in arr)
            {
                if(number %2 == 0)
                {
                    Console.WriteLine("The number {0} is even", number);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd", number);
                }
            }
        }
    }
}
