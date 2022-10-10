using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations.FormsShowCalculus
{
    public partial class FrmCashFlowHistory : Form
    {
        private readonly IUnitOfWork unitOfWork;

        private string userEmail;

        public FrmCashFlowHistory(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }
        private void LlenarDgv()
        {
            //dgvCashFlow.DataSource = economicClassService.GetPureEconomicClasses(userEmail);
            dgvCashFlow.Columns["IdUser"].Visible = false;
            dgvCashFlow.Columns["Usuario"].Visible = false;
        }

        private void FrmCashFlowHistory_Load(object sender, EventArgs e)
        {
            //LlenarDgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
