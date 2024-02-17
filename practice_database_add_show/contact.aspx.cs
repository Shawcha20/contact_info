using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_database_add_show
{
    public partial class contact : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into contact_info (Roll,Name, Email,Message) values ( @Roll, @Name, @Email, @Message) ", con);
                cmd.Parameters.AddWithValue("@Roll", Roll_textbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", Name_textbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", Email_textbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Message", Message_textbox.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script> alert('Successfully Added!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('Exception " + ex.Message + "') </script>");
            }

        }
    }
}