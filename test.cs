using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    //1
    class Person
    {
        public string Name;
        public void ShowName()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    class Student : Person
    {
        public int RollNo;
        //2
        class Sample
        {
            public Sample()
            {
                Console.WriteLine("Constructor Called");
            }

            ~Sample()
            {
                Console.WriteLine("Destructor Called");
            }
        }
        //3
        class Test
        {
            public int a = 10;
            private int b = 20;
        }
        //4

            public int a = 10;
            private int b = 20;
        }
        //5
        abstract class Shape
        {
            public abstract void Draw();
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Circle");
            }
        }
        //6
        class Animal
        {
            public virtual void Sound()
            {
                Console.WriteLine("Animal sound");
            }
        }

        class Dog : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Dog barks");
            }
        }
        //7
        using System.IO;

class Program
    {
        static void Main()
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello C#");
            sw.Close();

            fs = new FileStream("data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
    //8
    class Program
    {
        static void Main()
        {
            int num = 153, temp, sum = 0;
            temp = num;

            while (num > 0)
            {
                int r = num % 10;
                sum += r * r * r;
                num /= 10;
            }

            if (sum == temp)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong");
        }
    }
    //9
    class Program
    {
        static void Sort(int[] arr)
        {
            Array.Sort(arr);
        }

        static void Main()
        {
            int[] a = { 5, 2, 8, 1 };
            Sort(a);

            foreach (int i in a)
                Console.Write(i + " ");
        }
    }
    //10
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            if (marks >= 90)
                Console.WriteLine("Grade A");
            else if (marks >= 75)
                Console.WriteLine("Grade B");
            else if (marks >= 50)
                Console.WriteLine("Grade C");
            else
                Console.WriteLine("Fail");
        }
    }




