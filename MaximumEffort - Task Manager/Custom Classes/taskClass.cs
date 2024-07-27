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
                string sql = "SELECT * FROM tbl_maximumeffort";
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
        //Update the data in database
        public bool Update(taskClass t)
        {
            // create a default bool
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step2 - writing SQL query to insert
                string sql = "UPDATE tbl_maximumeffort SET TaskName = @TaskName, Description = @Description, Date = @Date, Status = @Status WHERE TaskID = @TaskID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@TaskID", t.TaskID);
                cmd.Parameters.AddWithValue("@TaskName", t.TaskName);
                cmd.Parameters.AddWithValue("@Description", t.Description);
                cmd.Parameters.AddWithValue("@Date", t.Date);
                cmd.Parameters.AddWithValue("@Status", t.Status);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //MessageBox.Show(rows.ToString());
                if (rows > 0)
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

                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        //Method to Delete data in database in our Application
        public bool Delete(taskClass t)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //step 1 - Connect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL to delete data in our Database
                string sql = "DELETE FROM tbl_maximumeffort WHERE TaskID = @TaskID";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TaskID", t.TaskID);

                //Connection Open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close Connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
