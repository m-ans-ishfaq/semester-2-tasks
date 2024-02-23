using System;
using System.Collections.Generic;

namespace LAB5
{
    class Student
    {
        public string Name;
        public int Age;
        public float FSCMarks;
        public float ECATMarks;
        public float Merit;
        public List<DegreeProgram> Preferences;
        public List<Subject> Subjects;
        public List<DegreeProgram> DegreeProgram;
        public void CalculateMerit() {}
        public void RegisterStudentSubject(Subject s) {}
        public int GetCreditHours() { return 0; }
        
    }
    class DegreeProgram
    {
        public string Title;
        public string Duration;
        public List<Subject> Subjects;
        public void AddSubject(Subject s) {}
        public int CalculateCreditHours() { return 0; }
    }
    class Subject
    {
        public string Code;
        public int CreditHours;
        public string SubjectType;
        public int SubjectFee;
    }
}