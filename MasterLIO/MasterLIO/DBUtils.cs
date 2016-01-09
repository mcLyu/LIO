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


        public static UserProfile GetUserById(int userId)
        {
            return null;
        }

        private static string generateExerciseID(Exercise exercise)
        {
            //connection.Open();
            command = new SQLiteCommand("SELECT * FROM 'Exercise' WHERE level = @param1 ORDER BY exercise_id DESC;", connection);
            command.Parameters.Add(new SQLiteParameter("@param1", exercise.level)); ;

            reader = command.ExecuteReader();
            string exercise_id = "";

            if (reader.Read())
            {
                exercise_id = reader["exercise_id"].ToString();
                int lastId = Convert.ToInt32(exercise_id.Substring(1));
                lastId++;

                exercise_id = exercise.level.ToString() + lastId.ToString();
            }
            else exercise_id = exercise.level.ToString() + "1";

            

            //connection.Close();

            return exercise_id;
        }

        public static void SaveExercise(Exercise exercise)
        {
            connection.Open();
            string exercise_id = generateExerciseID(exercise);



            command = new SQLiteCommand("INSERT INTO Exercise (max_time,max_errors,name,text,keyboard_areas,level,exercise_id) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7)", connection);
            command.Parameters.Add(new SQLiteParameter("@param1", exercise.maxTime));
            command.Parameters.Add(new SQLiteParameter("@param2", exercise.maxErrors));
            command.Parameters.Add(new SQLiteParameter("@param3", exercise.name));
            command.Parameters.Add(new SQLiteParameter("@param4", exercise.text));
            command.Parameters.Add(new SQLiteParameter("@param5", exercise.getAreasAsString()));
            command.Parameters.Add(new SQLiteParameter("@param6", exercise.level));
            command.Parameters.Add(new SQLiteParameter("@param7", exercise_id));


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

        public static Statistic GetUserStatistic(int userId)
        {
            Statistic statistic;
            connection.Open();
            command = new SQLiteCommand("SELECT * FROM 'Statistic' WHERE user_id = @param1;", connection);
            command.Parameters.Add(new SQLiteParameter("@param1", userId));
            reader = command.ExecuteReader();

            List<ExerciseResultInfo> results = new List<ExerciseResultInfo>();
            ExerciseResultInfo resultInfo;
            while (reader.Read())
            {
                int level = Convert.ToInt32(reader["level"]);
                int exerciseId = Convert.ToInt32(reader["exercise_id"]);
                int assesment = Convert.ToInt32(reader["assesment"]);
                DateTime dateOfPassing = Convert.ToDateTime(reader["dateOfPass"]);
                int speed = Convert.ToInt32(reader["speed"]);
                int errors = Convert.ToInt32(reader["errors"]);
                resultInfo = new ExerciseResultInfo(exerciseId, dateOfPassing, errors, assesment, speed, level);
                results.Add(resultInfo);
            }

            statistic = new Statistic(userId, results);
            connection.Close();

            return statistic;
        }

        public static void saveUserStatictis(Statistic statistic)
        {

            connection.Open();
            command = new SQLiteCommand("INSERT INTO 'Statistic' (level,exercise_id,assesment,dateOfPass,speed,user_id,errors) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7)", connection);
            
            List<ExerciseResultInfo> resultsInfo = statistic.getResultsInfo();
            foreach(ExerciseResultInfo resultInfo in resultsInfo)
            {            
                command.Parameters.Add(new SQLiteParameter("@param1", resultInfo.level));
                command.Parameters.Add(new SQLiteParameter("@param2", resultInfo.exerciseId));
                command.Parameters.Add(new SQLiteParameter("@param3", resultInfo.assesment));
                command.Parameters.Add(new SQLiteParameter("@param4", resultInfo.dateOfPassing));
                command.Parameters.Add(new SQLiteParameter("@param5", resultInfo.speed));
                command.Parameters.Add(new SQLiteParameter("@param6", statistic.userId));
                command.Parameters.Add(new SQLiteParameter("@param7", resultInfo.errorsCount));
            }

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
