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
        public Statistic statistic { get; set; }

        public UserProfile(String login, String password, Role role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
            statistic = new Statistic();
        }
        
        public UserProfile(String login, String password, Role role, Statistic statistic)
        {
            this.login = login;
            this.password = password;
            this.role = role;
            this.statistic = statistic;
        }
    }

    enum Role {ADMIN, STUDENT}
}
