using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddCosto : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmAddCosto(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
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
            ChargeDtg();
            cmbTipodeCrecimiento.Items.AddRange(Enum.GetValues(typeof(TipoCrecimiento)).Cast<object>().ToArray());
        }

        private void cmbTipodeCrecimiento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipodeCrecimiento.SelectedIndex >= 0)
            {
                cmbTipodeCrecimiento.Visible = true;
                lblCosto.Location = new Point(493, 226);
            }
            else
            {
                cmbTipodeCrecimiento.Visible = false;
                lblCosto.Location = new Point(387, 226);
                txtCrecimiento.Size = new Size(800, 39);
            }

            if ((TipoCrecimiento)cmbTipodeCrecimiento.SelectedItem is TipoCrecimiento.SinCrecimiento)
            {
                lblCrecimiento.Visible = false;
                txtCrecimiento.Visible = false;
            }
            else
            {
                lblCrecimiento.Visible = true;
                txtCrecimiento.Visible = true;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TipoCrecimiento)cmbTipodeCrecimiento.SelectedItem is not TipoCrecimiento.SinCrecimiento)
                {
                    ProjectCost projectCost = new ProjectCost()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Cost = Math.Round(decimal.Parse(txtCosto.Texts), 2),
                        Growth = Math.Round(decimal.Parse(txtCrecimiento.Texts), 2),
                        TypeGrowth = cmbTipodeCrecimiento.SelectedItem.ToString(),
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        CostType = txtTipoDeCosto.Texts,
                    };

                    await unitOfWork.CostClient.SetCost(projectCost);

                    ChargeDtg();
                }
                else
                {
                    ProjectCost projectCost = new ProjectCost()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Cost = Math.Round(decimal.Parse(txtCosto.Texts), 2),
                        Growth = 0,
                        TypeGrowth = "Sin crecimiento",
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        CostType = txtTipoDeCosto.Texts,
                    };

                    await unitOfWork.CostClient.SetCost(projectCost);

                    ChargeDtg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ChargeDtg()
        {
            dtgFNE.DataSource = await unitOfWork.CostClient.GetAllCost(DataOnMemory.ProjectId);
        }
    }
}
