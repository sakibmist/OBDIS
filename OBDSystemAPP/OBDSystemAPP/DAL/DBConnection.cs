using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace OBDSystemAPP.DAL
{
    public class DBConnection
    {
        protected SqlCommand Command;
        protected SqlConnection Connection;
        protected SqlDataReader Reader;

        public DBConnection()
        {
            Connection=new SqlConnection(WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            Command = new SqlCommand();
            Command.Connection = Connection; 
        }
    }
}