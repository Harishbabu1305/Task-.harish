using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace namespaces
{
   
    
        using System;


//TASK 1
namespace MyUtilities
    {
        class MathHelper
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
    }

   //TASK 4 
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {
        }
    }

    // TASK 5 
    namespace StudentData
    {
        class StudentFileHandler
        {
            string filePath = "students.txt";

            public void WriteStudents(string[] students)
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (string student in students)
                        {
                            sw.WriteLine(student);
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access denied while writing student file.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            public void ReadStudents()
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;
                        Console.WriteLine("Student Names:");
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Student file not found.");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access denied while reading student file.");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // TASK 1 
            MyUtilities.MathHelper math = new MyUtilities.MathHelper();
            Console.WriteLine("Addition Result: " + math.Add(10, 20));

            //  TASK 2
            string fileName = "message.txt";
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Hello C# Streams");
            }

            //  TASK 3 
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine("File Content:");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exist.");
            }

            // TASK 4 
            try
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                    throw new NegativeNumberException("Negative numbers are not allowed.");

                Console.WriteLine("You entered: " + num);
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Custom Error: " + ex.Message);
            }

            //  TASK 5
            StudentData.StudentFileHandler studentHandler = new StudentData.StudentFileHandler();
            string[] students = { "Ravi", "Anita", "Kiran" };

            studentHandler.WriteStudents(students);
            studentHandler.ReadStudents();

            Console.ReadLine();
        }
    }

}

