﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IGMapManager.DB
{
    class DatabaseSetup
    {
        public static Boolean createDatabase()
        {
            if(!File.Exists("C:/Projekte/IGMapManager/map_db.db"))
            {
                var connection = new SQLiteConnection(@"Data Source=C:\Projekte\IGMapManager\map_db.db");
                connection.Open();

                createPathTable(connection);
                createProfileTable(connection);

                connection.Close();
            }

            return true;
        }

        public static Boolean createPathTable(SQLiteConnection pConnection)
        {
            var command = new SQLiteCommand(pConnection);
            command.CommandText = "CREATE TABLE paths (game TEXT, path TEXT, repo TEXT)";
            command.Prepare();
            command.ExecuteNonQuery();

            return true;
        }

        public static Boolean createProfileTable(SQLiteConnection pConnection)
        {
            var command = new SQLiteCommand(pConnection);
            command.CommandText = "CREATE TABLE profiles (name TEXT)";
            command.Prepare();
            command.ExecuteNonQuery();

            return true;
        }
    }
}
