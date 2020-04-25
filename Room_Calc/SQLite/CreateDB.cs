using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Room_Calc.SQLite
{
    public class CreateDB
    {
        string connectionString;
        public CreateDB(string dbName)
        {
            this.connectionString = ConnectionManager.GetSQLiteDBPath(dbName);
        }

        public void Initialize(string dbName)
        {
            try
            {
                ConnectionManager.RunScript(db =>
                {
                    var schemaProvider = db.DataProvider.GetSchemaProvider();

                    var schema = schemaProvider.GetSchema(db);
                    if (!schema.Tables.Exists(item => item.TableName == "Material"))
                    {
                        db.CreateTable<Material>(tableName: "Material");
                    }
                    if (!schema.Tables.Exists(item => item.TableName == "Color"))
                    {
                        db.CreateTable<Color>(tableName: "Color");
                    }
                }, dbName);
            }
            catch { }
        }
    }
}