using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.DataLayer;
using SM.Entity;

namespace SM.LogicLayer
{
    public class MyRepo
    {
        private AccessInfo _infoAccess;
        private AccessAdmin _AAccess;
        private AccessSkill _sAccess;

        public object MessageBox { get; private set; }

        public MyRepo()
        {
            _infoAccess = new AccessInfo();
            _AAccess = new AccessAdmin();
            _sAccess = new AccessSkill();
        }
        public List<Admin> GetAdmin()
        {
            return _AAccess.GetAdmin();
        }
        public List<Employee> GetAllInfo()
        {
            return _infoAccess.GetInfo();
        }
        public List<Skill> GetSkill()
        {
            return _sAccess.GetSkill();
        }

        public bool CheckAdmin(Admin adm, out string error)
       {
            error = string.Empty;
          //if (string.IsNullOrEmpty(adm.Username)) {  return false; }
           if (!_AAccess.AdminInfo(adm))
           {
               return false;
           }
           return true;
       }

        public Employee GetInfoId(int id)
        {
            var res = _infoAccess.GetInfoId(id);
            if (res != null) return res.First();
            return null;
        }
      
        public bool AddInfo(Employee inf, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(inf.Name))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.InsertInfo(inf))
            {
               return false;
              // MessageBox.Show("wrong or missing info");
            }
          
            return true;
        }

        public bool ModifyAddress(int id,string address, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(address))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyAddress(id,address))
            {
                return false;
            }
            return true;
        }
        public bool ModifyContactNo(int id, string contactno, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(contactno))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyContactNo(id, contactno))
            {
                return false;
            }
            return true;
        }

        public bool ModifyEmail(int id, string email, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(email))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyEmail(id, email))
            {
                return false;
            }
            return true;
        }

        public bool ModifyPost(int id, string post, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(post))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyPost(id, post))
            {
                return false;
            }
            return true;
        }

        public bool ModifyWorkingDays(int id, string workingdays, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(workingdays))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyWorkingDays(id, workingdays))
            {
                return false;
            }
            return true;
        }

        public bool ModifyWorkingHours(int id, string workinghours, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(workinghours))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyWorkingHours(id, workinghours))
            {
                return false;
            }
            return true;
        }

        public bool ModifyReportingTime(int id, string reportingtime, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(reportingtime))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyReportingTime(id, reportingtime))
            {
                return false;
            }
            return true;
        }
        public bool ModifyLeavingTime(int id, string leavingtime, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(leavingtime))
            {
                error = "Missing or Wrong Information";
                return false;
            }
            if (!_infoAccess.ModifyLeavingTime(id, leavingtime))
            {
                return false;
            }
            return true;
        }

        public bool AddSkill( Skill s, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(s.Name))
            {
                error = "missing info";
                return false;
            }
            //if (string.IsNullOrEmpty(s.IntermediateLevel))
            //{
            //    error = "missing info";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(s.AdvanceLevel))
            //{
            //    error = "missing info";
            //    return false;
            //}
            if (!_sAccess.InsertSkillLevel(s))
            {
                return false;
            }
            return true;
        }
    }
}
