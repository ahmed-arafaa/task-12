using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task_1.Areas.Identity.Data;
using task_1.Models.data;

namespace task_1.Models.repro
{
    public class certificationrepo : irep<certifications, task_1User>
    {
        
        public Models.data.appdbcontext dbcontext;
        public certificationrepo(appdbcontext context)
        {
            this.dbcontext = context;
        }
      
        public void add(int id, string name, List<task_1User> users)
        {
            dbcontext.certification.Add(new certifications { id = id, name = name, user = users });
            dbcontext.SaveChanges();
        }

 
        public List<certifications> get()
        {
          var x=dbcontext.certification.ToList();
            return x;
        }
    }
}
