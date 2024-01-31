using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.One
{
    public class StudentManagementSystem
    {
        public List<Student> students = [];
        public void Run()
        {
            Console.WriteLine("Student Management System");
            Console.WriteLine("-------------------------");
            string[] options = {
                "1. Add Student",
                "2. Show Students",
                "3. Calculate Aggregate",
                "4. Top Students"
            };
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
            int selectedOption = 0;
            do
            {
                Console.Write("Select your option: ");
                selectedOption = Convert.ToInt32(Console.ReadLine());
                switch (selectedOption)
                { 

                }
            } while (selectedOption == 0);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Students ({students.Count}): \n");
            foreach (Student student in students)
            {
                Console.Write("Name: " + student.Name + "\t");
                Console.Write("Matric Marks: " + student.MatricMarks.ToString() + "\t");
                Console.Write("FSc Marks: " + student.FScMarks.ToString() + "\t");
                Console.Write("ECAT Marks: " + student.ECATMarks.ToString());
                Console.WriteLine();
            }
        }

        public List<Student> GetTop3Students()
        {
            if (students.Count <= 3)
                return this.students;

            List<Student> top3students = [];
            // Sort
            for (int i = 0; i < students.Count; i++)
            {
                Student leastElement = students[i];
                for (int j = i; j < students.Count && j != i; j++)
                {
                    if (students[j].Aggregate < students[i].Aggregate)
                    {
                        leastElement = students[j];
                    }
                }
                top3students.Add(leastElement);
            }
            top3students.RemoveRange(0, top3students.Count - 3);
            return top3students;
        }
    }
    public class Student
    {
        public string Name;
        public int MatricMarks;
        public int FScMarks;
        public int ECATMarks;
        public double Aggregate;

        public Student(string name, int matricMarks, int fscMarks, int ecatMarks)
        {
            this.Name = name;
            this.MatricMarks = matricMarks;
            this.FScMarks = fscMarks;
            this.ECATMarks = ecatMarks;
        }
        public void CalculateAggregate()
        {
            this.Aggregate = ((MatricMarks * .25) + (FScMarks * .45) + (ECATMarks * .30));
        }
    }
}
