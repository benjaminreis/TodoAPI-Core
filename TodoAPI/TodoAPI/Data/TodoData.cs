using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using System.Data;

namespace TodoAPI.Data
{
    internal class TodoData
    {
        private Factory _Factory;

        internal TodoData(Factory factory)
        {
            _Factory = factory;
        }

        private string _sqlConn = "";


#region "Internal Methods"

        internal Models.TodoItem GetTodoItem(int ID)
        {
            var sql = "select T.id, T.Name, T.IsComplete from Todo T WHERE id=?TodoID; ";

            List<MySqlParameter> Parameters = new List<MySqlParameter>();

            MySqlCommand cmd = new MySqlCommand(sql);

            cmd.Parameters.AddWithValue("?TodoID", ID);

            var DataTable = BuildDataTable(cmd);
            //dataTable.Rows

            if (DataTable.Rows.Count > 0)
            {
                return new Models.TodoItem(DataTable.Rows[0]);
            } else {
                return null;
            }

        }


        internal List<Models.TodoItem> GetAllTodoItems()
        {
            var listTodoItems =  new List<Models.TodoItem>();

            listTodoItems = TodoMockData.AllTodoData();
            //TODO BEN implement this for realz!
            return listTodoItems;

        }

        internal Models.TodoItem SaveTodoItem(Models.TodoItem todoItem)
        {

            var sql = $"INSERT INTO Todo(Name, IsComplete) VALUES(?Name, ?IsComplete); SELECT LAST_INSERT_ID(); ";
            List<MySqlParameter> Parameters = new List<MySqlParameter>();

            MySqlCommand cmd = new MySqlCommand(sql);

            cmd.Parameters.AddWithValue("?Name", todoItem.Name);
            cmd.Parameters.AddWithValue("?IsComplete", todoItem.IsComplete);

            var DataTable = BuildDataTable(cmd);
            var obj = DataTable.Rows[0]["LAST_INSERT_ID()"];

            todoItem.Id = int.Parse((DataTable.Rows[0]["LAST_INSERT_ID()"] != null ? DataTable.Rows[0]["LAST_INSERT_ID()"].ToString() : ""));

            if (todoItem.Id <= 0)
            {
                todoItem.Success = false;
            }

            else
            {
              //TODO BEN ideally wed do a "getone" to get the one i just added to the database.
            }

            return todoItem;
        }



        //internal string AddVolunteer(DataModels.Volunteer volunteer)
        //{
        //    var sql = $"INSERT INTO Volunteers(FirstName, LastName, roleId) VALUES(?firstname, ?lastname, ?roleid); SELECT LAST_INSERT_ID(); ";
        //    List<MySqlParameter> Parameters = new List<MySqlParameter>();

        //    MySqlCommand cmd = new MySqlCommand(sql);

        //    cmd.Parameters.AddWithValue("?firstname", volunteer.FirstName);
        //    cmd.Parameters.AddWithValue("?lastname", volunteer.LastName);
        //    cmd.Parameters.AddWithValue("?roleid", volunteer.RoleID);

        //    var DataTable = BuildDataTable(cmd);
        //    var obj = DataTable.Rows[0]["LAST_INSERT_ID()"];
        //    if (obj != null)
        //    {
        //        return obj.ToString();
        //    }

        //    return "Error";
        //}

        #endregion


        #region "Private Methods"

        private DataTable BuildDataTable(MySqlCommand cmd)
        {
            MySqlConnection conn = new MySqlConnection(_sqlConn);

            conn.Open();  //TODO BEN add a using statement

            cmd.Connection = conn;
            MySqlDataReader rdr = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(rdr);
            conn.Close();

            return dataTable;
        }

        #endregion
    }
}
