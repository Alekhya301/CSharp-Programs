using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program17
    {
        public static void Main()
        {
            int[] arr = new int[6];
            int i;
            int EvenSum = 0; int OddSum = 0;
            

            Console.WriteLine("Enter the elements of an array:");
            for(i = 0; i<arr.Length; i++)
            {
                Console.WriteLine("elements-{0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The elements of an array are:");
            for(i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    EvenSum += arr[i];
                   
                }
                else
                {
                    OddSum += arr[i];
                   
                }

               

            }
            Console.WriteLine("The sum of even numbers is:{0} ", EvenSum);
            Console.WriteLine("The sum of odd numbers is:{0} ", OddSum);

        }
    }
}
