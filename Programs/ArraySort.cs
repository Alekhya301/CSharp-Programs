using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class ArraySort
    {
        public static void Main()
        {
            int[] arr = new int[5];
            

            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine("elemnet-{0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Sorted array in ascending order:");
               Array.Sort(arr);
            foreach(int sort in arr)
            {
                Console.WriteLine(sort);
            }
          
            

            Console.WriteLine("Sorted array in descending order:");
            Array.Reverse(arr);
            foreach(int sort1 in arr)
            {
                Console.WriteLine(sort1);
            }
            
        }
    }
}
