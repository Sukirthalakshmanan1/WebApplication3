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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=login;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            disp();
        }
        public void disp()
        {
           // issue i=new issue();
            SqlCommand cmd = new SqlCommand("select * from Issue", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label1.Text = "User details..";

        }
        
    }
}