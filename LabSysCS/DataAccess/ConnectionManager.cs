using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

namespace LabSysCS
{
    class ConnectionManager
    {
        public static SqlConnection GetDatabaseConnection()
        {
            string connectString = "Data Source=VINOL-PC\\SQLEXPRESS;Initial Catalog=LABSYS;Integrated Security=True";//.\SQLEXPRESS;AttachDbFilename=D:\MyWorks\FileDownloads\App_Data\FileDownloads.mdf;Integrated Security=True;User Instance=True
            SqlConnection connection = new SqlConnection(connectString);

            connection.Open();
            return connection;
        }
    }
}
