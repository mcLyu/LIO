using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MasterLIO
{
    class DBUtils
    {
        private const string dbName = @"C:\Users\Mill\Desktop\LIO\MasterLIO\MasterLIO\db\LIO_DATA.db";
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;
        

        static DBUtils()
        {
            connection = new SQLiteConnection(string.Format("Data Source={0};", dbName));
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
            List<UserProfile> profiles = new List<UserProfile>();
            connection.Open();
            command = new SQLiteCommand("INSERT INTO Exersize (max_time,max_errors,name,text,keyboard_areas,level) VALUES (@param1,@param2,@param3,@param4,@param5,@param6)", connection);
            command.Parameters.Add(new SQLiteParameter("@param1", exercise.maxTime));
            command.Parameters.Add(new SQLiteParameter("@param2", exercise.maxErrors));
            command.Parameters.Add(new SQLiteParameter("@param3", exercise.name));
            command.Parameters.Add(new SQLiteParameter("@param4", exercise.text));
            command.Parameters.Add(new SQLiteParameter("@param5", exercise.getAreasAsString()));
            command.Parameters.Add(new SQLiteParameter("@param6", exercise.level));


            command.ExecuteNonQuery();

            connection.Close();
        }

        public static List<Exercise> LoadExercises()
        {
            return null;
        }

        public static List<UserProfile> LoadAllUsers()
        {
            List<UserProfile> profiles = new List<UserProfile>();
            connection.Open();
            command = new SQLiteCommand("SELECT * FROM 'User_Profile';", connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string login = reader["login"].ToString();
                string password = reader["password"].ToString();
                string isAdmin = reader["isAdmin"].ToString();

                Role role;
                if (isAdmin == "1") role = Role.ADMIN;
                else role = Role.STUDENT;

                profiles.Add(new UserProfile(login, password, role));

            }

            connection.Close();

            return profiles;
        }
    }
}
