using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class DBStub
    {
        public static UserProfile AuthorizeUser(String login, String password)
        {

            return null;
        }

        public static UserProfile RegisterUser(String login, String password)
        {
            return null;
        }

        public static void RemoveUser(UserProfile user)
        {

        }

        public static Statistic GetUserStatistic(UserProfile user)
        {
            return null;
        }

        public static UserProfile GetUserById(int userId)
        {
            return null;
        }

        public static void SaveExercise(Exercise exercise)
        {

        }

        public static List<Exercise> LoadExercises()
        {
            return null;
        }

        public static List<UserProfile> LoadAllUsers()
        {
            List<UserProfile> users = new List<UserProfile>();

            users.Add(new UserProfile("Otreshko", "selfie", Role.ADMIN));
            users.Add(new UserProfile("Lyubaikin", "thebest", Role.ADMIN));
            users.Add(new UserProfile("Ivanov", "siski", Role.STUDENT));

            return users;
        }
    }
}
