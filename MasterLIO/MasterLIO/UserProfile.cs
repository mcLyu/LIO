using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class UserProfile
    {
        public int userId { get; set; }
        public String login {get;set;}
        public String password { get; set; } 
        public Role role { get; set; } 
        public Statistic statistic { get; set; }
        


        public UserProfile(String login, String password, Role role, int id)
        {
            this.userId = id;
            this.login = login;
            this.password = password;
            this.role = role;
            statistic = new Statistic(userId);
        }

        public override string ToString()
        {
            return login;
        }

        public static List<Role> getRoles()
        {
            return Enum.GetValues(typeof(Role)).Cast<Role>().ToList<Role>();
        }
    }

    enum Role {ADMIN, STUDENT}
}
