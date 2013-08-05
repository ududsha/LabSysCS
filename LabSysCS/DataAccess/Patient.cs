using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using System.Data.SqlClient;

namespace LabSysCS.DataAccess
{
    class Patient
    {

        public static int InsertApplicant(string PatientName, string NIC, DateTime DOB,string Sex,DateTime RegisteredDate,string Address,string PNumber,string Email)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = ConnectionManager.GetDatabaseConnection())
            {
                SqlCommand command = new SqlCommand("InsertPatient", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PatientName", SqlDbType.VarChar).Value = PatientName;
                command.Parameters.Add("@NIC", SqlDbType.VarChar).Value = NIC;
                command.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                command.Parameters.Add("@Sex", SqlDbType.VarChar).Value = Sex;
                command.Parameters.Add("@RegisteredDate", SqlDbType.DateTime).Value = RegisteredDate;
                command.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
                command.Parameters.Add("@PNumber", SqlDbType.VarChar).Value = PNumber;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                rowsAffected = command.ExecuteNonQuery();
            }
            return rowsAffected;
        }

        public static DataSet GetPatient(int PatientID)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = ConnectionManager.GetDatabaseConnection())
            {

                string sql = "SELECT * FROM Patient WHERE PatientID = @PatientID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@PatientID", SqlDbType.VarChar).Value = PatientID;
                command.CommandType = CommandType.Text;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet, "PatientID");
                dataAdapter.Fill(dataSet, "PatientName");
                dataAdapter.Fill(dataSet, "NIC");
                dataAdapter.Fill(dataSet, "DOB");
                dataAdapter.Fill(dataSet, "Sex");
                dataAdapter.Fill(dataSet, "RegisteredDate");
                dataAdapter.Fill(dataSet, "Address");
                dataAdapter.Fill(dataSet, "PNumber");
                dataAdapter.Fill(dataSet, "EMail");

            }

            return dataSet;
        }
    }
}
