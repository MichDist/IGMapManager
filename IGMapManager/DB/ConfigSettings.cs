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
        // Refactor the whole class later: Number of methods can be reduced when repo is used as parameter
        // New methods: setPath(string pPath, string pGame, bool pRepo); getPath(...), updatePath(...)

        public static Boolean setGameDirPath(string pPath, string pGame)
        {
            if(getGameDirPath(pGame) == "")
            {
                string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
                var connection = new SQLiteConnection(str);
                connection.Open();

                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO paths(game, path, repo) VALUES (@pGame, @pPath, @pRepo)";
                command.Parameters.AddWithValue("@pGame", pGame);
                command.Parameters.AddWithValue("@pPath", pPath);
                command.Parameters.AddWithValue("@pRepo", "no");

                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                updateGameDirPath(pPath, pGame);
            }

            return true;
        }

        public static Boolean updateGameDirPath(string pPath, string pGame)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE paths SET path = @pPath WHERE game = @pGame AND repo = @pRepo";
            command.Parameters.AddWithValue("@pPath", pPath);
            command.Parameters.AddWithValue("@pGame", pGame);
            command.Parameters.AddWithValue("@pRepo", "no");

            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        public static string getGameDirPath(string pGame)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT path FROM paths WHERE game = @pGame AND repo = 'no'";
            command.Parameters.AddWithValue("@pGame", pGame);
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

        public static Boolean setRepoPath(string pPath, string pGame)
        {
            if(getRepoPath(pGame) == "")
            {
                string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
                var connection = new SQLiteConnection(str);
                connection.Open();

                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO paths(game, path, repo) VALUES (@pGame, @pPath, @pRepo)";
                command.Parameters.AddWithValue("@pGame", pGame);
                command.Parameters.AddWithValue("@pPath", pPath);
                command.Parameters.AddWithValue("@pRepo", "yes");

                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                updateRepoPath(pPath, pGame);
            }

            return true;
        }

        public static Boolean updateRepoPath(string pPath, string pGame)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE paths SET path = @pPath WHERE game = @pGame AND repo = @pRepo";
            command.Parameters.AddWithValue("@pPath", pPath);
            command.Parameters.AddWithValue("@pGame", pGame);
            command.Parameters.AddWithValue("@pRepo", "yes");

            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        public static string getRepoPath(string pGame)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT path FROM paths WHERE game = @pGame AND repo = @pRepo";
            command.Parameters.AddWithValue("@pGame", pGame);
            command.Parameters.AddWithValue("@pRepo", "yes");
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
