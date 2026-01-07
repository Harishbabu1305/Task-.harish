using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class Employee
        {
            public int empId;
            public string empName;
            public double salary;

            public void Input()
            {
                Console.Write("Enter Emp ID: ");
                empId = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                empName = Console.ReadLine();

                Console.Write("Enter Salary: ");
                salary = double.Parse(Console.ReadLine());
            }

            public void Display()
            {
                Console.WriteLine("Emp ID : " + empId);
                Console.WriteLine("Name   : " + empName);
                Console.WriteLine("Salary : " + salary);
            }
        }

        //  2.
        class Vehicle
        {
            public string vehicleType;
        }

        class Car : Vehicle
        {
            public string brand;
        }

        class SportsCar : Car
        {
            public int speed;

            public void Display()
            {
                Console.WriteLine("Vehicle Type : " + vehicleType);
                Console.WriteLine("Brand        : " + brand);
                Console.WriteLine("Speed        : " + speed);
            }
        }

        //  3. 
        class Shape1
        {
            public void Display()
            {
                Console.WriteLine("This is a Shape");
            }
        }

        class Rectangle : Shape1
        {
            public int length;
            public int breadth;

            public void Area()
            {
                Console.WriteLine("Area of Rectangle = " + (length * breadth));
            }
        }

        //  4. 
        class Account
        {
            public int accountNo;
        }

        class SavingsAccount : Account
        {
            public double balance;

            public void Display()
            {
                Console.WriteLine("Account No : " + accountNo);
                Console.WriteLine("Balance    : " + balance);
            }
        }

        //  5. 
        class Device
        {
            public string deviceName;
        }

        class Mobile : Device
        {
            public string model;
        }

        class SmartPhone : Mobile
        {
            public string os;

            public void Display()
            {
                Console.WriteLine("Device Name : " + deviceName);
                Console.WriteLine("Model       : " + model);
                Console.WriteLine("OS          : " + os);
            }
        }

        // 6. 
        class Area
        {
            public void CalculateArea(int side)
            {
                Console.WriteLine("Area of Square = " + (side * side));
            }

            public void CalculateArea(int l, int b)
            {
                Console.WriteLine("Area of Rectangle = " + (l * b));
            }

            public void CalculateArea(double r)
            {
                Console.WriteLine("Area of Circle = " + (3.14 * r * r));
            }
        }

        //  7. 
        class Shape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Circle");
            }

            public void Draw(int a)
            {
                Console.WriteLine("Drawing a Rectangle");
            }

            public void Draw(double a)
            {
                Console.WriteLine("Drawing a Triangle");
            }
        }

        //  MAIN 
        class Program
        {
            static void Main()
            {
                Console.WriteLine("---- 1. Employee ----");
                Employee e = new Employee();
                e.Input();
                e.Display();

                Console.WriteLine("\n---- 2. SportsCar ----");
                SportsCar sc = new SportsCar();
                sc.vehicleType = "Four Wheeler";
                sc.brand = "BMW";
                sc.speed = 300;
                sc.Display();

                Console.WriteLine("\n---- 3. Rectangle ----");
                Rectangle r = new Rectangle();
                r.length = 10;
                r.breadth = 5;
                r.Display();
                r.Area();

                Console.WriteLine("\n---- 4. Savings Account ----");
                SavingsAccount sa = new SavingsAccount();
                sa.accountNo = 12345;
                sa.balance = 50000;
                sa.Display();

                Console.WriteLine("\n---- 5. SmartPhone ----");
                SmartPhone sp = new SmartPhone();
                sp.deviceName = "Mobile";
                sp.model = "Samsung";
                sp.os = "Android";
                sp.Display();

                Console.WriteLine("\n---- 6. Area Overloading ----");
                Area a = new Area();
                a.CalculateArea(5);
                a.CalculateArea(4, 6);
                a.CalculateArea(3.5);

                Console.WriteLine("\n---- 7. Draw Overloading ----");
                Shape s = new Shape();
                s.Draw();
                s.Draw(10);
                s.Draw(5.5);
            }
        }
    }
    }
}
