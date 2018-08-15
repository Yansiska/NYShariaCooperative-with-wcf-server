using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePinjam" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicePinjam.svc or ServicePinjam.svc.cs at the Solution Explorer and start debugging.
    public class ServicePinjam : IServicePinjam
    {
        //public int insertPinjam(DataPinjam pinjam)
        //{
        //    Connection con = new Connection();
        //    SqlConnection sqlcon = con.openConnection();
        //    int result = 0;


        //    using (sqlcon)
        //    {
        //        sqlcon.Open();

        //        string conn = "insert into Pinjam (ID_Pinjam, Member_ID, Member_Name, Monthly_Income, Jumlah_Pinjam, Jangka_Pinjam,Angsuran, Status) values(@ID_Pinjam,@Member_ID @Member_Name, @Monthly_Income, @Jumlah_Pinjam, @Jangka_Pinjam, @Angsuran, @Status)";
        //        SqlCommand com = new SqlCommand(conn, sqlcon);

        //        using (com)
        //        {
        //            com.Parameters.AddWithValue("@ID_Pinjam", pinjam.Idpinjam);
        //            com.Parameters.AddWithValue("@Member_ID", pinjam.IDmem);
        //            com.Parameters.AddWithValue("@Member_Name", pinjam.Namapinjam);
        //            com.Parameters.AddWithValue("@Monthly_Income", pinjam.Gajii);
        //            com.Parameters.AddWithValue("@Jumlah_Pinjam", pinjam.Jumlah);
        //            com.Parameters.AddWithValue("@Jangka_Pinjam", pinjam.Jangka);
        //            com.Parameters.AddWithValue("@Angsuran", pinjam.Angsuran);
        //            com.Parameters.AddWithValue("@Status", pinjam.Status);


        //            result = com.ExecuteNonQuery();
        //        }
        //        sqlcon.Close();
        //    }
        //    return result;
        //}

        public int datapinjam(DataPinjam pinjam)
        {
            Connection con = new Connection();
            SqlConnection sqlcon = con.openConnection();
            int result = 0;


            using (sqlcon)
            {
                sqlcon.Open();

                string conn = "insert into Pinjam (ID_Pinjam, Member_ID, Member_Name, Monthly_Income, Jumlah_Pinjam, Jangka_Pinjam, Angsuran, Status) values(@ID_Pinjam, @Member_ID, @Member_Name, @Monthly_Income, @Jumlah_Pinjam, @Jangka_Pinjam, @Angsuran, @Status)";
                SqlCommand com = new SqlCommand(conn, sqlcon);

                using (com)
                {
                    com.Parameters.AddWithValue("@ID_Pinjam", pinjam.ID);
                    com.Parameters.AddWithValue("@Member_ID", pinjam.IDAnggota);
                    com.Parameters.AddWithValue("@Member_Name", pinjam.Nama);
                    com.Parameters.AddWithValue("@Monthly_Income", pinjam.Gaji);
                    com.Parameters.AddWithValue("@Jumlah_Pinjam", pinjam.JumlahPinjam);
                    com.Parameters.AddWithValue("@Jangka_Pinjam", pinjam.JangkaPinjam);
                    com.Parameters.AddWithValue("@Angsuran", pinjam.Angsuran);
                    com.Parameters.AddWithValue("@Status", pinjam.Status);

                    result = com.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }

        //public int UpdatePinjam(DataPinjam pinjam)
        //{
        //    Connection con = new Connection();
        //    SqlConnection sqlcon = con.openConnection();
        //    int result = 0;


        //    using (sqlcon)
        //    {
        //        sqlcon.Open();

        //        string conn = "update Pinjam set Member_ID = @Member_ID, Member_Name = @Member_Name, Monthly_Income = @Monthly_Income, Jumlah_Pinjam = @Jumlah_Pinjam, Jangka_Pinjam = @Jangka_Pinjam, Angsuran = @Angsuran, Status = @Status where ID_Pinjam = @ID_Pinjam ";
        //        SqlCommand com = new SqlCommand(conn, sqlcon);

        //        using (com)
        //        {
        //            com.Parameters.AddWithValue("@ID_Pinjam", pinjam.Idpinjam);
        //            com.Parameters.AddWithValue("@Member_ID", pinjam.IDmem);
        //            com.Parameters.AddWithValue("@Member_Name", pinjam.Namapinjam);
        //            com.Parameters.AddWithValue("@Monthly_Income", pinjam.Gajii);
        //            com.Parameters.AddWithValue("@Jumlah_Pinjam", pinjam.Jumlah);
        //            com.Parameters.AddWithValue("@Jangka_Pinjam", pinjam.Jangka);
        //            com.Parameters.AddWithValue("@Angsuran", pinjam.Angsuran);
        //            com.Parameters.AddWithValue("@Status", pinjam.Status);

        //            result = com.ExecuteNonQuery();
        //        }
        //        sqlcon.Close();
        //    }
        //    return result;
        //}
    }
}
