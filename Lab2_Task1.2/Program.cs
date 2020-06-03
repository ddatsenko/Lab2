using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab work #2, task 1.2");
            Console.WriteLine("");
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[,] arr = new int[n, m];
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
                Console.Write("The number of columns with no zeros: ");
                Console.Write(Columns(m, n, arr));
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
                Console.Write("The number of columns with no zeros: ");
                Console.Write(Columns(m, n, arr));
            }
            Console.ReadKey();
        }

        static int Columns(int m, int n, int[,] arr)
        {
            int columns = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i, j] == 0)
                    {
                        columns++;
                        break;
                    }
                }
            }
            columns = m - columns;
            return columns;
        }
    }
}
