using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class FinancialTransactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int  TransactionId { get; set; }

        //Foreign key for Students
        public int StudentId { get; set; }
        public Students Students { get; set; }

        // מועד התשלום
        public DateTime PaymentDate { get; set; }

        // סכום ששולם
        public double AmountPaid { get; set;}

        // סכום החוב
        public double AmountOfDebt { get; set; }

        // תאריך תשלום אחרון
        public DateTime LastPaymentDate { get; set; }
        




    }
}