using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClassLibraryDB
{
    public class FormOutput
    {
        public string connectionStr { get; private set; }
        public SqlConnection sqlConnection { get; private set; }

        public FormOutput(string address, string DBname, string username, string password)
        {
            try
            {
                connectionStr = "Server=" + address +
                    ";Database=" + DBname +
                    ";User ID=" + username +
                    ";Password=" + password +
                    //";Trusted_Connection=true" +
                    ";Integrated Security=SSPI;";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            sqlConnection = new SqlConnection(connectionStr);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void OutputAllToDg(string DBname, string table, DataGridView dg)
        {
            string query = $"SELECT * FROM {table}";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                dg.Rows.Add(s);
        }
    }
}
