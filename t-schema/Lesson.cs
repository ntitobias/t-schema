using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t_schema
{   
    class Lesson:Label
    {
        DayOfWeek weekDay;
        DateTime startTime;
        int length;
        string course;
        string teacher;
        string room;

        public Lesson(DayOfWeek weekDay, DateTime startTime, int length, string course, 
            string teacher, string room, Color color)
        {
            this.weekDay = weekDay;
            this.startTime = startTime;
            this.length = length;
            this.course = course;
            this.teacher = teacher;
            this.room = room;

            this.Location = new System.Drawing.Point(35 + DayNumber() * 100, 6 + ((startTime.Hour - 8) * 60 + startTime.Minute) / 10 * 6);
            //this.Name = "lblLesson" + lessonNo;
            this.AutoSize = false;
            this.BackColor = color;
            this.Size = new System.Drawing.Size(90, length / 10 * 6);
            //this.TabIndex = 9 + lessonNo;
            this.Text = Time(startTime) + "-" + Time(EndTime()) + "\n"
                        + room + "  " + course + "\n"
                        + teacher;
        }

        //Omvandlar ett värde av typen DateTime till en string
        private string Time(DateTime time)
        {
            string strTime, extra;

            if (time.Minute < 10)
                extra = "0";
            else
                extra = "";

            strTime = time.Hour + ":" + extra + time.Minute;

            return strTime;
        }

        //Retrunerar sluttiden
        private DateTime EndTime()
        {
            return startTime + TimeSpan.FromMinutes(length);
        }

        //Tar reda på vilket nummer en veckodag har (0-6)
        private int DayNumber()
        {
            switch (weekDay)
            {
                case DayOfWeek.Sunday:
                    return 6;
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
                default:
                    return 0;
            }
        }
    }
}
