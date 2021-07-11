using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MyCollegeWebSite
{
    public partial class Login : System.Web.UI.Page
    {
        DBConnector DB = new DBConnector();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = @"select * FROM Registration WHERE user_name='" + txt_username.Text + "' AND password='" + txt_password.Text + "'";
            DataTable table = DB.getTable(query);
            Session["USERNAME"] = txt_username.Text;
            if (table.Rows.Count != 0)
            {
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                Label1.Text = "Invalid username or password!";
            }

        }

        protected void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}