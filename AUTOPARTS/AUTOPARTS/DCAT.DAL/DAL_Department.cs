using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AUTOPARTS.CONNECTION;
using System.Data.SqlClient;
using AUTOPARTS.DCAT.MODELS;


namespace AUTOPARTS.DCAT.DAL
{
    public  class DAL_Department
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

        public int DeletetData(Model_Department dep)
        {
            int retval;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = dep.DepCode;
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

        public Model_Department GetDepartment(string bk)
        {
            //int retval = -12;
            SqlDataReader dr = null;
            Model_Department department = new Model_Department();
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
                        department.DepCode = dr["DEPID"].ToString();
                        department.DepName = dr["DEPDESC"].ToString();
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return department;
        }

        public List<Model_Department> GetSearchDataByName(String depName)
        {
            Model_Department department = new Model_Department();
            List<Model_Department> lstDepartment = new List<Model_Department>();
            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_SearchByName", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPDESC", SqlDbType.VarChar)).Value = depName;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Model_Department dep = new Model_Department();
                        dep.DepCode = dr["DEPID"].ToString();
                        dep.DepName = dr["DEPDESC"].ToString();
                        department = dep;
                        lstDepartment.Add(department);
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return lstDepartment;
        }

        public List<Model_Department> GetSearchDataById(String did)
        {
            Model_Department department = new Model_Department();
            List<Model_Department> lstDepartment = new List<Model_Department>();
            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("Department_SearchByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@DEPID", SqlDbType.VarChar)).Value = did;
                //cmd.Parameters.Add(new SqlParameter("@DEPDESC", SqlDbType.VarChar)).Value = depName;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Model_Department dep = new Model_Department();
                        dep.DepCode = dr["DEPID"].ToString();
                        dep.DepName = dr["DEPDESC"].ToString();
                        department = dep;
                        lstDepartment.Add(department);
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return lstDepartment;
        }

    }
}

