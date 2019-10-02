using System;
using System.Collections.Generic;

namespace SchoolJournal
{
    class StudentJournal
    {
        public List<Subject> subjects = new List<Subject>();

        public string EnteringStudentName()
        {
            Console.WriteLine("Hello friend! Please enter your name: ");
            return Console.ReadLine();
        }

        public void AddSubject()
        {
            Console.WriteLine("Enter subject name: ");
            Subject subject = new Subject(Console.ReadLine(), new List<double>());
            subjects.Add(subject);
        }

    }
}
