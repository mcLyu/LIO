using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class DBStub
    {
        static List<UserProfile> users = new List<UserProfile>();
        static UserProfile otreshko = new UserProfile("Otreshko", "selfie", Role.ADMIN);
        static UserProfile lyubaikin = new UserProfile("Lyubaikin", "thebest", Role.ADMIN);
        static UserProfile ivanov = new UserProfile("Ivanov", "siski", Role.STUDENT);

        static DBStub() 
        {
            Statistic statistic = new Statistic();
            statistic.addResult(new ExerciseResultInfo(new Exercise(),new DateTime(2016,1,3), 4, 3));
            statistic.addResult(new ExerciseResultInfo(new Exercise(), new DateTime(2016, 1, 2), 4, 3));
            statistic.addResult(new ExerciseResultInfo(new Exercise(), new DateTime(2016, 1, 1), 4, 3));

            users.Add(otreshko);
            users.Add(lyubaikin);
            users.Add(ivanov);
        }

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

        public static Statistic GetUserStatistic(long userId)
        {
            return lyubaikin.statistic;
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
            return users;
        }
    }
}
