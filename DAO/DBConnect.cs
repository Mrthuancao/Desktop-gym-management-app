using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAO
{
    class DBConnect
    {
        private SqlConnection connection;
        public DBConnect()
        {
            //DESKTOP-2PMMREO
            connection = new SqlConnection("Data Source=MAY01;Initial Catalog=Gym_Management;Integrated Security=True");

        }

        public DataTable ExecuteQuery(string query, object[] parameterValue = null)
        {
            DataTable dt = new DataTable();
            Open();
            //Tách tên parameter từ query
            Regex regex = new Regex("@[a-z]+", RegexOptions.IgnoreCase);
            MatchCollection m = regex.Matches(query);
            List<string> parameterName = new List<string>();
            for (int i = 0; i < m.Count; i++)
            {
                parameterName.Add(m[i].Value);
            }
            SqlCommand command = new SqlCommand(query, connection);
            //Gán tên và value của parameter vào command
            for (int i = 0; i < parameterName.Count; i++)
            {
                command.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            Close();
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameterValue = null)
        {
            int result;
            Open();
            //Tách tên parameter từ query
            Regex regex = new Regex("@[a-z]+", RegexOptions.IgnoreCase);
            MatchCollection m = regex.Matches(query);
            List<string> parameterName = new List<string>();
            for (int i = 0; i < m.Count; i++)
            {
                parameterName.Add(m[i].Value);
            }

            SqlCommand command = new SqlCommand(query, connection);
            //Gán tên và value của parameter vào command
            for (int i = 0; i < parameterName.Count; i++)
            {
                command.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
            }
            result = command.ExecuteNonQuery();
            Close();
            return result;
        }

        public object ExecuteScalar(string query, object[] parameterValue = null)
        {
            object result;
            //int result;
            Open();
            //Tách tên parameter từ query
            Regex regex = new Regex("@[a-z]+", RegexOptions.IgnoreCase);
            MatchCollection m = regex.Matches(query);
            List<string> parameterName = new List<string>();
            for (int i = 0; i < m.Count; i++)
            {
                parameterName.Add(m[i].Value);
            }
            SqlCommand command = new SqlCommand(query, connection);
            //Gán tên và value của parameter vào command
            for (int i = 0; i < parameterName.Count; i++)
            {
                command.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
            }
            result = (command.ExecuteScalar());
            Close();
            return result;
        }

        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
