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
    public partial class UpdateSimpan : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ID_Simpan = this.Request["ID_Simpan"];
                getID(ID_Simpan);
            }
        }
        protected void getID(string ID_Simpan)
        {
            string sql = "Select * from Simpan where ID_Simpan = @ID_Simpan";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ID_Simpan", SqlDbType.VarChar, 10).Value = ID_Simpan;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                TextBox1.Text = dr["Member_ID"].ToString();
                TextBox2.Text = dr["Member_Name"].ToString();
                TextBox3.Text = dr["Pembayaran_Perbulan"].ToString();
                conn.Close();
            }
            catch (Exception e)
            {
                Response.Write("<script>alert('" + e.Message + "'); </script>");
            }


        }
        protected void update(Object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Simpan SET Member_ID = @Member_ID, Member_Name = @Member_Name, Pembayaran_Perbulan = @Pembayaran_Perbulan WHERE ID_Simpan = ID_Simpan";
            SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                string ID_Simpan = this.Request["ID_Simpan"];
                cmd.Parameters.Add("@ID_Simpan", SqlDbType.VarChar, 10).Value = ID_Simpan;
                cmd.Parameters.Add("@Member_ID", SqlDbType.VarChar, 10).Value =
               TextBox1.Text;
                cmd.Parameters.Add("@Member_Name", SqlDbType.VarChar, 225).Value = TextBox2.Text;
                cmd.Parameters.Add("@Pembayaran_Perbulan", SqlDbType.Int).Value =
               TextBox3.Text.ToString();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Berhasil');</script>");
                Response.Write("<script>window.location = 'ViewSimpan.aspx'</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }
    }
}