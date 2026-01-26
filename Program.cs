using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_library_DLL___EXE
{
   
    using System;
using System.Collections.Generic;

// 1
namespace MathUtilities
    {
        public class Calculator
        {
            public int Add(int a, int b) => a + b;
            public int Subtract(int a, int b) => a - b;
            public int Multiply(int a, int b) => a * b;
            public int Divide(int a, int b) => a / b;
        }

        public class AdvancedMath
        {
            public double Power(double a, double b) => Math.Pow(a, b);
            public double SquareRoot(double a) => Math.Sqrt(a);

            public int Factorial(int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                    fact *= i;
                return fact;
            }
        }
    }

    // 2
    namespace StudentLibrary
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }

            public string CalculateGrade()
            {
                if (Marks >= 80) return "A";
                if (Marks >= 60) return "B";
                if (Marks >= 40) return "C";
                return "Fail";
            }
        }

        public class StudentService
        {
            private List<Student> students = new List<Student>();

            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            public double CalculateAverageMarks()
            {
                int total = 0;
                foreach (var s in students)
                    total += s.Marks;

                return students.Count == 0 ? 0 : (double)total / students.Count;
            }
        }
    }

    // 3
  
    namespace BankLibrary
    {
        public class Account
        {
            public int AccountNumber { get; set; }
            public double Balance { get; protected set; }

            public void Deposit(double amount)
            {
                Balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= Balance)
                    Balance -= amount;
                else
                    Console.WriteLine("Insufficient Balance");
            }

            public double CheckBalance()
            {
                return Balance;
            }
        }

        public class SavingsAccount : Account { }
        public class CurrentAccount : Account { }
    }

    // 4. 
 
    namespace LoggerLibrary
    {
        public class Logger
        {
            public void LogInfo(string message)
            {
                Console.WriteLine("[INFO] " + message);
            }

            public void LogWarning(string message)
            {
                Console.WriteLine("[WARNING] " + message);
            }

            public void LogError(string message)
            {
                Console.WriteLine("[ERROR] " + message);
            }
        }
    }

    // 5.
   
    namespace PayrollLibrary
    {
        public class Employee
        {
            public int EmployeeId;
            public string Name;
            public double BasicSalary;
        }

        public class PayrollCalculator
        {
            public double CalculateHRA(double basic) => basic * 0.20;
            public double CalculateDA(double basic) => basic * 0.10;
            public double CalculateTax(double basic) => basic * 0.05;

            public double CalculateNetSalary(double basic)
            {
                return basic + CalculateHRA(basic) + CalculateDA(basic) - CalculateTax(basic);
            }
        }
    }

   
  
    {
     
        {
            
            var calc = new MathUtilities.Calculator();
            Console.WriteLine("Add: " + calc.Add(10, 5));

            var adv = new MathUtilities.AdvancedMath();
            Console.WriteLine("Factorial: " + adv.Factorial(5));

            
            var service = new StudentLibrary.StudentService();
            service.AddStudent(new StudentLibrary.Student { Id = 1, Name = "Ravi", Marks = 85 });
            service.AddStudent(new StudentLibrary.Student { Id = 2, Name = "Anu", Marks = 70 });
            Console.WriteLine("Average Marks: " + service.CalculateAverageMarks());

           
            var account = new BankLibrary.SavingsAccount();
            account.Deposit(5000);
            account.Withdraw(2000);
            Console.WriteLine("Account Balance: " + account.CheckBalance());

            
            var logger = new LoggerLibrary.Logger();
            logger.LogInfo("Transaction completed");

           
            var emp = new PayrollLibrary.Employee
            {
                EmployeeId = 101,
                Name = "Kumar",
                BasicSalary = 30000
            };

            var payroll = new PayrollLibrary.PayrollCalculator();
            Console.WriteLine("Net Salary: " + payroll.CalculateNetSalary(emp.BasicSalary));
        }
    }
}
