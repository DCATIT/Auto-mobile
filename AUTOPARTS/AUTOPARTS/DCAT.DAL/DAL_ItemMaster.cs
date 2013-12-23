using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AUTOPARTS.DCAT.MODELS;
using System.Data.SqlClient;
using AUTOPARTS.CONNECTION;
using System.Data;
using System.Collections;

namespace AUTOPARTS.DCAT.DAL
{
     public class DAL_ItemMaster
    {
        public int InsertData(Model_ItemMaster itm, Model_CurrentStock curstk)
        {
            int retval = -1;

            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand("ItemMaster_Insert", con);
            SqlTransaction transaction;

            con.Open();

            transaction = con.BeginTransaction();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SUBCATID", SqlDbType.VarChar)).Value = itm.SUBCATID;

            cmd.Parameters.Add(new SqlParameter("@ITEMCODE", SqlDbType.VarChar)).Value = itm.ITEMCODE;
            cmd.Parameters.Add(new SqlParameter("@ITEMDESCRIPTION", SqlDbType.VarChar)).Value = itm.ITEMDESCRIPTION;
            cmd.Parameters.Add(new SqlParameter("@PARTNO", SqlDbType.VarChar)).Value = itm.PARTNO;
            cmd.Parameters.Add(new SqlParameter("@PARTNAME", SqlDbType.VarChar)).Value = itm.PARTNAME;
            cmd.Parameters.Add(new SqlParameter("@ALTPARTNO", SqlDbType.VarChar)).Value = itm.ALTPARTNO;
            cmd.Parameters.Add(new SqlParameter("@ALTPARTNAME", SqlDbType.VarChar)).Value = itm.ALTPARTNAME;

            cmd.Parameters.Add(new SqlParameter("@SPECIAL", SqlDbType.VarChar)).Value = itm.SPECIAL;
            cmd.Parameters.Add(new SqlParameter("@UOM", SqlDbType.VarChar)).Value = itm.UOM;
            cmd.Parameters.Add(new SqlParameter("@BIN", SqlDbType.VarChar)).Value = itm.BIN;
            cmd.Parameters.Add(new SqlParameter("@GENSTATUS", SqlDbType.Int)).Value = itm.GENSTATUS;

            
            cmd.Parameters.Add(new SqlParameter("@ACTIVE", SqlDbType.Int)).Value = itm.ACTIVE;
            cmd.Parameters.Add(new SqlParameter("@SUPCODE", SqlDbType.VarChar)).Value = curstk.SUP_CODE;
            cmd.Parameters.Add(new SqlParameter("@LOCCODE", SqlDbType.VarChar)).Value = curstk.LOC_CODE;
            cmd.Parameters.Add(new SqlParameter("@SELLINGPRICE", SqlDbType.Decimal)).Value = curstk.SELLINGPRICE;
            cmd.Parameters.Add(new SqlParameter("@COSTPRICE", SqlDbType.Decimal)).Value = curstk.COSTPRICE;
                       
            SqlParameter rv = new SqlParameter("@RETVALUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(rv);

            try
            {
                cmd.Transaction = transaction;

                cmd.ExecuteScalar();

                retval = Convert.ToInt32(rv.Value);

                transaction.Commit();             

            }
            catch (SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rex)
                {
                    Console.WriteLine(rex.Message);
                }

                Console.WriteLine(ex.Message);
            }

            finally
            {
                //Check for close and respond accordingly
                if (con.State != ConnectionState.Closed) { con.Close(); }
                //Clean up my mess
                con.Dispose();
                cmd.Dispose();
                transaction.Dispose();
            }

            return retval;
        }

