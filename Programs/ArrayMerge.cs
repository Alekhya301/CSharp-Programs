using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class ArrayMerge
    {
        public static void Main()
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[4];

            Console.WriteLine("Enter the first array elements:");
            for (int i = 0; i < arr1.Length; i++)
            {

                Console.WriteLine("element-{0}:", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the second array elements:");
            for (int j = 0; j < arr2.Length; j++)
            {

                Console.WriteLine("element-{0}:", j);
                arr2[j] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = arr1.Concat(arr2).ToArray();
            Console.WriteLine("Merged array is:");
           foreach(int num in arr)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
