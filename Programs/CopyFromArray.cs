using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class CopyFromArray
    {
        public static void Main()
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            int i;

            for( i = 0; i<arr1.Length; i++)
            {
                Console.WriteLine("element-{0}", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the elements of array1 are:");
            for (i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine( arr1[i]);

            }

            for ( i = 0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("the elements of array2 are:");
            for (i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine( arr2[i]);
                
            }
        }
    }
}
