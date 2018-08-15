using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Sharia_Cooperative
{
    public partial class MemberCooperative : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void save(Object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into Member (Member_ID,Member_Name,Address,Date_Of_Birth,Gender,Work,Monthly_Income,Email,No_HP) values (@Member_ID, @Member_Name, @Address,@Date_Of_Birth,@Gender,@Work,@Monthly_Income,@Email,@No_HP)";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.Add(new SqlParameter("@Member_ID", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@Member_Name", SqlDbType.VarChar, 225));
                cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 225));
                cmd.Parameters.Add(new SqlParameter("@Date_Of_Birth", SqlDbType.VarChar, 225));
                cmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Char,1));
                cmd.Parameters.Add(new SqlParameter("@Work", SqlDbType.VarChar, 225));
                cmd.Parameters.Add(new SqlParameter("@Monthly_Income", SqlDbType.VarChar, 225));
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                cmd.Parameters.Add(new SqlParameter("@No_HP", SqlDbType.VarChar, 20));

                cmd.Parameters["@Member_ID"].Value = memberID.Text.ToString();
                cmd.Parameters["@Member_Name"].Value = memberName.Text.ToString();
                cmd.Parameters["@Address"].Value = Address.Text.ToString(); ;
                cmd.Parameters["@Date_Of_Birth"].Value = Dateof.Text.ToString(); ;
                cmd.Parameters["@Gender"].Value = Gender.Text.ToString(); ;
                cmd.Parameters["@Work"].Value = Work.Text.ToString(); ;
                cmd.Parameters["@Monthly_Income"].Value = gaji.Text.ToString(); ;
                cmd.Parameters["@Email"].Value = Email.Text.ToString(); ;
                cmd.Parameters["@No_HP"].Value = Nohp.Text.ToString();

                cmd.ExecuteNonQuery();
                conn.Close();

                Response.Write("<script>alert('Berhasil');</script>");
                Response.Write("<script>window.location='ViewMember.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}