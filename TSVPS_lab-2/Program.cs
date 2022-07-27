using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSVPS_lab_2
{
    internal class Program
    {
        static int Count = 10;
        static int[] Num = new int[10] { 49, 12, 27, 4, 19, 37, 26, 11, 25, 8 };

        static void bubbleSort(int[] data)
        {
            for (int i = 0; i < Count-1; i++)
            {
                for (int j = 0; j < Count-i-1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Набор чисел: ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(Num[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nbubbleSort сортировка: ");

            bubbleSort(Num);

            Console.Write("Отсортированный массив: ");
            for (int j = 0; j < Count; j++)
            {
                Console.Write(Num[j] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
