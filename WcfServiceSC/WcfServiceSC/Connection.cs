using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfServiceSC
{
    public class Connection
    {
        public SqlConnection openConnection()
        {
            SqlConnection Connect = new SqlConnection("data source =ACER\\YANSISKASQL; initial catalog = System_Sharia; integrated security = true;");
            return Connect;
        }
    } 
}