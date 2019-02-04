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

        //List<Lesson> lessons = new List<Lesson>();
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
            this.Controls.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Wednesday, DateTime.Parse("9:55"), 80,
                "Prg 2", "Tobias Lindberg", "Sal 1", Color.Aqua);
            this.Controls.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Thursday, DateTime.Parse("12:10"), 80,
                "Prg 2", "Tobias Lindberg", "Sal 1", Color.Aqua);
            this.Controls.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Thursday, DateTime.Parse("8:25"), 80,
                "Ma 5", "Hiba Jameel", "Sal 3", Color.GreenYellow);
            this.Controls.Add(tmpLesson);
            tmpLesson = new Lesson(DayOfWeek.Thursday, DateTime.Parse("9:55"), 80,
                "Ma 5", "Hiba Jameel", "Sal 3", Color.GreenYellow);
            this.Controls.Add(tmpLesson);
        }

        

        private void lblLesson_Click(object sender, EventArgs e)
        {

        }
    }
}
