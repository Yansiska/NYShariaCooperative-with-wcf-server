using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLogin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceLogin.svc or ServiceLogin.svc.cs at the Solution Explorer and start debugging.
    public class ServiceLogin : IServiceLogin
    {
       
        public bool loginAdmin(string username, string password)
        {
            Connection con = new Connection();
            SqlConnection sqlcon = new SqlConnection();

            using (sqlcon)
            {
                sqlcon.Open();
                string com = "select count (*) from Login_Admin where Username = @Username and Password = @Password";

                SqlCommand sqlconn = new SqlCommand(com, sqlcon);
                int result = 0;
                using (sqlconn)
                {
                    sqlconn.Parameters.AddWithValue("@Username", username);
                    sqlconn.Parameters.AddWithValue("@Password", password);

                    result = (int)sqlconn.ExecuteScalar();
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

    }
}
