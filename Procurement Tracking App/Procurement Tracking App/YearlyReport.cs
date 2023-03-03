using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Procurement_Tracking_App
{
    public partial class YearlyReport : DevExpress.XtraReports.UI.XtraReport
    {
        public YearlyReport()
        {
            InitializeComponent();
        }

        private void YearlyReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
