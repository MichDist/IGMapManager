using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGMapManager.DB
{
    public class ConfigSettings
    {
        public static Boolean setGameDirPath(string pPath, string pGame)
        {
            string str = @"Data Source=C:\Projekte\IGMapManager\test.db";
            var connection = new SqliteConnection(str);

            connection.Open();

            return true;
        }

        public static string getGameDirPath(string pGame)
        {


            return "";
        }
    }
}
