using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task_1.Areas.Identity.Data;

namespace task_1.Models.data
{
    public class appdbcontext:DbContext
    {
        public appdbcontext(DbContextOptions<appdbcontext>options):base (options)
        {


        }
        public DbSet<certifications> certification { set; get; }
        public DbSet<task_1User> users { set; get; }




    }
}
