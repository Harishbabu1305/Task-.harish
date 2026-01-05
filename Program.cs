using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    internal class Program
    {
       
    //1

class Employee
        {
            public int empId;
            public string empName;
            public double salary;


            public void GetData(int id, string name, double sal)
            {
                empId = id;
                empName = name;
                salary = sal;
            }

 
            public void Display()
            {
                Console.WriteLine("Employee ID   : " + empId);
                Console.WriteLine("Employee Name : " + empName);
                Console.WriteLine("Salary        : " + salary);
            }
        }

        
            static void Main()
            {
                Employee emp = new Employee();
                emp.GetData(101, "Ravi", 25000);
                emp.Display();
            }
        }
        //2


        class Sample
        {
            int x = 10;

            void Show()
            {
                Console.WriteLine("Value of x: " + x);
            }

            public void Display()
            {
                Show();
            }

            static void Main()
            {
                Sample s = new Sample();
                s.Display();
            }
        }
        //3

class Sample1
    {

        public int a = 50;

        public void Show()
        {
            Console.WriteLine("Value of a: " + a);
        }
    }

    class Sample2
    {
        static void Main()
        {
            Sample1 obj = new Sample1();  
            Console.WriteLine(obj.a);     
            obj.Show();                   
        }
    }
    }

