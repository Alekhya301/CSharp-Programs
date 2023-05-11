using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program16
    {
        public static void Main()
        {
            int[] arr = new int[10];
            int Sum = 0; decimal avg = 0; int i;

            Console.WriteLine("Enter the array elements:");
            for(i =0; i<arr.Length; i++)
            {
                Console.WriteLine("elements-{0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The elemets of An Array are:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                
            }
             
            for(i = 0; i<arr.Length; i++)
            {
                Sum += arr[i];
                avg = Sum/ arr.Length;
            }
            Console.WriteLine("The average of array elements are: {0}", avg);


        }
    }
}
