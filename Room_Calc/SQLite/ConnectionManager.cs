using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Room_Calc.SQLite
{
    public class ConnectionManager
    {
        public static void RunScript(Action<DataConnection> dbWork, string dbName)
        {
            using (var db = LinqToDB.DataProvider.SQLite.SQLiteTools.CreateDataConnection(GetSQLiteDBPath(dbName)))
            {
                dbWork(db);
            }
        }

        public static string GetSQLiteDBPath(string dbName)
        {
            var AppDataFolder = Path.Combine(HttpContext.Current.Server.MapPath("~/App_Data"));
            string RoomSQLites_DB = Path.Combine(AppDataFolder, "RoomSQLites_DB");
            if (!Directory.Exists(RoomSQLites_DB))
                Directory.CreateDirectory(RoomSQLites_DB);
            return $"Data Source = \"{Path.Combine(RoomSQLites_DB, dbName + ".db")}\"";
        }
    }
}