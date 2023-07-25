using System;

namespace StudentAverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Marks Calculator");

            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();

            double[] subjectScores = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter score for subject {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out subjectScores[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid score.");
                    Console.Write($"Enter score for subject {i + 1}: ");
                }
            }

            double averageScore = (subjectScores[0] + subjectScores[1] + subjectScores[2]) / 3;

            Console.WriteLine($"Hello, {studentName}!");
            Console.WriteLine($"Your average score is: {averageScore:F2}");

            Console.WriteLine("Thank you for using the Student Average Calculator!");
        }
    }
}
