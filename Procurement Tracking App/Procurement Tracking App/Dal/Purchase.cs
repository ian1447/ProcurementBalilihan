using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Procurement_Tracking_App.Core;
using System.Data;

namespace Procurement_Tracking_App.Dal
{
    public class Purchase
    {
        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        //get
        public static bool GetPurchaseIsGood = false;
        public static string GetPurchaseErrorMessage;
        public static DataTable GetPurchase()
        {
            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purchase_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPurchaseIsGood = true;
                    return dt.Tables[0];
                }
                catch (Exception ex) { GetPurchaseIsGood = false; GetPurchaseErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Get"; return null; }
            }
        }

        public static bool GetPrIsGood = false;
        public static string GetPrErrorMessage;
        public static bool GetPr(string po_no)
        {           
            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purchase_get_pr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_po_no", po_no));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPrIsGood = true;
                    if (dt.Tables[0].Rows.Count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex) { GetPrIsGood = false; GetPrErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Get"; return false; }
            }
        }

        //add
        public static bool AddPrIsGood = false;
        public static string AddPrErrorMessage;
        public static void AddPr(string pr_no, string _description, string _end_user, string _mode_of_pr, string _abc)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purchase_add", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_po_no", pr_no));
                    cmd.Parameters.Add(new MySqlParameter("_description", _description));
                    cmd.Parameters.Add(new MySqlParameter("_end_user", _end_user));
                    cmd.Parameters.Add(new MySqlParameter("_mode_of_pr", _mode_of_pr));
                    cmd.Parameters.Add(new MySqlParameter("_abc", _abc));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AddPrIsGood = true;
                }
            }
            catch (Exception ex) { AddPrIsGood = false; AddPrErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add"; }
        }

    }
}
