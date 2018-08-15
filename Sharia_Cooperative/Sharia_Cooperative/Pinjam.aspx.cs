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
    public partial class Pinjam : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save(Object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into Pinjam (ID_Pinjam,Member_ID,Member_Name,Jumlah_Pinjam,Jangka_Pinjam,Angsuran) values (@ID_Pinjam,@Member_ID, @Member_Name, @Jumlah_Pinjam,@Jangka_Pinjam,@Angsuran)";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.Add(new SqlParameter("@ID_Pinjam", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@Member_ID", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@Member_Name", SqlDbType.VarChar, 255));
                cmd.Parameters.Add(new SqlParameter("@Jumlah_Pinjam", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Jangka_Pinjam", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Angsuran", SqlDbType.Int));

                cmd.Parameters["@ID_Pinjam"].Value = pinjamID.Text.ToString();
                cmd.Parameters["@Member_ID"].Value = memberId.Text.ToString();
                cmd.Parameters["@Member_Name"].Value = memberN.Text.ToString();
                cmd.Parameters["@Jumlah_Pinjam"].Value = jumlahP.Text.ToString(); ;
                cmd.Parameters["@Jangka_Pinjam"].Value = JangkaP.Text.ToString(); ;
                cmd.Parameters["@Angsuran"].Value = Angsuran.Text.ToString();

                cmd.ExecuteNonQuery();
                conn.Close();

                Response.Write("<script>alert('Berhasil');</script>");
                Response.Write("<script>window.location='View.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}