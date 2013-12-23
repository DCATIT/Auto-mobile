using System;
using System.Data;
using System.Data.SqlClient;
using AUTOPARTS.CONNECTION;
using AUTOPARTS.DCAT.MODELS;

namespace AUTOPARTS.DCAT.DAL
{
    class DAL_SubDeparment
    {

        public int InsertData(Model_Subdepartment subDep)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubDepartment_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = subDep.DEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDep.SUBDEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPDESC", SqlDbType.VarChar)).Value = subDep.SUBDEPNAME;

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

        public int UpdatetData(Model_Subdepartment subDep)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubDepartment_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = subDep.DEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDep.SUBDEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPDESC", SqlDbType.VarChar)).Value = subDep.SUBDEPNAME;

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
        public int DeletetData(Model_Subdepartment subDep)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubDepartment_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = subDep.DEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDep.SUBDEPCODE;
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

        public int CheckSubDepartment(string DepId, string subDepId)
        {
            int retval = -1;

            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubDepartment_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDepId;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = DepId;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    retval = 1;
                }
                else
                {
                    retval = 0;
                }
                con.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return retval;
        }

        public Model_Subdepartment GetSubDepartment(string dep, string subDep, string name)
        {
            //int retval = -12;
            SqlDataReader dr = null;
            
            Model_Subdepartment subDepartment = new Model_Subdepartment();
            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubDepartment_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDep;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = dep;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        subDepartment.DEPCODE = dr["DEPID"].ToString();
                        subDepartment.SUBDEPCODE = dr["SUBDEPID"].ToString();
                        subDepartment.SUBDEPNAME = dr["SUBDEPDESC"].ToString();
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return subDepartment;
        }

        public int CheckDepartment(string depid)
        {
            int retval = -1;

            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = depid;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    retval = 1;
                }
                else
                {
                    retval = 0;
                }
                con.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return retval;
        }

        public Model_Subdepartment GetDepartment(string bk)
        {
            SqlDataReader dr = null;
            Model_Subdepartment subDepartment = new Model_Subdepartment();
            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = bk;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        subDepartment.DEPCODE = dr["DEPID"].ToString();
                        subDepartment.DEPNAME = dr["DEPDESC"].ToString();
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return subDepartment;
        }

    }
}
