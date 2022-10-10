using System.Windows.Forms;
using EconomicMF.Domain.Entities.Flows;
using System;
using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.SettingForms;

namespace EconomicMF.Forms.FrmInitProjects
{
    public partial class FrmAddSolution : Form
    {
        #region INIT ProjectServices, SolutionServices, UserServices, idSolution

        private readonly IUnitOfWork unitOfWork;
        private readonly string userEmail;

        public FrmAddSolution(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        #endregion

        private async void btnSiguiente_Click(object sender, System.EventArgs e)
        {
            try
            {
                User user = await unitOfWork.UserClient.GetByEmailAsync(userEmail);

                Solution solution = new Solution()
                {
                    UserId = user.Id,
                    SolutionName = txtNameSolution.Texts,
                    Description = txtDescripción.Texts,
                    Date = DateTime.Now
                };

                int result = await unitOfWork.SolutionClient.CreateAsync(solution);
                
                if (result < 0) { return; }

                int LastSolution = await unitOfWork.SolutionClient.LastCreatedAsync();

                DataOnMemory.SolutionId = LastSolution;

                SingletonFrm.GetForm(FormType.Main).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Solution).Show();
            this.Hide();
        }

        private void btnAtrás_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Solution).Show();
            this.Hide();
        }
    }
}
