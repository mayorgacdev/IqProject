using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Forms.FormsProject;
using EconomicMF.SettingForms;
using EconomicMF.UserControls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsMain
{
    public partial class FrmStart : Form
    {
        #region INIT: ProjectServices, SolutionServices, UserServices, idSolution

        private readonly IUnitOfWork unitOfWork;
        private int solutionId;

        public FrmStart(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
        }

        #endregion

        #region Charge ProjectsToFlowLayout and InversorsToFlowLayout

        private void FrmStart_Load(object sender, EventArgs e)
        {
            ChargeProjects();
            ChargeInversors();
        }
        private async void ChargeProjects()
        {   
            var projects = await unitOfWork.ProjectClient.GetProjectsAsync(solutionId);

            if (projects is null)
            {
                return;
            }
            else
            {
                flpProjects.Controls.Clear();
                foreach (var item in projects)
                {
                    UCProject uCProject = new UCProject(unitOfWork, item.Id);
                    flpProjects.Controls.Add(uCProject);
                }
            }

            lblNameUser.Text = DataOnMemory.FirstName;
        }

        private async void ChargeInversors()
        {
            var investments = await unitOfWork.InvesmentEntityClient.GetBySolutionIdAsync(solutionId);

            if (investments is null)
            {
                return;
            }
            else
            {
                flpInversors.Controls.Clear();
                foreach (var item in investments)
                {
                    UCInversor ucInversor = new UCInversor(unitOfWork, item.Id);
                    flpInversors.Controls.Add(ucInversor);
                }
            }
        }

        #endregion

        #region AddNewProjectToExistSolution

        private void btnControl_Click(object sender, EventArgs e)
        {
            try
            {
                flpInversors.Controls.Clear();
                flpProjects.Controls.Clear();
                SingletonFrm.GetForm(FormType.CreateProject).ShowDialog();
                ChargeProjects();
                ChargeInversors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dtTIme_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
