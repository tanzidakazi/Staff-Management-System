using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SM.Entity
{
    
    public class Employee
    {
        public Employee()
        {
            EmployeeSkills = new List<EmployeeSkill>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string JoiningDate { get; set; }
        public string Post { get; set; }
        public string Salary { get; set; }
        public string WorkingDays { get; set; }
        public string WorkingHours { get; set; }
        public string ReportingTime { get; set; }
        public string LeavingTime { get; set; }
        public List<EmployeeSkill> EmployeeSkills { get; set; }
    }
}