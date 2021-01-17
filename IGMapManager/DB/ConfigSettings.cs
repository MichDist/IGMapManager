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
        public static Boolean setGameDirPath(string pPath, string pGame)
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

            return true;
        }

        public static string getGameDirPath(string pGame)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\map_db.db";
            var connection = new SQLiteConnection(str);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT path FROM paths WHERE @pGame = game AND repo = no";
            command.Parameters.AddWithValue("@pGame", pGame);
            command.Prepare();
            command.ExecuteReader();

            return "";
        }
    }
}
