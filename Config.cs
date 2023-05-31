using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Required for MessageBox
using System.Windows.Forms;

//Data function classes
using System.Data;
using MySql.Data.MySqlClient;

namespace CTextCurrent
{
    public class Config
    {
        string ConnectionString = ""; //saving the connection string
        public MySqlConnection connection = null;
        public string server = "localhost"; //MySQL host
        public string user = "root"; //MySQL user
        public string password = "Dovydas8%"; //MySQL password
        DataSet ds;
        DataTable dt;
        public string Table = "user_info"; // Initialising database table
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempdata;

        public Config() { }

        //Function to connect to the database
        public void Connect(string database_name)
        {
            try
            {
                ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(ConnectionString);
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        //Function to execute select statements
        public void ExecuteSql(string Sql_command) { nowquiee(Sql_command); }

        //Creates connection to MySQL before execution
        public void nowquiee(string sql_comm)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConnectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        //Function to execute delete, insert and update queries
        public void Execute(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                //====This section is dedicated to catch select queries=======
                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                //============================================================
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        //Function to bring selected results based on column name and row index
        public string Results(int ROW, string COLUMN_NAME)
        {
            try { return dt.Rows[ROW][COLUMN_NAME].ToString(); }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return "";
            }
        }

        //Function to bring selected results based column index and row index
        public string Results(int ROW, int COLUMN_NAME)
        {
            try { return dt.Rows[ROW][COLUMN_NAME].ToString(); }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
        }

        //Execute select statement
        public void ExecuteSelect(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
        //Count number of rows after select
        public int Count() { return dt.Rows.Count; }
    }
}
