using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class Schedule
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }

        //Foreign key for Students
        public int StudentId { get; set; }
        public Students Students { get; set; }

        //Foreign key for Lessons
        public int LessonId { get; set; }
        public Lessons Lessons { get; set; }

        // ? enum/int/כזה סוג משתנה

        // יום בשבוע
        public string DayOfWeek { get; set; }

        // שעת התחלה
        public TimeOnly BeginningTime { get; set;}
    }
}
