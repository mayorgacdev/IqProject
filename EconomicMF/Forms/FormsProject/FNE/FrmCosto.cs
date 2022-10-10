using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Enums;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmCosto : Form
    {
        private readonly IUnitOfWork projectServices;
        private int idProject;
        public FrmCosto(IUnitOfWork projectServices)
        {
            InitializeComponent();
            this.projectServices = projectServices;
            this.idProject = DataOnMemory.ProjectId;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //var project = projectServices.GetById(idProject);
                //project.CostProjects = projectServices.GetAllCosto(project);
                //project.IngresoProyectos = projectServices.GetAllIngreso(project);

                //Validation.ValidateIngresoCosto(decimal.Parse(txtCosto.Texts), int.Parse(txtStart.Texts), int.Parse(txtEnd.Texts), project.Duration);

                //ProjectCostDto costproject = new ProjectCostDto()
                //{
                //    Cost = decimal.Parse(txtCosto.Texts),
                //    Growth = decimal.Parse(txtCrecimiento.Texts),
                //    TypeGrowth = cmbTipodeCrecimiento.SelectedIndex.ToString(),
                //    Start = int.Parse(txtStart.Texts),
                //    End = int.Parse(txtEnd.Texts),
                //    CostType = txtCosto.Texts,
                //    IdProjectNavigation = project
                //};
                //costProjects.Clear();
                //costProjects.Add(costproject);

                //projectServices.SetCostToProject(costProjects, project);
                //UCAddCostToProject uCAddCostToProject = new UCAddCostToProject(costproject);
                //flpCosto.Controls.Add(uCAddCostToProject);
                //costProjects.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCosto_Load(object sender, EventArgs e)
        {
            cmbTipodeCrecimiento.Items.AddRange(Enum.GetValues(typeof(TipoCrecimiento)).Cast<object>().ToArray());
        }
    }
}
