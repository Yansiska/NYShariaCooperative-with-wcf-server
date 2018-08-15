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
    public partial class Simpan : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save(Object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into dbo.Simpan (ID_Simpan,Member_ID,Member_Name,Pembayaran_Perbulan) values (@ID_Simpan,@Member_ID, @Member_Name,@Pembayaran_Perbulan)";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.Add(new SqlParameter("@ID_Simpan", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@Member_ID", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@Member_Name", SqlDbType.VarChar, 255));
                cmd.Parameters.Add(new SqlParameter("@Pembayaran_Perbulan", SqlDbType.Int));

                cmd.Parameters["@ID_Simpan"].Value = simpanID.Text.ToString();
                cmd.Parameters["@Member_ID"].Value = memberId.Text.ToString();
                cmd.Parameters["@Member_Name"].Value = memberN.Text.ToString();
                cmd.Parameters["@Pembayaran_Perbulan"].Value = bayarBln.Text.ToString();

                cmd.ExecuteNonQuery();
                conn.Close();

                Response.Write("<script>alert('Berhasil');</script>");
                Response.Write("<script>window.location='ViewSimpan.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}