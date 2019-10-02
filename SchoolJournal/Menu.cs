using System;
using System.Collections.Generic;

namespace SchoolJournal
{
    class Menu
    {
        public int MenuItemSelection()
        {
            Console.WriteLine("Please, select action:");
            Console.WriteLine("1 - add subject");
            Console.WriteLine("2 - add mark to journal");
            Console.WriteLine("3 - show statistic (min, max, average mark)");
            Console.WriteLine("4 - exit");

            return Convert.ToInt32(Console.ReadLine());
        }
        public int SubjectMenuItemSelection(List<Subject> subjects)
        {
            Console.WriteLine("Select subject:");
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"{i} - '{subjects[i].GetName()}'");
            }
            return Convert.ToInt32(Console.ReadLine());
        }

        public int StatisticMenuItemSelection(List<Subject> subjects)
        {
            Console.WriteLine("Select action:");
            Console.WriteLine("1 - statistics for all subjects");
            Console.WriteLine("2 - statistics for specific subjects");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ShowInvalidMenuItenText()
        {
            Console.WriteLine("Please, select correct menu item!");
        }

    }
}
