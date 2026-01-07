using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_Specifiers_1
{
    using System;

    namespace OOPS_Demo
    {
        // 1
        static class StaticDemo
        {
            public static void Show()
            {
                Console.WriteLine("Static Class Method");
            }
        }

        // 2. 
        sealed class SealedDemo
        {
            public void Display()
            {
                Console.WriteLine("Sealed Class Method");
            }
        }

        // 3.
        abstract class AbstractDemo
        {
            public abstract void Draw();

            public void Info()
            {
                Console.WriteLine("Abstract Class Normal Method");
            }
        }

        class Circle : AbstractDemo
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Circle");
            }
        }

        // 4.
        class Parent
        {
            public virtual void Show()
            {
                Console.WriteLine("Parent Class Show Method");
            }
        }

        class Child : Parent
        {
            public override void Show()
            {
                Console.WriteLine("Child Class Overridden Method");
            }
        }

        // 5
        class AccessDemo
        {
            private int a = 10;
            public int b = 20;
            protected int c = 30;
            internal int d = 40;
            protected internal int e = 50;

            public void Display()
            {
                Console.WriteLine("Private: " + a);
                Console.WriteLine("Public: " + b);
                Console.WriteLine("Protected: " + c);
                Console.WriteLine("Internal: " + d);
                Console.WriteLine("Protected Internal: " + e);
            }
        }

        class AccessChild : AccessDemo
        {
            public void Show()
            {
           
                Console.WriteLine("Public: " + b);
                Console.WriteLine("Protected: " + c);
                Console.WriteLine("Internal: " + d);
                Console.WriteLine("Protected Internal: " + e);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("---- Static Class ----");
                StaticDemo.Show();

                Console.WriteLine("\n---- Sealed Class ----");
                SealedDemo sd = new SealedDemo();
                sd.Display();

                Console.WriteLine("\n---- Abstract Class ----");
                AbstractDemo ad = new Circle();
                ad.Info();
                ad.Draw();

                Console.WriteLine("\n---- Virtual / Override ----");
                Parent p = new Child();
                p.Show();

                Console.WriteLine("\n---- Access Specifiers ----");
                AccessChild ac = new AccessChild();
                ac.Show();

                Console.ReadLine();
            }
        }
    }


}

