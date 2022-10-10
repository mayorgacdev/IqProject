using EconomicMF.Forms.FormsProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.UserControls.UserInits
{
    public partial class UCInversorReport : UserControl
    {
        public UCInversorReport()
        {
            InitializeComponent();
        }

        private void btnDowloadReport_Click(object sender, EventArgs e)
        {
            FrmSendReportToInversor frmSendReportToInversor = new FrmSendReportToInversor();
            frmSendReportToInversor.ShowDialog();
        }
    }
}
