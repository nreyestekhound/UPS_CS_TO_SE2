using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UPS.Shipper.ToShipExecFromConnectShip.Entities;

namespace UPS.Shipper.ToShipExecFromConnectShip
{
    public class SQL_Commands
    {
        public SqlConnection conn;
        public SqlConnection conn2;

        public SQL_Commands(SqlConnection conn)
        {
            this.conn = conn;
        }

        public DataTable Select(string storedProcedureorCommandText, bool isStoredProcedure = true)
        {
            DataTable dataTable = new DataTable();
            
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                if (!isStoredProcedure)
                {
                    command.CommandType = CommandType.Text;
                }
                command.CommandText = storedProcedureorCommandText;
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            
        }

        public void Exec(string storedProcedureorCommandText)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                command.CommandType = CommandType.Text;                
                command.CommandText = storedProcedureorCommandText;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        public IEnumerable<T> ExcuteObject<T>(string storedProcedureorCommandText, bool isStoredProcedure = true)
        {
            List<T> items = new List<T>();
            var dataTable = Select(storedProcedureorCommandText, isStoredProcedure); 
            foreach (var row in dataTable.Rows)
            {
                T item = (T)Activator.CreateInstance(typeof(T), row);
                items.Add(item);
            }
            return items;
        }

        public bool IsServerConnected()
        {            
            try
            {
                conn.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            
        }

    }
}
