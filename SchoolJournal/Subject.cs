using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolJournal
{
    public class Subject
    {
        string name;
        public List<double> marks { get; }

        public Subject(string name, List<double> marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public void AddMark()
        {
            Console.WriteLine("Please, enter a mark: ");
            marks.Add(Convert.ToDouble(Console.ReadLine()));
        }

        public string GetName()
        {
            return name;
        }

        public void PrintStatistic()
        {
            Console.WriteLine($"Min mark = {marks.Min()}, max mark = {marks.Max()}, average mark = {marks.Average()}.");
        }
    }
}
