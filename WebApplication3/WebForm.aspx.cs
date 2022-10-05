using Book;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=login;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.username = TextBox1.Text;
            l.password = TextBox2.Text;
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into login_table values('" + l.username + "','" + l.password + "')", c);
            cmd.ExecuteNonQuery();
            Label3.Text = "Signed up succesfully...";
            TextBox1.Text = " ";
            c.Close();
        }
    }
}