using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGMapManager.DB
{
    public class ConfigSettings
    {
        public static Boolean setPath(string pPath, string pGame, string pRepo)
        {
            if (getPath(pGame, pRepo) == "")
            {
                string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
                var connection = new SQLiteConnection(str);
                connection.Open();

                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO paths(game, path, repo) VALUES (@pGame, @pPath, @pRepo)";
                command.Parameters.AddWithValue("@pGame", pGame);
                command.Parameters.AddWithValue("@pPath", pPath);
                command.Parameters.AddWithValue("@pRepo", pRepo);

                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                updatePath(pPath, pGame, pRepo);
            }

            return true;
        }

        public static Boolean updatePath(string pPath, string pGame, string pRepo)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE paths SET path = @pPath WHERE game = @pGame AND repo = @pRepo";
            command.Parameters.AddWithValue("@pPath", pPath);
            command.Parameters.AddWithValue("@pGame", pGame);
            command.Parameters.AddWithValue("@pRepo", pRepo);

            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        public static string getPath(string pGame, string pRepo)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT path FROM paths WHERE game = @pGame AND repo = @pRepo";
            command.Parameters.AddWithValue("@pGame", pGame);
            command.Parameters.AddWithValue("@pRepo", pRepo);
            command.Prepare();

            SQLiteDataReader reader = command.ExecuteReader();
            string result = "";
            // Read result                                  
            while (reader.Read())
            {
                result = reader.GetString(0);
            }
            reader.Close();
            connection.Close();

            return result;
        }

        public static Boolean setProfile(string pProfileName)
        {
            if (getProfile() == "")
            {
                string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
                var connection = new SQLiteConnection(str);
                connection.Open();

                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO profiles(name) VALUES (@pProfileName)";
                command.Parameters.AddWithValue("@pProfileName", pProfileName);

                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                updateProfile(pProfileName);
            }

            return true;
        }

        public static Boolean updateProfile(string pProfileName)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE profiles SET name = @pProfileName";
            command.Parameters.AddWithValue("@pProfileName", pProfileName);

            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        public static string getProfile()
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT name FROM profiles";
            command.Prepare();

            SQLiteDataReader reader = command.ExecuteReader();
            string result = "";
            // Read result                                  
            while (reader.Read())
            {
                result = reader.GetString(0);
            }
            reader.Close();
            connection.Close();

            return result;
        }
    }
}
