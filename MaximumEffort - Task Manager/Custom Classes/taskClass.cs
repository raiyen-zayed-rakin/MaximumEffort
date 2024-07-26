using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaximumEffort___Task_Manager.Custom_Classes
{
    internal class taskClass
    {
        //getter setter properties
        //acts as Data Carrier in Our application

        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            //step 1 Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //step2 - writing SQL query
                string sql = "SELECT ALL FROM tbl_maximumeffort";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);
                //creating SQL DataAdapter???? using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception e) 
            { 
            
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //insert 
        public bool Insert(taskClass t)
        {
            //creating a default type and setting it to false
            bool success = false;
            //1, connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step2 - writing SQL query to insert
                string sql = "INSERT INTO tbl_maximumeffort (TaskName,Description, Date, Status) VALUES(@TaskName,@Description, @Date, @Status)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TaskName", t.TaskName);
                cmd.Parameters.AddWithValue("@Description", t.Description);
                cmd.Parameters.AddWithValue("@Date", t.Date);
                cmd.Parameters.AddWithValue("@Status", t.Status);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    success = true;     
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return success;
        }
    }
}
