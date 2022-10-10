using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddInversion : Form
    {
        private readonly IUnitOfWork unitOdWork;

        private int projectId;

        public FrmAddInversion(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOdWork = unitOfWork;
            this.projectId = DataOnMemory.ProjectId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                InvesmentArea invesment = new InvesmentArea()
                {
                    ProjectId = projectId,
                    Name = txtName.Texts,
                    Start = int.Parse(txtInicio.Texts),
                    Amount = decimal.Parse(txtMonto.Texts),
                    IsDiferida = tgIsDiferida.Checked,
                    RecoveryCt = nupRecuperaciónCt.Value,
                };

                unitOdWork.InvesmentArea.SetInvesmentArea(invesment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmInversion_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmSettingsInvestor(unitOdWork, projectId));
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);
            Form fh = (Form)formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }
    }
}
