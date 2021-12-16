using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAS
{

    class msSQL
    {
        public SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = JAS;");
        public SqlCommand command = new SqlCommand();
        public SqlDataAdapter adapter;

        public msSQL()
        {
            command.Connection = connection;
        }

        public void sqlIslem(String sql)
        {
            command.CommandText = sql;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public String sqlString(String sql)
        {
            command.CommandText = sql;
            connection.Open();
            sql = command.ExecuteScalar().ToString();
            connection.Close();
            return sql;
        }

        public DataTable sqlTablo(String sql)
        {
            DataTable tablo = new DataTable();
            command.CommandText = sql;
            connection.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(tablo);
            connection.Close();
            return tablo;
        }

    }
}
