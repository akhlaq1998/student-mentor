using System;
using BHWDI6.mentorclasses;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BHWDI6.mentorclasses
{
    class MentorClass
    {
        //Getter Setter Properties
        //Acts as data carriers
        public int MentorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Major { get; set; }
        public string BIO { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
       
        public DataTable Select()
        {
            //step 1 :database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //step2 sql querry
                string sql = "SELECT * FROM tbl_mentors";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                



            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //inserting data into database
        public bool Insert(MentorClass c)
        {

            //creating a default return type and setting its value to false
            bool isSuccesss = false;
            //step 1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //step2;creat a sql queery to insert adata
                string sql = "INSERT INTO tbl_mentors (Name,Email,BIO,Major) VALUES (@Name,@Email,@BIO,@Major)";
                //CREATING sql cOMMAND USING sQL AND CONN
                SqlCommand cmd = new SqlCommand(sql, conn); 
                //creating parameters to add daata
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Major", c.Major);
                cmd.Parameters.AddWithValue("@BIO", c.BIO);

                //Connection open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the querry runs sucessfully then the value of rows will be greater tahn zero else value will be zero
                if (rows>0)
                {
                    isSuccesss = true;
                }
                else 
                {
                    isSuccesss = false; 
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return isSuccesss;




        }
        //Method to update data in database of our appplication
        public bool Update(MentorClass c)
        {
            //create a default return type and set a default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql TO UPDTE DATA IN OUR DATABASE
                string sql = "UPDATE tbl_mentors SET Name=@Name, Email=@Email, Major=@Major, BIO=@BIO WHERE MentorID=@MentorID";


                //Creating SQL COMMAND TO INSERT DATA
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating Parameters to add value

                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Major", c.Major);
                cmd.Parameters.AddWithValue("@BIO", c.BIO);
                cmd.Parameters.AddWithValue("@MentorID", c.MentorID);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs sucessfully the value of rows will be grater then zero else its value will be zero
                if (rows>0)

                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to delete Data from a database
        public bool Delete(MentorClass c)
        {
            //Create a default return value and its value to false
            bool isSuccess = false;
            //create Sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql to dell data
                string sql = "DELETE FROM table_mentors WHERE MentorID=@MentorID";

                //cREATING SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MentorID", c.MentorID);
                //OPEN Connection

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query run sucessfully the value of rows will be grater than zero
                if (rows>0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;

                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            
        return isSuccess;
            }
}
}
