using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication
{
    public partial class _Default : Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GT6UN2V\\SQLEXPRESS;Initial Catalog=ProgrammingDB;Integrated Security=True"); // set connecion path
        protected void Button1_Click(object sender, EventArgs e)
        {
                
                
                con.Open();    //open connection
                SqlCommand cmd = new SqlCommand("Insert into StudentInfo_Tab values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "','" + double.Parse(TextBox3.Text) + "','" + TextBox4.Text + "')", con); //insert sql query
                cmd.ExecuteNonQuery();
                con.Close(); //close connection
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true); //alert message
                clear();
                LoadRecord();
        }

        void LoadRecord()
        {
            SqlCommand cmd = new SqlCommand("select * from StudentInfo_Tab",con);  // Load data for the grid view
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();    //open connection
            SqlCommand cmd = new SqlCommand("update StudentInfo_Tab set StudentName = '"+TextBox2.Text+"',Address = '"+DropDownList1.SelectedValue+"',Age = '"+double.Parse(TextBox3.Text)+"',Contact = '"+TextBox4.Text+"'Where StudentID = '"+int.Parse(TextBox1.Text)+"'", con); //update sql query
            cmd.ExecuteNonQuery();
            con.Close(); //close connection
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true); //alert message
            clear();
            LoadRecord();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();    //open connection
            SqlCommand cmd = new SqlCommand("Delete StudentInfo_Tab Where StudentID = '" + int.Parse(TextBox1.Text) + "'", con); //Delete sql quer
            cmd.ExecuteNonQuery();
            con.Close(); //close connection
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true); //alert message
            clear();
            LoadRecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from StudentInfo_Tab Where StudentID = '" + int.Parse(TextBox1.Text) + "'", con); // Search Data Sql Query
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentInfo_Tab Where StudentID = '" + int.Parse(TextBox1.Text) + "'", con); // Get data sql query
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                TextBox2.Text = r.GetValue(1).ToString();
                DropDownList1.SelectedValue = r.GetValue(2).ToString();
                TextBox3.Text = r.GetValue(3).ToString();
                TextBox4.Text = r.GetValue(4).ToString();
            }
        }

        public void clear()   //after click on button clean previous records
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.SelectedValue = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}