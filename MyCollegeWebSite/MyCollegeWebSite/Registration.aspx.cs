using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCollegeWebSite
{
    public partial class Registration : System.Web.UI.Page
    {
        DBConnector DB = new DBConnector();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[Registration]
           ([first_name]
           ,[last_name]
           ,[user_name]
           ,[email]
           ,[password]
           ,[PhoneNumber]
           ,[Address]
           ,[Batch])
     VALUES
            ('" + txt_first.Text + "','" + txt_last.Text + "','" + txt_username.Text + "','" + txt_email.Text + "','" + txt_password.Text + "'," + txt_number.Text + ",'" + txt_address.Text + "',"+txt_batch.Text+")";
            DB.ExecuteQuery(query);
            Response.Redirect("Login.aspx");

        }
    }
}