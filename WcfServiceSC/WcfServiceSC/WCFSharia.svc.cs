using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFSharia" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFSharia.svc or WCFSharia.svc.cs at the Solution Explorer and start debugging.
    public class WCFSharia : IWCFSharia
    {
        public int insertMember(Daftarmember daftar)
        {
            Connection con = new Connection();
            SqlConnection sqlcon = con.openConnection();
            int result = 0;


            using (sqlcon)
            {
                sqlcon.Open();

                string conn = "insert into Member (Member_ID, Member_Name, Date_Of_Birth, Gender, Email, Password) values(@Member_ID, @Member_Name, @Date_Of_Birth, @Gender, @Email, @Password)";
                 SqlCommand com = new SqlCommand(conn, sqlcon);

                using (com)
                {
                    com.Parameters.AddWithValue("@Member_ID", daftar.ID);
                    com.Parameters.AddWithValue("@Member_Name", daftar.Nama);
                    com.Parameters.AddWithValue("@Date_Of_Birth", daftar.DateOfBirth);
                    com.Parameters.AddWithValue("@Gender", daftar.Jk);
                    com.Parameters.AddWithValue("@Email", daftar.Email);
                    com.Parameters.AddWithValue("@Password", daftar.Password);

                    result = com.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }

        //public ArrayList ListMember(string id)
        //{
            
        //}

        //public bool loginAdmin(string username, string password)
        //{
        //    Connection con = new Connection();
        //    SqlConnection sqlcon = new SqlConnection();

        //    using (sqlcon)
        //    {
        //        sqlcon.Open();
        //        string com = "select count (*) from Login_Admin where Username = @Username and Password = @Password";

        //        SqlCommand sqlconn = new SqlCommand(com, sqlcon);
        //        int result = 0;
        //        using (sqlconn)
        //        {
        //            sqlconn.Parameters.AddWithValue("@Username", username);
        //            sqlconn.Parameters.AddWithValue("@Password", password);

        //            result = (int)sqlconn.ExecuteScalar();
        //            if (result > 0)
        //                return true;
        //            else
        //                return false;
        //        }
        //    }
        //}

        public int updateMember(Daftarmember daftar)
        {
            Connection con = new Connection();
            SqlConnection sqlcon = con.openConnection();
            int result = 0;


            using (sqlcon)
            {
                sqlcon.Open();

                string conn = "update Member set Member_Name = @Member_Name, Address = @Address, Date_Of_Birth = @Date_of_Birth, Gender = @Gender, Work = @Work, Monthly_Income = @Monthly_Income, Email = @Email, No_HP =@No_HP, Password =@Password where Member_ID = @Member_ID ";
                SqlCommand com = new SqlCommand(conn, sqlcon);

                using (com)
                {
                    com.Parameters.AddWithValue("@Member_ID", daftar.ID);
                    com.Parameters.AddWithValue("@Member_Name", daftar.Nama);
                    com.Parameters.AddWithValue("@Address", daftar.Address);
                    com.Parameters.AddWithValue("@Date_Of_Birth", daftar.DateOfBirth);
                    com.Parameters.AddWithValue("@Gender", daftar.Jk);      
                    com.Parameters.AddWithValue("@Work", daftar.Work);
                    com.Parameters.AddWithValue("@Monthly_Income", daftar.Gaji);
                    com.Parameters.AddWithValue("@Email", daftar.Email);
                    com.Parameters.AddWithValue("@No_HP", daftar.NoHP);
                    com.Parameters.AddWithValue("@Password", daftar.Password);

                    result = com.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }

        
    }
}
