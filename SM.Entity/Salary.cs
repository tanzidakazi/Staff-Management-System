using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Entity
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        //[ForeignKey("Info")]
       // public int InfoId { get; set; }
        public string Post { get; set; }
        public string LateCount { get; set; }
        public string MissedDaysCount { get; set; }
        public string SalaryperMonth { get; set; }
        public string SalaryDetected { get; set; }
        public string SalaryRemaining { get; set; }
    }
}
