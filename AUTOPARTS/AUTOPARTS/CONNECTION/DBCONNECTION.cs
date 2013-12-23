using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AUTOPARTS.CONNECTION;

namespace AUTOPARTS.CONNECTION
{
    public static  class DBCONNECTION
    {

        
        public static SqlConnection GetConnection() 
        {

            SqlConnection con = null; // new Sql connection instance
         
            int ConType = 0;

            ConType = NetworkConnection();

            if (ConType == 1)
            {
                con = SetNetworkConnection();
            }
            else 
            {
                ConType = LocalConnection();
                
                if (ConType==1)
                {
                    con = SetLocalConnection();
                }
            }
            return con;
        }
        private static int LocalConnection()
        {
            int conT = -1;

            string dbn;   // data base name
            string dbpw;  // data base password
            string dbs;   // data base server
            SqlConnection con = null; // new Sql connection instance

            try
            {
                dbn = REGISTRYVALUES.getValue("LN");  // Database Name - "SERVERDB";
                dbpw = REGISTRYVALUES.getValue("LP"); // Database password - "misnomer@123";
                dbs = REGISTRYVALUES.getValue("LS");  // Database Server - "THISH-PC";
                con = new SqlConnection("Data Source= " + dbs + " ;Initial Catalog= " + dbn + "; User ID=sa;Password=" + dbpw + "");
                con.Open();
                con.Close();
                conT = 1;
            }
            catch (Exception EX)
            {
                conT = 0;
                Console.WriteLine(EX.Message);
            }

            return conT;
        }

        private static int NetworkConnection()
        {
            int conT = -1;

            string dbn;   // data base name
            string dbpw;  // data base password
            string dbs;   // data base server
            SqlConnection con = null; // new Sql connection instance

            try
            {
                dbn = REGISTRYVALUES.getValue("N");  // Database Name - "SERVERDB";
                dbpw = REGISTRYVALUES.getValue("P"); // Database password - "tharu";
                dbs = REGISTRYVALUES.getValue("S");  // Database Server - "SUCCESS";
                con = new SqlConnection("Data Source= " + dbs + " ;Network Library=DBMSSOCN; Initial Catalog= " + dbn + "; User ID=sa;Password=" + dbpw + "");
                con.Open();
                con.Close();
                conT = 1;
            }
            catch (SqlException EX)
            {
                conT = 0;
                Console.WriteLine(EX.Message);
            }
            return conT;
        }

        private static SqlConnection SetNetworkConnection() 
        {
            string dbn;   // data base name
            string dbpw;  // data base password
            string dbs;   // data base server
            SqlConnection con = null; // new Sql connection instance

            dbn = REGISTRYVALUES.getValue("N");  // Database Name - "SERVERDB";
            dbpw = REGISTRYVALUES.getValue("P"); // Database password - "tharu";
            dbs = REGISTRYVALUES.getValue("S");  // Database Server - "SUCCESS";
            con = new SqlConnection("Data Source= " + dbs + " ;Network Library=DBMSSOCN; Initial Catalog= " + dbn + "; User ID=sa;Password=" + dbpw + "");

            return con;
        }

        private static SqlConnection SetLocalConnection()
        {
            string dbn;   // data base name
            string dbpw;  // data base password
            string dbs;   // data base server
            SqlConnection con = null; // new Sql connection instance

            dbn = REGISTRYVALUES.getValue("LN");  // Database Name - "SERVERDB";
            dbpw = REGISTRYVALUES.getValue("LP"); // Database password - "misnomer@123";
            dbs = REGISTRYVALUES.getValue("LS");  // Database Server - "THISH-PC";
            con = new SqlConnection("Data Source= " + dbs + " ;Initial Catalog= " + dbn + "; User ID=sa;Password=" + dbpw + "");

            return con;
        }

    }
}
