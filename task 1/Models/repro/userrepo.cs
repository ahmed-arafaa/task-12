using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task_1.Areas.Identity.Data;
using task_1.Models.data;

namespace task_1.Models.repro
{
    public class userrepo : irep<task_1User, certifications>
    {
        public Models.data.appdbcontext dbcontext;
        public userrepo(appdbcontext conteext)
        {
            this.dbcontext = conteext;
        }
        public void add(int id, string name, List<certifications> users)
        {
            var x = "";
            if (dbcontext.users.Count() != 0)
            {
                x = dbcontext.users.LastOrDefault().Id + 1.ToString();
            }
            else
            {
                x = "0";
            }
            //throw new NotImplementedException();
            dbcontext.users.Add(new task_1User { Id = x,  UserName = name, certifications = users });
            dbcontext.SaveChanges();

        }


        List<task_1User> irep<task_1User, certifications>.get()
        {
            var getusers = dbcontext.users.Where(c => c.certifications.Count() >= 5).ToList();
            return getusers;
        }
    }
}
