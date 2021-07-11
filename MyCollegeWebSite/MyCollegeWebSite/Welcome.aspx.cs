using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCollegeWebSite
{
    public partial class Welcome : System.Web.UI.Page
    {
        DBConnector DB = new DBConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                lbluser.Text = "Welcome " + Session["USERNAME"].ToString();
                showTable();
            }
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session["USERNAME"] = null;
            Response.Redirect("FrontPage.aspx");
        }
        public void showTable()
        {
            string query = @"SELECT [first_name]
      ,[last_name]
      ,[email]
      ,[password]
      ,[PhoneNumber]
      ,[Address]
      ,[Batch]
  FROM [dbo].[Registration]";
            GridView1.DataSource = DB.getTable(query);
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            showTable();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            showTable();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            showTable();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblnumber = (Label)GridView1.Rows[e.RowIndex].FindControl("lblnumber");
            TextBox txt_first = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_first");
            TextBox txt_last = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_last");
            //TextBox txt_PhoneNumber = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_PhoneNumber");
            TextBox txt_email = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_email");
            TextBox txt_address = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_address");
            TextBox txt_batch = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_batch");

            string query = @"UPDATE [dbo].[Registration]  SET [first_name] = '" + txt_first.Text + "' ,[last_name] = '" + txt_last.Text + "' ,[email] = '" + txt_email.Text + "' ,[Address] ='" + txt_address.Text + "' ,[Batch] = " + txt_batch.Text + " WHERE [PhoneNumber]='" + lblnumber.Text + "'";
            if(DB.ExecuteQuery(query)==1)
            {
                GridView1.EditIndex = -1;
                showTable();
            }



        }

        protected void btndelete_Click(object sender, EventArgs e)
        {

            string query = @"Delete FROM [dbo].[Registration]";
            DBConnector DB = new DBConnector();
            DB.ExecuteQuery(query);
            if (DB.ExecuteQuery(query) == 1)
            {
                GridView1.DataSource = DB.getTable(query);
                GridView1.DataBind();
            }

        }
    }
}