        public int UpdateData(Model_ItemMaster itm, Model_CurrentStock curstk)
        {
            int retval =-1;

            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand("ItemMaster_Update", con);
            SqlTransaction transaction;

            con.Open();

            transaction = con.BeginTransaction();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SUBCATID", SqlDbType.VarChar)).Value = itm.SUBCATID;

            cmd.Parameters.Add(new SqlParameter("@ITEMCODE", SqlDbType.VarChar)).Value = itm.ITEMCODE;
            cmd.Parameters.Add(new SqlParameter("@ITEMDESCRIPTION", SqlDbType.VarChar)).Value = itm.ITEMDESCRIPTION;
            cmd.Parameters.Add(new SqlParameter("@PARTNO", SqlDbType.VarChar)).Value = itm.PARTNO;
            cmd.Parameters.Add(new SqlParameter("@PARTNAME", SqlDbType.VarChar)).Value = itm.PARTNAME;
            cmd.Parameters.Add(new SqlParameter("@ALTPARTNO", SqlDbType.VarChar)).Value = itm.ALTPARTNO;
            cmd.Parameters.Add(new SqlParameter("@ALTPARTNAME", SqlDbType.VarChar)).Value = itm.ALTPARTNAME;

            cmd.Parameters.Add(new SqlParameter("@SPECIAL", SqlDbType.VarChar)).Value = itm.SPECIAL;
            cmd.Parameters.Add(new SqlParameter("@UOM", SqlDbType.VarChar)).Value = itm.UOM;
            cmd.Parameters.Add(new SqlParameter("@BIN", SqlDbType.VarChar)).Value = itm.BIN;
            cmd.Parameters.Add(new SqlParameter("@GENSTATUS", SqlDbType.Int)).Value = itm.GENSTATUS;
            cmd.Parameters.Add(new SqlParameter("@ACTIVE", SqlDbType.Int)).Value = itm.ACTIVE;
            
            cmd.Parameters.Add(new SqlParameter("@SUPCODE", SqlDbType.VarChar)).Value = curstk.SUP_CODE;
            cmd.Parameters.Add(new SqlParameter("@LOCCODE", SqlDbType.VarChar)).Value = curstk.LOC_CODE;
            cmd.Parameters.Add(new SqlParameter("@SELLINGPRICE", SqlDbType.Decimal)).Value = curstk.SELLINGPRICE;
            cmd.Parameters.Add(new SqlParameter("@COSTPRICE", SqlDbType.Decimal)).Value = curstk.COSTPRICE;

            SqlParameter rv = new SqlParameter("@RETVALUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(rv);

            try
            {
                cmd.Transaction = transaction;

                cmd.ExecuteScalar();

                retval = Convert.ToInt32(rv.Value);

                transaction.Commit();

            }
            catch (SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rex)
                {
                    Console.WriteLine(rex.Message);
                }

                Console.WriteLine(ex.Message);
            }

            finally
            {
                //Check for close and respond accordingly
                if (con.State != ConnectionState.Closed) { con.Close(); }
                //Clean up my mess
                con.Dispose();
                cmd.Dispose();
                transaction.Dispose();
            }

            return retval;
        }
         
        public int DeletetData(Model_ItemMaster itm)
        {
            int retval =-1;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                
                 SqlCommand cmd = new SqlCommand("ItemMaster_Delete", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add(new SqlParameter("@ITEMCODE", SqlDbType.VarChar)).Value = itm.ITEMCODE; 
                
                SqlParameter rv = new SqlParameter("@RETVALUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
                
                cmd.Parameters.Add(rv);

                con.Open();
                
                cmd.ExecuteScalar();
                
                retval = Convert.ToInt32(rv.Value);
                
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }
            return retval;
        }

        public string GetLastAutoGenaratedNo()
        {
            string AGICODE = "AG100001";
    
            return AGICODE;
            
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

        public ArrayList GetSearchData(string pITEMCODE, string pITEMDESCRIPTION, string pPARTNO, string pPARTNAME, string pALTPARTNO, string pALTPARTNAME)
        {
            //String ItmCode, Idesc, PtNo, PartName, AltPtNo, AltPtName;
            Model_Department department = new Model_Department();

            ArrayList RowAl = new ArrayList();
            ArrayList singleRow = new ArrayList();
            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("ItemMaster_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ITEMCODE", SqlDbType.VarChar)).Value = pITEMCODE;
                cmd.Parameters.Add(new SqlParameter("@ITEMDESCRIPTION", SqlDbType.VarChar)).Value = pITEMDESCRIPTION;
                cmd.Parameters.Add(new SqlParameter("@PARTNO", SqlDbType.VarChar)).Value = pPARTNO;
                cmd.Parameters.Add(new SqlParameter("@PARTNAME", SqlDbType.VarChar)).Value = pPARTNAME;
                cmd.Parameters.Add(new SqlParameter("@ALTPARTNO", SqlDbType.VarChar)).Value = pALTPARTNO;
                cmd.Parameters.Add(new SqlParameter("@ALTPARTNAME", SqlDbType.VarChar)).Value = pALTPARTNAME;

                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        List<String> row = new List<string>();

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            row.Add(dr[i].ToString());
                        }

                        RowAl.Add(row);
                    }
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException EX)
            {
                Console.WriteLine(EX.Message);
            }

