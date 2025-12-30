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

            Console.WriteLine("Print the no series");
            for (int i=1;i<=10;i++)
            {
               Console.Write(i + " ");

            }
            Console.WriteLine("\n");

            Console.WriteLine("Print the Odd no series");
            for (int i=1;i<= 10; i+=2)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Print the even no series");
            for (int i = 0; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Print the no series");
            for (int i = 0; i <= 25; i += 5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");


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








        }

    }
}
