using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Book;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=login;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
           Label1.Text = "Welcome " + Session["userid"].ToString();
            disp();
        }
        public void disp()
        {
            SqlCommand cmd = new SqlCommand("select * from Book", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label2.Text = "List of books displayed..";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            Bk b = new Bk();
           b.Bookid= Convert.ToInt32(TextBox1.Text);
           // b.BookName = TextBox2.Text;
            SqlCommand cmd = new SqlCommand("select * from Book where Product_id=' " + b.Bookid + "'", c);


            /*SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);*/
            
            Label5.Text = "Book found ..";
            disp();
          //  Response.Redirect("~/WebForm3");

           
        }
       
        protected void Button2_Click1(object sender, EventArgs e)
        {
            login l = new login();
            Bk b = new Bk();
            issue i = new issue();

            Label4.Text = Calendar4.SelectedDate.ToLongDateString();
            TextBox4.Text = Calendar3.SelectedDate.ToLongDateString();
            i.id = Convert.ToInt32(TextBox5.Text);
            b.Bookid = Convert.ToInt32(TextBox1.Text);
            l.username = Session["userid"].ToString();
            i.Issuedate = Label4.Text;
            i.return_date = TextBox4.Text;

            c.Open();
            SqlCommand cmd = new SqlCommand("insert into Issue values('" + i.id + "','" + l.username + "','" + b.Bookid + "','" + i.Issuedate + "','" + i.return_date + "')", c);
            cmd.ExecuteNonQuery();
            Label8.Text = " Inserted succesfully...";
            // TextBox1.Text = " ";
            // TextBox2.Text = " ";
            // TextBox3.Text = " ";

            c.Close();
            Response.Redirect("~/WebForm3.aspx");

        }
        
    }
}