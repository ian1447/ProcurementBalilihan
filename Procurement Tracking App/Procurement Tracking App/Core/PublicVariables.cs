using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Procurement_Tracking_App.Core
{
    public class PublicVariables
    {
        public static string ProjectName = "Procurement Tracking v.2.0";
        public static double ProjectVersion = 1.0;

        #region Server Details
        public static string ServerConnectionString = File.ReadLines("constring.txt").First();
        #endregion

        public static int MaxRetries = 3;
        public static string UserPrivilege { get; set; }
        public static string UserFullName { get; set; }
    }
}
