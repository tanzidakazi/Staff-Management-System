using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;

namespace SM.DataLayer
{
    public class AccessAdmin
    {
        public List<Admin> GetAdmin()
        {
            using (var dbContext = new MyContext())
            {
                return dbContext.Admins.ToList();

            }
        }
        public bool AdminInfo(Admin adm)
        {
            using (var dbContext = new MyContext())
            {
                var res = dbContext.Admins.Where(c => c.Username.Equals(adm.Username) && c.Password.Equals(adm.Password));
                return res.Any();
                //return dbContext.SaveChanges() > 0;
            }
        }
    }
}
