using System;

namespace Tacda_SW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Input the Name of the Student: ");
            string fullName = Console.ReadLine();

            Console.Write("Input PRELIM grade: ");
            double prelim = double.Parse(Console.ReadLine());

            Console.Write("Input MIDTERM grade: ");
            double midterm = double.Parse(Console.ReadLine());

            Console.Write("Input FINALS grade: ");
            double finals = double.Parse(Console.ReadLine());

            // GPA and Grade
            double gpa;
            String grade = "";

            // Average
            gpa = (prelim + midterm + finals)/3;

            // Grade Equivalent
            if (gpa >= 90)
                grade = "A";
            else
            if (gpa >= 80 && gpa < 90)
                grade = "B";
            else
            if (gpa >= 70 && gpa < 80)
                grade = "C";
            else
            if (gpa >= 50 && gpa < 70)
                grade = "D";
            else
            if (gpa < 50)
                grade = "E";


            // Output
            Console.WriteLine("\n\n\nHello, " + fullName);
            Console.WriteLine("Your GPA is: " + gpa);
            Console.WriteLine("Your grade is: " + grade);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();



        }
    }
}