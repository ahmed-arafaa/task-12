using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using task_1.Models.data;

namespace task_1.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the task_1User class
    public class task_1User : IdentityUser
    {

       public ICollection<certifications> certifications { set; get; }


    }
}
