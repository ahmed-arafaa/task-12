using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_1.Models.repro
{
   public interface irep<t,tt>
    {
        void add( int id,string name,List<tt> users);
        List<t> get();





    }
}
