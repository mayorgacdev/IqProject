using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.UserControls;
using EconomicMF.UserControls.UserInits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmInversors : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int solutionId;
        public FrmInversors(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
        }

        private async void ChargeInvestors() 
        {
            /*
            var inversors = await unitOfWork.InvesmentEntityClient.GetInvesmentEntity(solutionId);

            if (inversors is null || inversors.Count() <= 0)
            {
                return;
            }
            else
            {
                flpInversors.Controls.Clear();
                foreach (var item in inversors)
                {
                    UCInversor uCInversor = new UCInversor(unitOfWork, item.Id);
                    flpInversors.Controls.Add(uCInversor);
                }
            }*/
        }

        private async void FrmInversors_Load(object sender, EventArgs e)
        {
            UCInversorReport uCInversorReport = new UCInversorReport();
            flpInversors.Controls.Add(uCInversorReport);
            flpInversors.Controls.Add(uCInversorReport);
            flpInversors.Controls.Add(uCInversorReport);
            flpProjects.Controls.Add(new UCProject(unitOfWork, 2));
            flpProjects.Controls.Add(new UCProject(unitOfWork, 2));

            //ChargeInvestors();
            //ChargeProjects();
            // var inversors = await unitOfWork.InvesmentEntityClient.GetInvesmentEntity(solutionId);

            //dtgFNE.DataSource = inversors;
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
                    UCProjectInvestor uCProject = new UCProjectInvestor(unitOfWork, item.Id);
                    flpProjects.Controls.Add(uCProject);
                }
            }
        }
    }
}
