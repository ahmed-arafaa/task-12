using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using task_1.Areas.Identity.Data;

namespace task_1.Models.data
{
    public class certifications
    {
        public int id { get; set; }
        public string name { get; set; }

        [NotMapped]
        public ICollection<task_1User> user { set; get; }

    }
}
