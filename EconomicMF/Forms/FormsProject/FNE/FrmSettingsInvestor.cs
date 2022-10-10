using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmSettingsInvestor : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int projectId;
        public FrmSettingsInvestor(IUnitOfWork unitOfWork, int projectId)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.projectId = projectId;

        }

        private void FrmEditarInvestor_Load(object sender, System.EventArgs e)
        {
            Charge();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void dtgFNE_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dtgFNE.CurrentCell = this.dtgFNE.Rows[e.RowIndex].Cells[0];
            var ID = dtgFNE.Rows[e.RowIndex].Cells[0].Value;
        }

        private async void Charge()
        {
            dtgFNE.DataSource = await unitOfWork.InvesmentArea.GetProjects(projectId);
        }
    }
}
