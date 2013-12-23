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
    public class DAL_SubCategory
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

        public Model_SubCategory GetDepartment(string dep)
        {
            SqlDataReader dr = null;
            Model_SubCategory getDepartment = new Model_SubCategory();
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

        public Model_SubCategory GetSubDepartment(string dep, string subDep, string name)
        {
            SqlDataReader dr = null;

            Model_SubCategory getSubDepartment = new Model_SubCategory();
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

        public Model_SubCategory GetCategory(string dep, string subDep, string cat)
        {

            SqlDataReader dr = null;
            int retval = -1;

            Model_SubCategory category = new Model_SubCategory();
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

        public int CheckSubCategory(string DepId, string subDepId, string catId,string subCatId)
        {
            int retval = -1;

            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubCategory_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDepId;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = DepId;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = catId;
                cmd.Parameters.Add(new SqlParameter("@SUBCATID", SqlDbType.VarChar)).Value = subCatId;

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

        public Model_SubCategory GetSubCategory(string dep, string subDep, string cat, string subCat)
        {

            SqlDataReader dr = null;
            int retval = -1;
            Model_SubCategory category = new Model_SubCategory();
            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubCategory_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subDep;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = dep;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = cat;
                cmd.Parameters.Add(new SqlParameter("@SUBCATID", SqlDbType.VarChar)).Value = subCat;

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
                        category.SUBCATCODE = dr["SUBCATID"].ToString();
                        category.SUBCATNAME = dr["SUBCATDESC"].ToString();
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

        public int InsertData(Model_SubCategory subCategory)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubCategory_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = subCategory.DEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subCategory.SUBDEPCODE;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = subCategory.CATCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBCATID", SqlDbType.VarChar)).Value = subCategory.SUBCATCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBCATDESC", SqlDbType.VarChar)).Value = subCategory.SUBCATNAME;

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

        public int UpdatetData(Model_SubCategory subCategory)
        {
            int retval = -100;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubCategory_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@SUBCATID", SqlDbType.VarChar)).Value = subCategory.SUBCATCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBCATDESC", SqlDbType.VarChar)).Value = subCategory.SUBCATNAME;

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

        public int DeletetData(Model_SubCategory subCategory)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("SubCategory_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = subCategory.DEPCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBDEPID", SqlDbType.VarChar)).Value = subCategory.SUBDEPCODE;
                cmd.Parameters.Add(new SqlParameter("@CATID", SqlDbType.VarChar)).Value = subCategory.CATCODE;
                cmd.Parameters.Add(new SqlParameter("@SUBCATID", SqlDbType.VarChar)).Value = subCategory.SUBCATCODE;

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
