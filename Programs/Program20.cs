using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program20
    {
        public static void Main()
        {
            int[] arr = new int[5];
            int i;

            Console.WriteLine("Enter the array elements:");
            for(i = 0;i<arr.Length; i++)
            {
                Console.WriteLine("element-{0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The elements of an array are:");
            for(i = 0;i< arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

             int max = arr[0];
            int min = arr[0];

            for(i = 0; i<arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }

                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Maximum element in an array is: {0}", max);
            Console.WriteLine("Minimum element in an array is: {0}", min);



        }
    }
}
