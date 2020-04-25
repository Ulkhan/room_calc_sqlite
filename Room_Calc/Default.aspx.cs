using Room_Calc.SQLite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Room_Calc
{

    public partial class Default : System.Web.UI.Page
    {
        
        string dbName = "RoomCalc";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                new CreateDB(dbName).Initialize(dbName);
                LoadMaterial();
                LoadColor();
            }
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            IRoomSetResponse manager = new RoomSet();
            Room room = new Room();
            room.width = float.Parse(id_length.Value);
            room.length = float.Parse(id_width.Value);
            room.type = id_material.Value;
            room.tPrice = float.Parse(id_material_cost.Value);
            room.color = id_color.Value;
            room.colorPrice = float.Parse(id_color_cost.Value);
            room.employees = int.Parse(id_employees.Value);
            room.empSalary = float.Parse(id_salary.Value);
            Response.Redirect(manager.GetRoom(room));
        }

        private void LoadMaterial()
        {
            string connectionString = ConnectionManager.GetSQLiteDBPath(dbName);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Material";
                var command = new SQLiteCommand(query, connection);
                var reader = command.ExecuteReader();
                Dictionary<int, string> materialList = new Dictionary<int, string>();
                while (reader.Read())
                {
                    materialList.Add(int.Parse(reader["Id"].ToString()), reader["Option"].ToString());
                }
                id_material.DataSource = materialList.Values;
                id_material.DataBind();
                
                reader.Close();
            }
        }

        private void LoadColor()
        {
            string connectionString = ConnectionManager.GetSQLiteDBPath(dbName);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Color";
                var command = new SQLiteCommand(query, connection);
                var reader = command.ExecuteReader();
                Dictionary<int, string> color = new Dictionary<int, string>();
                while (reader.Read())
                {
                    color.Add(int.Parse(reader["Id"].ToString()), reader["Option"].ToString());
                }
                id_color.DataSource = color.Values;
                id_color.DataBind();

                reader.Close();
            }
        }
    }
}
