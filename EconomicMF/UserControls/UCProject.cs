using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.SettingForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCProject : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly int projectId;

        public UCProject(IUnitOfWork unitOfWork, int projectId)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.projectId = projectId;
        }

        private void UCProject_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 100);
        }

        private void UCProject_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33,30,50);
        }

        private void UCProject_Load(object sender, EventArgs e)
        {
            ChargeLabels();
        }

        private async void ChargeLabels()
        {
            var data = await unitOfWork.ProjectClient.GetAsync(projectId);
            lblDuracionValue.Text = data.Duration.ToString();
            lblNameProject.Text = data.Name;
            lblResult.Text = data.Period.ToString();
        }

        private void UCProject_Click(object sender, EventArgs e)
        {
            DataOnMemory.ProjectId = projectId;
            SingletonFrm.GetForm(FormType.FlowMain).Show();
            SingletonFrm.GetForm(FormType.Main).Hide();
        }
    }            
}
