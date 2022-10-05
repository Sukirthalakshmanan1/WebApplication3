using Book;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=login;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* login l = new login();
             l.username = TextBox1.Text;
             l.password = TextBox2.Text;
             c.Open();
             SqlCommand cmd = new SqlCommand("insert into login_table values('" + l.username + "','" + l.password + "')", c);
             cmd.ExecuteNonQuery();
             Label3.Text = "Logged in succesfully...";
             TextBox1.Text = " ";
             c.Close();*/
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", TextBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text.ToString());
                cmd.Connection = c;
                c.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Session["UserId"] = TextBox1.Text.ToString();
                    Label3.Text = "Login Successful!";

                    reader.Close();
                    c.Close();

                    Response.Redirect("~/WebForm2.aspx");
                }
                else
                {
                    Label3.Text = "Invalid credentials";
                }

                reader.Close();

                c.Close();

            }
            catch (Exception ex)
            {

            }

        }
    }
}