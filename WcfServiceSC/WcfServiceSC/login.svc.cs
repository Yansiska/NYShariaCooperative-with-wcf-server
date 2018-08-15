using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "login" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select login.svc or login.svc.cs at the Solution Explorer and start debugging.
    public class login : Ilogin
    {
        public int login_member(string username, string password)
        {
            string connectionString = "SERVER=ACER\\YANSISKASQL; DATABASE=System_Sharia; integrated security = true;";
            int i = 0;
            string str = "Select * from Member where Member_ID = @Member_ID and Password = @Password";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.Parameters.AddWithValue("@Member_ID", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i = 1;
            }
            con.Close();
            return i;
        }

        public int login_admin(string username, string password)
        {
            string connectionString = "SERVER=ACER\\YANSISKASQL; DATABASE=System_Sharia; integrated security = true;";
            int i = 0;
            string str = "Select * from Login_Admin where Username = @Username and Password = @Password";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i = 1;
            }
            con.Close();
            return i;
        }
    }
}
