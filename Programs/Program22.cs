using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program22
    {
        public static void Main()
        {
            int[] arr = new int[4];
            int i;

            Console.WriteLine("Enter the elements:");
            for( i =0; i<arr.Length; i++)
            {
                Console.WriteLine("element-{0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("The elements of an array are:");
            for( i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("elements in ascending order:");
            Array.Sort(arr);
            foreach (int sort1 in arr)
            {
                Console.WriteLine(sort1);

            }

            Console.WriteLine("elements in descending order:");
            Array.Reverse(arr);
            foreach(int sort in arr)
            {
                Console.WriteLine(sort);
                
            }

            Console.WriteLine("second largest number is:");
            int secondlargest = arr[1];
            Console.WriteLine(secondlargest);
            
        }
    }
}
