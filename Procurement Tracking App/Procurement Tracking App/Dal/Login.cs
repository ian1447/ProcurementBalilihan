using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Procurement_Tracking_App.Core;
using System.Data;

namespace Procurement_Tracking_App.Dal
{
    public class Login
    {
        public static string errormessage = string.Empty;
        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        public static bool isConnection = false;
        public static void TryConnection()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    isConnection = true;
                }
            }
            catch (Exception ex)
            {
                errormessage = ex.Message;
            }
        }

        public static string GetUserDataError = string.Empty;
        public static bool GetUserDataSuccessful = false;
        public static DataTable GetLogin(string Username, string Password)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_users_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_username", Username));
                    cmd.Parameters.Add(new MySqlParameter("_password", Password));
                    cmd.Parameters.Add(new MySqlParameter("_id", 0));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetUserDataSuccessful = true;

                    if (dt.Tables[0].Rows[0]["_ret"].ToString().Equals("Login Sucessfully"))
                    {
                        GetUserDataError = dt.Tables[0].Rows[0]["_ret"].ToString();
                        PublicVariables.UserPrivilege = dt.Tables[0].Rows[0]["privilege"].ToString();
                        return dt.Tables[0];
                    }
                    else
                    {
                        GetUserDataError = dt.Tables[0].Rows[0]["_ret"].ToString();
                        GetUserDataSuccessful = false;
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                GetUserDataSuccessful = false;
                GetUserDataError = ex.Message + "\n Function:  Login";
                return null;
            }
        }

        public static string TestConnectionError = string.Empty;
        public static bool TestConnectionSuccessful = false;
        public static void TestConnection(string server, string db, string uid, string password, string port)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("Server = " + server + "; Database = " + db + "; Uid = " + uid + "; Pwd = " + password + "; Port = " + port + ";"))
                {
                    con.Open();
                    TestConnectionSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                TestConnectionError = ex.Message;
            }
        }
    }
}
