using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class Students
    {
        
 


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        //שֵׁם
        public string FirstName { get; set; }

        //משפחה
        public string LastName { get; set; }

        // פרטי התקשרות
        public string ContactDetails { get; set; }

        //שנת לידה
        public int YearOfBirth { get; set; }
    }
}
