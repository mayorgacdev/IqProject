using EconomicMF.Domain.Contracts;
using System;
using System.Linq;
using System.Windows.Forms;
using Windows.Data.Text;

namespace EconomicMF.Forms.FormsProject
{
    public partial class FrmShowReceptor : Form
    {
        private IUnitOfWork unitOfWork;
        public FrmShowReceptor(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Charge()
        {
            dtgFNE.DataSource = null;
            dtgFNE.DataSource = unitOfWork.MailClient.emailProps;
            dtgFNE.Columns[0].Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                string? inversionId = dtgFNE.CurrentRow.Cells[0].Value.ToString();
                var emailProp = unitOfWork.MailClient.emailProps.
                    FirstOrDefault(e => e.Guid.ToString().Equals(inversionId));

                unitOfWork.MailClient.emailProps.Remove(emailProp);
                Charge();
            }
        }

        private void FrmShowReceptor_Load(object sender, EventArgs e)
        {
            Charge();
        }
    }
}
