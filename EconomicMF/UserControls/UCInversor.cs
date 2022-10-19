using ABI.Windows.UI;
using EconomicMF.Domain.Contracts;
using System;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCInversor : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly int inversorId;

        public UCInversor(IUnitOfWork unitOfWork, int inversorId)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.inversorId = inversorId;
        }

        private async void ChargeLabels()
        {
            var data = await unitOfWork.InvesmentEntityClient.GetAsync(inversorId);
            lblNameInversor.Text = data.Name;
        }

        private void UCInversor_Load(object sender, EventArgs e)
        {
            ChargeLabels();
        }

        private void UCInversor_Click(object sender, EventArgs e)
        {
            // TODO: Create all the project related to investment
        }

        private void GetRamdon()
        {
            // TODO: Create RamdonColor 
        }
    }
}
