using System;
using System.Configuration;
using System.Data.SqlClient;

namespace PP2
{
    public partial class Teacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Get the connection string from the Web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["RainbowSchoolConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create an SQL INSERT statement to add data to the Teacher table
                string insertQuery = "INSERT INTO Teacher (TeacherId, TeacherName, TeacherSubject) VALUES (@TeacherId, @TeacherName, @TeacherSubject)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@TeacherId", int.Parse(TextBox1.Text));
                    command.Parameters.AddWithValue("@TeacherName", TextBox2.Text);
                    command.Parameters.AddWithValue("@TeacherSubject", int.Parse(TextBox3.Text));

                    // Execute the INSERT statement
                    command.ExecuteNonQuery();
                }

                // Close the connection
                connection.Close();
            }
        }
    }
}
