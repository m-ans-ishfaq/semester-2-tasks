using System;

namespace PD5.UAMS
{
    public class DegreeProgramBL
    {
        public string Title;
        public int Duration;
        public int AvailableSeats;
        // public List<SubjectBL> Subjects;
        public List<int> SubjectCodes;
        public double GetMerit()
        {
            return 0;
        }
    }
}