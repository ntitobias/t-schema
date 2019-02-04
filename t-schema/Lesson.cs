using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t_schema
{   
    class Lesson
    {
        DayOfWeek weekDay;
        DateTime startTime;
        int length;
        string course;
        string teacher;
        string room;
        Color color;

        public Lesson(DayOfWeek weekDay, DateTime startTime, int length, string course, 
            string teacher, string room, Color color)
        {
            this.WeekDay = weekDay;
            this.StartTime = startTime;
            this.Length = length;
            this.Course = course;
            this.Teacher = teacher;
            this.Room = room;
            this.Color = color;
        }

        public DayOfWeek WeekDay { get => weekDay; set => weekDay = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public int Length { get => length; set => length = value; }
        public string Course { get => course; set => course = value; }
        public string Teacher { get => teacher; set => teacher = value; }
        public string Room { get => room; set => room = value; }
        public Color Color { get => color; set => color = value; }
    }
}
