using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class UserProfile
    {
        public String login {get;set;}
        public String password { get; set; } 
        public Role role { get; set; } 
        //public Statistic statistic;
    }

    enum Role {ADMIN, STUDENT}
}
