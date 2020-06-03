using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab work #2, task 3.2");
            Console.WriteLine("");

            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("");

            Console.Write("Enter the elements of the array pressing Enter after each one:\n", n);
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            int firstNegativeIndex = -1;

            int counter = 0;
            while (counter <= arr.Length - 1)
            {
                if (arr[counter] < 0)
                {
                    firstNegativeIndex = counter;
                    break;
                }
                counter++;
            }

            if (firstNegativeIndex != -1)
            {
                Console.WriteLine("Updated array:");
                Console.WriteLine("");
                int[] arrRemoved = new int[n - 1];
                int j = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != firstNegativeIndex)
                    {
                        arrRemoved[j] = arr[i];
                        Console.Write(arrRemoved[j] + " ");
                        j++;
                    }
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Updated array:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
