using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AUTOPARTS.CONNECTION;
using System.Data;
using AUTOPARTS.DCAT.MODELS;

namespace AUTOPARTS.DCAT.DAL
{
    class DAL_Category
    {
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

        public Model_Category GetDepartment(string dep)
        {
            SqlDataReader dr = null;
            Model_Category getDepartment = new Model_Category();
            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = dep;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        getDepartment.DEPCODE = dr["DEPID"].ToString();
                        getDepartment.DEPNAME = dr["DEPDESC"].ToString();
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return getDepartment;
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

        public Model_Category GetSubDepartment(string dep, string subDep, string name)
        {
            SqlDataReader dr = null;

            Model_Category getSubDepartment = new Model_Category();
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
                        getSubDepartment.DEPCODE = dr["DEPID"].ToString();
                        getSubDepartment.SUBDEPCODE = dr["SUBDEPID"].ToString();
                        getSubDepartment.SUBDEPNAME = dr["SUBDEPDESC"].ToString();
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return getSubDepartment;
        }

        public int CheckCategory(string DepId, string subDepId, string catId)
        {
            int retval = -1;

            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Category_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDepId;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = DepId;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = catId;

                SqlParameter rv = new SqlParameter("@RETVALUE", SqlDbType.Int) { Direction = ParameterDirection.Output };

                cmd.Parameters.Add(rv);
                con.Open();
                cmd.ExecuteScalar();
                retval = Convert.ToInt32(rv.Value);

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

        public Model_Category GetCategory(string dep, string subDep, string cat)
        {

            SqlDataReader dr = null;
            int retval;

            Model_Category category = new Model_Category();
            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Category_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDep;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = dep;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = cat;

                SqlParameter rv = new SqlParameter("@RETVALUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(rv);

                con.Open();
                cmd.ExecuteScalar();
                retval = Convert.ToInt32(rv.Value);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        category.DEPCODE = dr["DEPID"].ToString();
                        category.SUBDEPCODE = dr["SUBDEPID"].ToString();
                        category.CATCODE = dr["CATID"].ToString();
                        category.CATNAME = dr["CATDESC"].ToString();
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return category;
        }

        public int InsertData(Model_Category category)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Category_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = category.DEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = category.SUBDEPCODE;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = category.CATCODE;
                cmd.Parameters.Add(new SqlParameter("@CATDESC", SqlDbType.VarChar)).Value = category.CATNAME;

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

        public int UpdatetData(Model_Category category)
        {
            int retval = -100;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Category_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = category.CATCODE;
                cmd.Parameters.Add(new SqlParameter("@CATDESC", SqlDbType.VarChar)).Value = category.CATNAME;

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

        public int DeletetData(Model_Category category)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Category_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = category.DEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = category.SUBDEPCODE;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = category.CATCODE;
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
