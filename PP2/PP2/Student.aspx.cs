using System;
using System.Configuration;
using System.Data.SqlClient;

namespace PP2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string connectionString = ConfigurationManager.ConnectionStrings["RainbowSchoolConnectionString"].ConnectionString;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                
                string insertQuery = "INSERT INTO Student (StudentID, StudentName, StudentClass) VALUES (@StudentID, @StudentName, @StudentClass)";

                
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", int.Parse(TextBox1.Text));
                    command.Parameters.AddWithValue("@StudentName", TextBox2.Text);
                    command.Parameters.AddWithValue("@StudentClass", int.Parse(TextBox3.Text));

                    // Execute the INSERT statement
                    command.ExecuteNonQuery();
                }

                // Close the connection
                connection.Close();
            }
        }
    }
  }