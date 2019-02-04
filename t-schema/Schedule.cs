using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t_schema
{
    public partial class Schedule : Form
    {

        List<Lesson> lessons = new List<Lesson>();
        Lesson tmpLesson;
        Label tmpLabel;

        public Schedule()
        {
            InitializeComponent();

            //Skriv ut tidsangivelser längst till vänster
            for(int i=8; i<=17; i++)
            {
                tmpLabel = new Label
                {
                    Location = new System.Drawing.Point(0, (i - 8) * 36),
                    Name = "lbl" + i,
                    Size = new System.Drawing.Size(34, 13),
                    Text = i.ToString() + ":00",
                    TextAlign = System.Drawing.ContentAlignment.TopRight
                };
                this.Controls.Add(tmpLabel);
            }
            
            //Läs in några exempel-lektioner. Bör bytas ut mot inläsning från databas
            tmpLesson = new Lesson(DayOfWeek.Tuesday, DateTime.Parse("12:40"), 80,
                "Prg 2", "Tobias Lindberg", "Sal 1", Color.Aqua);
            lessons.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Wednesday, DateTime.Parse("9:55"), 80,
                "Prg 2", "Tobias Lindberg", "Sal 1", Color.Aqua);
            lessons.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Thursday, DateTime.Parse("12:10"), 80,
                "Prg 2", "Tobias Lindberg", "Sal 1", Color.Aqua);
            lessons.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Thursday, DateTime.Parse("8:25"), 80,
                "Ma 5", "Hiba Jameel", "Sal 3", Color.GreenYellow);
            lessons.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Thursday, DateTime.Parse("9:55"), 80,
                "Ma 5", "Hiba Jameel", "Sal 3", Color.GreenYellow);
            lessons.Add(tmpLesson);

            //lessonNo används 
            int lessonNo = 0;
            foreach (Lesson l in lessons)
            {
                lessonNo++;
                //Omvandla lektionslängden till en sluttid för utskrift.
                DateTime endTime = l.StartTime + TimeSpan.FromMinutes(l.Length);
                //Skapa en label
                tmpLabel = new Label
                {
                    Location = new System.Drawing.Point(35 + DayNumber(l.WeekDay) * 100, 6+((l.StartTime.Hour-8) * 60 + l.StartTime.Minute)/10*6),
                    Name = "lblLesson" + lessonNo,
                    AutoSize = false,
                    BackColor = l.Color,
                    Size = new System.Drawing.Size(90, l.Length/10*6),
                    TabIndex = 9 + lessonNo,
                    Text = Time(l.StartTime) + "-" + Time(endTime) + "\n" 
                        + l.Room + "  " + l.Course + "\n"
                        + l.Teacher
                };
                this.Controls.Add(tmpLabel);

            }

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

        //Tar reda på vilket nummer en veckodag har (0-6)
        private int DayNumber(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
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

        private void lblLesson_Click(object sender, EventArgs e)
        {

        }
    }
}
