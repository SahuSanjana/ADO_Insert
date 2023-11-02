using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_Insert.Ado
{
    class StudentInformation
    {
        public void InsertDataIntoStudent_Info(int Roll_number, string Student_name, long Contact_number)
        {
            try
            {
                string cn = ConfigurationManager.ConnectionStrings["MyServer"].ConnectionString;
                SqlConnection myCn = new SqlConnection(cn);
                myCn.Open();
                string query = "StdProInsertIntoStudent_Info";
                SqlCommand cmd = new SqlCommand(query, myCn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Roll_number", Roll_number);
                cmd.Parameters.AddWithValue("@Student_name", Student_name);
                cmd.Parameters.AddWithValue("@Contact_number", Contact_number);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

        }
    }
}
