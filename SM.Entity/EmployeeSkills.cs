using System.ComponentModel.DataAnnotations;

namespace SM.Entity
{
    public class EmployeeSkill
    {
        [Key]
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int EmployeeId { get; set; }
        public Skill Skill { get; set; }
        public Employee Employee { get; set; }
    }
}