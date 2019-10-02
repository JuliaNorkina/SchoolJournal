namespace SchoolJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            StudentJournal journal = new StudentJournal();
            journal.EnteringStudentName();

            while (true)
            {
                switch (menu.MenuItemSelection())
                {
                    case 1:
                        journal.AddSubject();
                        break;
                    case 2:
                        int numberOfSubject = menu.SubjectMenuItemSelection(journal.subjects);
                        Subject subject = journal.subjects[numberOfSubject];
                        subject.AddMark();
                        break;
                    case 3:
                        ShowStatistic(menu, journal);
                        break;
                    case 4:
                        return;
                    default:
                        menu.ShowInvalidMenuItenText();
                        break;
                }
            }
        }

        private static void ShowStatistic(Menu menu, StudentJournal journal)
        {
            switch (menu.StatisticMenuItemSelection(journal.subjects))
            {
                case 1:
                    foreach (Subject sbj in journal.subjects)
                    {
                        if (sbj.marks.Count != 0)
                        {
                            sbj.PrintStatistic();
                        }

                    }
                    break;
                case 2:
                    Subject sbj1 = journal.subjects[menu.SubjectMenuItemSelection(journal.subjects)];
                    if (sbj1.marks.Count != 0)
                    {
                        sbj1.PrintStatistic();
                    }
                    break;
                default:
                    menu.ShowInvalidMenuItenText();
                    break;
            }
        }
    }
}
