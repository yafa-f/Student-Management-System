using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public enum  DurationOfLesson
        {
            HALFANHOUR,
            FORTYFIVEMINUTES,
            HOUR

        }
    
 
 

    public class Lessons
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LessonId { get; set; }

        //פעם או פעמיים בשבוע
        public int NumberOfTimesAweek { get; set; }

        //? double/int/string/כזה סוג משתנה

        //מֶשֶׁך-חצי שעה, שלושת רבעי שעה או שעה
        public DurationOfLesson Duration { get; set; }

        //עֲלוּת
        public double Cost { get; set; }
        }
}
