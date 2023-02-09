using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Procurement_Tracking_App.Core;
using System.Data;

namespace Procurement_Tracking_App.Dal
{
    public class Supplier
    {
        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        //get
        public static bool GetSuppliersIsGood = false;
        public static string GetSuppliersErrorMessage;
        public static DataTable GetSuppliers()
        {
            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_supplier_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetSuppliersIsGood = true;
                    return dt.Tables[0];
                }
                catch (Exception ex) { GetSuppliersIsGood = false; GetSuppliersErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Get"; return null; }
            }
        }

        //add
        public static bool AddSupplierIsGood = false;
        public static string AddSupplierErrorMessage;
        public static void AddSupplier(string _name, string _address)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_supplier_add", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_address", _address));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AddSupplierIsGood = true;
                }
            }
            catch (Exception ex) { AddSupplierIsGood = false; AddSupplierErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add"; }
        }

        //update
        public static bool EditSupplierIsGood = false;
        public static string EditSupplierErrorMessage;
        public static void EditSupplier(string _name, string _address, int _id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_supplier_edit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_address", _address));
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    EditSupplierIsGood = true;
                }
            }
            catch (Exception ex) { EditSupplierIsGood = false; EditSupplierErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Edit"; }
        }


        //delete
        public static bool DeleteSupplierIsGood = false;
        public static string DeleteSupplierErrorMessage;
        public static void DeleteSupplier(int _id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_supplier_delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DeleteSupplierIsGood = true;
                }
            }
            catch (Exception ex) { DeleteSupplierIsGood = false; DeleteSupplierErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Delete"; }
        }

    }
}
