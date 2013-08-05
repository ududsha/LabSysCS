using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


using System.Data.SqlClient;

namespace LabSysCS.DataAccess
{
    class User
    {
        public static DataSet IsUserNameExist(string UserName,string Password)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = ConnectionManager.GetDatabaseConnection())
            {

                string sql = "SELECT UserName FROM [User] WHERE (UserName = @UserNaME)AND(Password = @Password)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                command.CommandType = CommandType.Text;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet, "UserName");

            }

            return dataSet;
        }
        
    }
}
