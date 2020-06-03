using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab work #2, task 2.2");
            Console.WriteLine("");

            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            int[,] arr = new int[n, m];
            int[] minMax = new int[4];

            Console.WriteLine("Enter 1 to fill the array manually or 2 to fill it with random numbers from 0 to 10:");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the elements of the array, pressing Enter after entering {0} elements in each row: ", m);
                Console.WriteLine("");
                for (int i = 0; i < n; i++)
                {
                    string s = Console.ReadLine();
                    Console.WriteLine("");
                    int j = 0;
                    foreach (int v in s.Split(' ').Select(v => Convert.ToInt32(v)))
                    {
                        arr[i, j++] = v;
                    }
                }
                MaxMinElement(m, n, minMax, arr);
                Swapping(minMax, arr);

                Console.WriteLine("");
                Console.WriteLine("The array with swapped max and min elements:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(string.Format("{0} ", arr[i, j]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
            }
            else if (choice == 2)
            {
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = r.Next(0, 10);
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("The created array:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(string.Format("{0} ", arr[i, j]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }

                MaxMinElement(m, n, minMax, arr);
                Swapping(minMax, arr);

                Console.WriteLine("");
                Console.WriteLine("The array with swapped max and min elements:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(string.Format("{0} ", arr[i, j]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
            }
            Console.ReadKey();
        }
        static int[] MaxMinElement(int n, int m, int[] minMax, int[,] arr)
        {
            int min = arr[0, 0];
            int max = arr[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        minMax[0] = i;
                        minMax[1] = j;
                    }

                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minMax[2] = i;
                        minMax[3] = j;
                    }
                }
            }
            return minMax;
        }
        static int[,] Swapping(int[] minMax, int[,] arr)
        {
            int temp;
            temp = arr[minMax[0], minMax[1]];
            arr[minMax[0], minMax[1]] = arr[minMax[2], minMax[3]];
            arr[minMax[2], minMax[3]] = temp;

            return arr;
        }
    }
}
