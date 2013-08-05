using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using System.Data.SqlClient;

namespace LabSysCS.DataAccess
{
    class Report
    {
        public static int InsertFastingBloodSugar(DateTime ReportDate,int PatientID ,string RefferedDoctor,double FastingBloodSugar,double PrandialBloodSugar)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = ConnectionManager.GetDatabaseConnection())
            {
                SqlCommand command = new SqlCommand("InsertFastingBloodSugar", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@ReportDate", SqlDbType.DateTime).Value = ReportDate;
                command.Parameters.Add("@PatientID", SqlDbType.Int).Value = PatientID;
                command.Parameters.Add("@RefferedDoctor", SqlDbType.VarChar).Value = RefferedDoctor;
                command.Parameters.Add("@FastingBloodSugar", SqlDbType.Float).Value = FastingBloodSugar;
                command.Parameters.Add("@PrandialBloodSugar", SqlDbType.Float).Value = PrandialBloodSugar;
                rowsAffected = command.ExecuteNonQuery();

            }
            return rowsAffected;
        }
    }
}
