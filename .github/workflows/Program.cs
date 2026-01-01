using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___Boxing___UnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            {
                int rows = 5;

                for (int i = 1; i <= rows; i++)
                {
                    for (int space = 1; space <= rows - i; space++)
                        Console.Write(" ");

                    for (int star = 1; star <= (2 * i - 1); star++)
                        Console.Write("*");

                    Console.WriteLine();
                }
            }

            //2
            {
                int a = 10, b = 20;

                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine("After Swap:");
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
            }

            //3
            {
                int[] arr = { 10, 45, 2, 89, 34 };

                int min = arr[0];
                int max = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];
                    if (arr[i] > max)
                        max = arr[i];
                }

                Console.WriteLine("Minimum = " + min);
                Console.WriteLine("Maximum = " + max);
            }

            //4
            {
                int[] arr = { 1, 2, 3, 2, 4, 1, 5, 1 };
                int count = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            break;
                        }
                    }

                    //5
                    {
                        int[] arr1 = { 1, 3, 5, 7 };
                        int[] arr2 = { 2, 4, 6, 8 };

                        int[] merged = new int[arr1.Length + arr2.Length];

                        int i = 0, j = 0, k = 0;

                        while (i < arr1.Length && j < arr2.Length)
                        {
                            if (arr1[i] < arr2[j])
                                merged[k++] = arr1[i++];
                            else
                                merged[k++] = arr2[j++];
                        }

                        while (i < arr1.Length)
                            merged[k++] = arr1[i++];

                        while (j < arr2.Length)
                            merged[k++] = arr2[j++];

                        Console.WriteLine("Merged Array:");
                        foreach (int num in merged)
                            Console.Write(num + " ");
                    }



                }
            }
