using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Forms;
using EconomicMF.SettingForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCSolutions : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly int solutionId;

        public UCSolutions(IUnitOfWork unitOfWork, int solutionId)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = solutionId;
        }

        private void UCSolutions_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateGray;
        }

        private void UCSolutions_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 50);
        }

        private async void ChargeLabel()
        {
            
            Solution solution = await unitOfWork.SolutionClient.GetAsync(solutionId);
            lblNameSolution.Text = solution.SolutionName;
            lblNumberOfProjects.Text = (await unitOfWork.ProjectClient.GetProjectsAsync(solution.Id)).Count().ToString();
            lblDate.Text = solution.Date.ToShortDateString();
            lbldata.Text = solution.Id.ToString();
        }

        private void UCSolutions_Click(object sender, EventArgs e)
        {
            DataOnMemory.SolutionId = solutionId;
            SingletonFrm.GetForm(FormType.Main).Show();
            SingletonFrm.GetForm(FormType.Solution).Hide();
        }

        private void UCSolutions_Load(object sender, EventArgs e)
        {
            ChargeLabel();
        }
    }
}
