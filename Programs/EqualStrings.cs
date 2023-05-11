using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
   public  class EqualStrings
    {
        public static void Main()
        {
            string str1;
            int i, l;

            
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();

            l = str1.Length;
            string[] str2 = new string[l];

           
           
            for(i = str1.Length - 1; i >= 0; i--)
            {
                string tmp = str1[i].ToString();
                str2[i] = tmp;
                i--;
            }
            Console.Write("\nThe First string is : {0}\n", str1);
            Console.Write("The Second string is : {0}\n", string.Join("", str2));
            Console.Write("Number of characters copied : {0}\n\n", i);
        }
    }  
    }


