using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program18
    {
        public static void Main()
        {
            Console.Write("Enter the string : ");
            string message = Console.ReadLine();

            //Remove the empty spaces from the message
            message = message.Replace(" ", string.Empty);

            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[0] == message[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }

            Console.ReadKey();
        }
    }
}                                           

