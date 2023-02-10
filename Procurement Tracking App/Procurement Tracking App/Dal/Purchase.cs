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

        public static bool GetPurchaseBreakdownIsGood = false;
        public static string GetPurchaseBreakdownErrorMessage;
        public static DataTable GetPurchaseBreakdown(string _po_no)
        {
            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purchase_breakdown_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_po_no", _po_no));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPurchaseBreakdownIsGood = true;
                    return dt.Tables[0];
                }
                catch (Exception ex) { GetPurchaseBreakdownIsGood = false; GetPurchaseBreakdownErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Get"; return null; }
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

        public static bool AddBreakdownIsGood = false;
        public static string AddBreakdownErrorMessage;
        public static void AddBreakdown(string _po_no,string _property_no, string _unit, string _description, string _unit_cost, string _quantity, string _total_cost, string _supplier)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purchase_breakdown_add", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_po_no", _po_no));
                    cmd.Parameters.Add(new MySqlParameter("_property_no", _property_no));
                    cmd.Parameters.Add(new MySqlParameter("_unit", _unit));
                    cmd.Parameters.Add(new MySqlParameter("_description", _description));
                    cmd.Parameters.Add(new MySqlParameter("_unit_cost", _unit_cost));
                    cmd.Parameters.Add(new MySqlParameter("_quantity", _quantity));
                    cmd.Parameters.Add(new MySqlParameter("_total_cost", _total_cost));
                    cmd.Parameters.Add(new MySqlParameter("_supplier", _supplier));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AddBreakdownIsGood = true;
                }
            }
            catch (Exception ex) { AddBreakdownIsGood = false; AddBreakdownErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add"; }
        }

        //update
        public static bool EditPurchaseIsGood = false;
        public static string EditPurchaseErrorMessage;
        public static void EditPurchase(string _po_no, string _description, string _end_user, string _mode_of_pr, string _abc)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purchase_edit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_po_no", _po_no));
                    cmd.Parameters.Add(new MySqlParameter("_description", _description));
                    cmd.Parameters.Add(new MySqlParameter("_end_user", _end_user));
                    cmd.Parameters.Add(new MySqlParameter("_mode_of_pr", _mode_of_pr));
                    cmd.Parameters.Add(new MySqlParameter("_abc", _abc));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    EditPurchaseIsGood = true;
                }
            }
            catch (Exception ex) { EditPurchaseIsGood = false; EditPurchaseErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Edit"; }
        }

        //delete
        public static bool DeleteBreakdownIsGood = false;
        public static string DeleteBreakdownErrorMessage;
        public static void DeleteBreakdown(int _id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purchase_breakdown_delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DeleteBreakdownIsGood = true;
                }
            }
            catch (Exception ex) { DeleteBreakdownIsGood = false; DeleteBreakdownErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add"; }
        }
    }
}
