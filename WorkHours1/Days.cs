using System;
using System.Collections.Generic;
using System.Text.Json;
namespace WorkHours1
{
    [Serializable]
    public class Day : IComparable<Day>
    {
        public DateTimeOffset Date;
        public TimeSpan TotalOvertime;
        public string DayName;

        public Day(DateTimeOffset date, TimeSpan totalOvertime, string dayName)
        {
            Date = date;
            TotalOvertime = totalOvertime;
            DayName = dayName;
        }

        public int CompareTo(Day otherDay)
        {
            return Date.CompareTo(otherDay.Date);
        }
    }

    [Serializable]
    public class Month
    {
        public string MonthName;
        public TimeSpan Overtime = new TimeSpan();
        public List<Day> ListOfDays = new List<Day>();
        
        public void SaveDay(Day day)
        {
            //prvo provjerimo dal postoji dan u listi, ako postoji assignamo novu vrijednost.
            for (int i = 0; i < ListOfDays.Count; i++)
            {
                if (day.Date == ListOfDays[i].Date)
                {
                    Overtime -= ListOfDays[i].TotalOvertime;
                    Overtime += day.TotalOvertime;

                    ListOfDays[i] = day;
                    return;
                    //izlazimo van zato sto ne zelimo ici dalje po listi,
                    //a na kraju funckcije dodajemo ako ga nismo nasli
                }
            }

            //ako ne postoji dodamo ga u listu.
            ListOfDays.Add(day);
            Overtime += day.TotalOvertime;
            ListOfDays.Sort();
        }
    }
}
