using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;

namespace SM.DataLayer
{
   public class AccessSkill
    {
        public List<Skill> GetSkill()
        {
            using (var dbContext= new MyContext() )
            {
                return dbContext.Skills.ToList();
            }
        }
        public bool InsertSkillLevel( Skill s)
        {
            using ( var dbContext = new MyContext())
            {
                dbContext.Skills.Add(s);
                return dbContext.SaveChanges() > 0;
            }
        }
        public bool DeleteSkillLevel(Skill s)
        {
            using (var dbContext = new MyContext())
            {
                dbContext.Skills.Remove(s);
                return dbContext.SaveChanges() > 0;
            }
        }


    }
}
