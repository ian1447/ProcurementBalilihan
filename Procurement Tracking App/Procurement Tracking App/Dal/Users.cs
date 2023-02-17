using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Procurement_Tracking_App.Core;
using System.Data;
using MySql.Data.MySqlClient;

namespace Procurement_Tracking_App.Dal
{
    class Users
    {
        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }
        //get
        public static bool GetUsersSuccessfull = false;
        public static string GetUsersErrorMessage;
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_users_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetUsersSuccessfull = true;
                    return dt;
                }
                catch (Exception ex) { GetUsersSuccessfull = false; GetUsersErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Get Users"; return null; }
            }

        }
        //add
        public static bool AddUserSuccessfull = false;
        public static string AddUserErrorMessage;
        public static void AddUser(string _name, string _username, string _password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_users_add", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_username", _username));
                    cmd.Parameters.Add(new MySqlParameter("_password", _password));
                    cmd.Parameters.Add(new MySqlParameter("_privelege", "User"));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AddUserSuccessfull = true;
                }
            }
            catch (Exception ex) { AddUserSuccessfull = false; AddUserErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add User"; }
        }

        //update
        public static bool EditUserIsGood = false;
        public static string EditUserErrorMessage;
        public static void EditUser(string _name, string _username, string _password, int _id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_users_edit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_username", _username));
                    cmd.Parameters.Add(new MySqlParameter("_password", _password));
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    EditUserIsGood = true;
                }
            }
            catch (Exception ex) { EditUserIsGood = false; EditUserErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Edit User"; }
        }
    }
}