            return RowAl;
        }

        public int CheckItem(string ItmCode)
        {
            int retval = -1;

            SqlDataReader dr = null;

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("ItemMaster_Select", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ITEMCODE", SqlDbType.VarChar)).Value = ItmCode;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    retval = 0;
                }
                else
                {
                    retval = 1;
                }
                con.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return retval;   
        }

        public ArrayList GetFormData(string ItemCode)
        {
            ArrayList al = new ArrayList();

            SqlDataReader dr = null;

                Model_Department mod_department = new Model_Department();
                Model_Subdepartment mod_subdepartment = new Model_Subdepartment();
                Model_Category mod_catogory = new Model_Category();
                Model_SubCategory mod_subcatogory = new Model_SubCategory();
                Model_Supplier mod_supplier = new Model_Supplier();
                Model_ItemMaster mod_itemmaster = new Model_ItemMaster();
                Model_CurrentStock mod_crntstock = new Model_CurrentStock();

            try
            {
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand("View_ItemPartList_GetData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ITEMCODE", SqlDbType.VarChar)).Value = ItemCode;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    
                    {
                        mod_itemmaster.ITEMCODE = dr["ITEMCODE"].ToString();
                        mod_itemmaster.ITEMDESCRIPTION = dr["ITEMDESCRIPTION"].ToString();
                        mod_itemmaster.PARTNO = dr["PARTNO"].ToString();
                        mod_itemmaster.PARTNAME = dr["PARTNAME"].ToString();
                        mod_itemmaster.ALTPARTNO = dr["ALTPARTNO"].ToString();
                        mod_itemmaster.ALTPARTNAME = dr["ALTPARTNAME"].ToString();
                        mod_itemmaster.SPECIAL = dr["SPECIAL"].ToString();
                        mod_itemmaster.UOM = dr["UOM"].ToString();
                        mod_itemmaster.BIN = dr["BIN"].ToString();
                        mod_itemmaster.GENSTATUS = Convert.ToInt32(dr["GENSTATUS"]);
                        mod_itemmaster.ACTIVE = Convert.ToInt32(dr["ACTIVE"]);

                        mod_crntstock.OPNBAL_QTY = Convert.ToDecimal(dr["OPNBAL_QTY"]);
                        mod_crntstock.PUR_QTY = Convert.ToDecimal(dr["PUR_QTY"]);
                        mod_crntstock.PURRET_QTY = Convert.ToDecimal(dr["PURRET_QTY"]);
                        mod_crntstock.SAL_QTY = Convert.ToDecimal(dr["SAL_QTY"]);
                        mod_crntstock.SALRET_QTY = Convert.ToDecimal(dr["SALRET_QTY"]);
                        mod_crntstock.DMG_QTY = Convert.ToDecimal(dr["DMG_QTY"]);
                        mod_crntstock.SIH = Convert.ToDecimal(dr["SIH"]);
                        mod_crntstock.COSTPRICE = Convert.ToDecimal(dr["COSTPRICE"]);
                        mod_crntstock.SELLINGPRICE = Convert.ToDecimal(dr["SELLINGPRICE"]);

                        mod_supplier.SUPCODE = dr["SUPCODE"].ToString();
                        mod_supplier.COMNAME = dr["COMNAME"].ToString();
                        mod_department.DepCode = dr["DEPID"].ToString();
                        mod_department.DepName = dr["DEPDESC"].ToString();
                        mod_subdepartment.SUBDEPCODE = dr["SUBDEPID"].ToString();
                        mod_subdepartment.SUBDEPNAME = dr["SUBDEPDESC"].ToString();
                        mod_catogory.CATCODE = dr["CATID"].ToString();
                        mod_catogory.CATNAME = dr["CATDESC"].ToString();
                        mod_subcatogory.SUBCATCODE = dr["SUBCATID"].ToString();
                        mod_subcatogory.SUBCATNAME = dr["SUBCATDESC"].ToString();

                        al.Add(mod_itemmaster);
                        al.Add(mod_crntstock);
                        al.Add(mod_supplier);
                        al.Add(mod_department);
                        al.Add(mod_subdepartment);
                        al.Add(mod_catogory);
                        al.Add(mod_subcatogory);
                    }
                }
                con.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

            return al;
        }

    }
}
