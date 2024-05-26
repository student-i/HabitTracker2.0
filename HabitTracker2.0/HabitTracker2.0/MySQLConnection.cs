using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HabitTracker2._0
{
    public class MySQLConnection
    {

        private MySqlConnection cnx;

        public bool connect(string user, string password, string server)
        {
            user = "root";
            password = "1234home5678";
            server = "localhost";
                try
                {
                    string credentials = $"server={server};user={user};database=habittrackerdb;port=3306;password={password}";
                    cnx = new MySqlConnection(credentials);
                    cnx.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
        }

        public bool stopConnection()
        {
            cnx.Close();
            return true;
        }

        public int calculatePoints()
        {
            int total = 0;
            string sql = "SELECT instance_points FROM instance;";

            try
            {

            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string p = rdr[0].ToString();
                total += int.Parse(p);
            }
            rdr.Close();
            return total;
            }
            catch
            {
                return 0;
            }
        }

        public bool newHabit(string name, string points)
        {
            try
            {

            string create = $"INSERT INTO habit (habit_id, habit_name, habit_points_per_instance) VALUES (default, '{name}', {points});";
            MySqlCommand cmd = new MySqlCommand(create, cnx);
            cmd.ExecuteNonQuery();
            return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> getHabits()
        {
            List<string> habits = new List<string>();
            try
            {
                string gethabits = "SELECT habit_name FROM habit;";
                MySqlCommand cmd = new MySqlCommand(gethabits, cnx);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    habits.Add(rdr[0].ToString());
                }
                rdr.Close();
            }
            catch
            {
                habits.Add("There are no habits!");
            }
            return habits;
        }

        public List<string> filterInstances(string value) 
        {
            List<string> instances = new List<string>();
            instances.Add("DATE   HABIT   POINTS");
            string instanceSQL;
            try
            {

                if (value == "all")
                {
                    instanceSQL = "SELECT instance_date, habit_name, instance_points FROM habit h INNER JOIN instance i ON i.habit_id = h.habit_id; ";
                }
                else
                {
                    instanceSQL = $"SELECT instance_date, habit_name, instance_points FROM habit h INNER JOIN instance i ON i.habit_id = h.habit_id WHERE habit_name = '{value}'; ";
                
                }
                MySqlCommand cmd = new MySqlCommand(instanceSQL, cnx);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string date = DateTime.Parse(rdr[0].ToString()).ToString("MMM, d, yyyy");
                    instances.Add($"{date} - {rdr[1].ToString()} - {rdr[2].ToString()}");
                }
                rdr.Close();
            }
            catch 
            {
                instances.Add("Unable to retrieve");
            }
            return instances;
        }

        public bool record(string habit, string date)
        {
            string points = "a";
            string habitID = "a";

            try
            {

                string retrevieSql = $"SELECT habit_points_per_instance, habit_id FROM habit WHERE habit_name = '{habit}';";

                MySqlCommand cmd = new MySqlCommand(retrevieSql, cnx);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    points = r[0].ToString();
                    habitID = r[1].ToString();
                }
                r.Close();

                string recordSql = $"INSERT INTO instance (instance_id, instance_date, instance_points, habit_id) VALUES (default, '{date}', {points}, {habitID}); ";

                cmd = new MySqlCommand(recordSql, cnx);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
