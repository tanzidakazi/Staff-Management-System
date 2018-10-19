using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Skill
    {
        public Skill()
        {
            EmployeeSkills = new List<EmployeeSkill>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public List<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
