using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;

namespace SM.DataLayer
{
    public class AccessInfo
    {
        public List<Employee> GetInfo()
        {
            using (var dbContext = new MyContext())
            {
                return dbContext.Informations.ToList();

            }
        }
    
        public bool InsertInfo(Employee inf)
        {
            using (var dbContext = new MyContext())
            {
                dbContext.Informations.Add(inf);
                return dbContext.SaveChanges() > 0;

            }
        }
        public bool DeleteInfo(Employee inf)
        {
            using (var dbContext = new MyContext())
            {
                dbContext.Informations.Remove(inf);
                return dbContext.SaveChanges() > 0;
            }
        }
        public List<Employee> GetInfoId(int id)
        {
            using (var dbContext = new MyContext())
            {
                return dbContext.Informations.Where(c => c.Id == id).ToList();
            }
        }
        
        public bool ModifyAddress(int id, string addr)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                //dbContext.Information.
                if(data!=null)
                {
                    data.First().Address = addr;
                    return dbContext.SaveChanges()>0;
                }
                return false;
                //dbContext.Information.(inf);
                //return dbContext.SaveChanges() > 0;

            }
        }
        public bool ModifyContactNo(int id, string contactno)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                if (data != null)
                {
                    data.First().ContactNumber = contactno;
                    return dbContext.SaveChanges()>0;
                }
                return false;
            }
        }
        public bool ModifyEmail(int id, string email)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                if (data != null)
                {
                    data.First().Email = email;
                    return dbContext.SaveChanges()>0;
                }
                return false;
            }
        }

        public bool ModifyPost(int id, string post)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                if (data != null)
                {
                    data.First().Post = post;
                    return dbContext.SaveChanges()>0;
                }
                return false;
            }
        }

        public bool ModifyWorkingDays(int id, string day)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                if (data != null)
                {
                    data.First().WorkingDays = day;
                    return dbContext.SaveChanges()>0;
                }
                return false;
            }
        }

        public bool ModifyWorkingHours(int id, string hour)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                if (data != null)
                {
                    data.First().WorkingHours = hour;
                    return dbContext.SaveChanges()>0;
                }
                return false;
            }
        }

        public bool ModifyReportingTime(int id, string report)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                if (data != null)
                {
                    data.First().ReportingTime = report;
                    return dbContext.SaveChanges()>0;
                }
                return false;
            }
        }

        public bool ModifyLeavingTime(int id, string leave)
        {
            using (var dbContext = new MyContext())
            {
                var data = dbContext.Informations
                    .Where(c => c.Id == id);
                if (data != null)
                {
                    data.First().LeavingTime = leave;
                    return dbContext.SaveChanges()>0;
                }
                return false;
            }
        }


    }
}
