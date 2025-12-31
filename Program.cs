using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Print the no series");
            for (int i=1;i<=10;i++)
            {
               Console.Write(i + " ");

            }
            Console.WriteLine("\n");
            //2

            Console.WriteLine("Print the Odd no series");
            for (int i=1;i<= 10; i+=2)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
            //3

            Console.WriteLine("Print the even no series");
            for (int i = 0; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //4

            Console.WriteLine("Print the no series");
            for (int i = 0; i <= 25; i += 5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //5


            Console.WriteLine("Print the no series");
            for (int i = 1; i <= 10; i++)
            {
                if (i<10)
                Console.Write(i + "+");
                else
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            //6

            Console.WriteLine("Print the Odd no series");
            for (int i = 0; i <= 10; i += 2)
            {
                if(i<10)
                Console.Write(i + "+");
                else 
                    Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            //7

            Console.WriteLine("Print the even no series");
            for (int i = 1; i <= 10; i += 2)
            {
                if (i < 9)
                    Console.Write(i + "+");
                else
                    Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            //8

            Console.WriteLine("Print the series");
            for (int i = 0; i <= 30; i += 5)
            {
                if (i < 30)
                    Console.Write(i + "+");
                else
                    Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            //9

            Console.WriteLine("Print the series");
            for (int i = 1; i <= 10; i ++)
            {
                if (i < 10)
                    Console.Write(i +"/"+ i +"!" +"+");
                else
                    Console.Write(i+"/"+i);
                 
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            //10

            Console.WriteLine("Print the even no series");
            for (int i = 0; i <= 10; i+=2)
            {
                if (i < 10)
                    Console.Write(i + "/" + i + "!" + "+" );
                else
                    Console.Write(i + "/" + i );
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            //11

            Console.WriteLine("Print the odd no series");
            for (int i = 1; i <= 9; i += 2)
            {
                if (i < 9)
                    Console.Write(i + "/" + i + "!" + "+");
                else
                     Console.Write(i + "/" + i );
            }
            Console.WriteLine();
            Console.WriteLine("\n");

            //12         
            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());
            int f = 1;   
            for (int i = 5; i <= 1; i--)   
            {
                f *= i;
            }
            Console.WriteLine($"Factorial of 5 = {f}");

            //13        
            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());
            int ctr = 0;
            for(int i=1;i<=n;i++)
            {
                if (n % i == 0) 
                    ctr++;  
            }
            if(ctr==2)
                Console.WriteLine($"The given no {n} is prime no");
            else
                Console.WriteLine($"The given no {n} is not prime no");

            //14
            Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int n = a; n <= b; n++)
            {
                int ctr = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        ctr++;
                }
                if (ctr == 2)
                    Console.WriteLine(n);
            }

            //15
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            int temp = n;
            int sum = 0;

            while (temp > 0)
            {
                int d = temp % 10;
                sum = sum + d * d * d;
                temp = temp / 10;
            }

            if (sum == n)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong Number");

            //16
            Console.WriteLine("Enter limit");
            int limit = int.Parse(Console.ReadLine());

            for (int n = 1; n <= limit; n++)
            {
                int temp = n;
                int sum = 0;

                while (temp > 0)
                {
                    int d = temp % 10;
                    sum = sum + d * d * d;
                    temp = temp / 10;
                }

                if (sum == n)
                    Console.WriteLine(n);
            }

            //17
            Console.WriteLine("Enter number of terms");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            //18
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x 5 = " + (i * 5));
            }
            //19
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            while (n > 0)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            Console.WriteLine("Sum of digits = " + sum);

            //20
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            int len = str.Length;
            int flag = 0;

            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i - 1])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");


        }

    }
}
