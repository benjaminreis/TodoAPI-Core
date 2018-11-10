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

            //TODO 
            return todoItem
        }


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
