using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AUTOPARTS.DCAT.MODELS;
using AUTOPARTS.CONNECTION;
using System.Data.SqlClient;
using System.Data;

namespace AUTOPARTS.DCAT.DAL
{
    public class DAL_CompanyInfo
    {
        public int InsertData(Model_Department dep)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = dep.DepCode;
                cmd.Parameters.Add(new SqlParameter("@DEPDESC", SqlDbType.VarChar)).Value = dep.DepName;

                SqlParameter rv = new SqlParameter("@RETVALUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(rv);

                con.Open();
                cmd.ExecuteScalar();
                retval = Convert.ToInt32(rv.Value);
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                retval = 0;
            }
            return retval;
        }

        public int UpdatetData(Model_Department dep)
        {
            int retval = -100;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = dep.DepCode;
                cmd.Parameters.Add(new SqlParameter("@DEPDESC", SqlDbType.VarChar)).Value = dep.DepName;
                SqlParameter retPara = new SqlParameter("@RETVALUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(retPara);

                con.Open();
                cmd.ExecuteScalar();
                retval = Convert.ToInt32(retPara.Value.ToString());
                con.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                retval = 0;
            }
            return retval;
        }

    }
}
