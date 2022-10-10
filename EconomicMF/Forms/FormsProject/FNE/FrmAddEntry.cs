using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Contracts;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Helper;
using EconomicMF.UserControls.UCForGestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddEntry : Form
    {
        private readonly IUnitOfWork projectServices;
        private int projectId;
        List<ProjectEntry> ingresoProyectos;
        public FrmAddEntry(IUnitOfWork projectServices)
        {
            InitializeComponent();
            this.projectServices = projectServices;
            this.projectId = DataOnMemory.ProjectId;
            ingresoProyectos = new List<ProjectEntry>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //var project = projectServices.GetById(idProject);
                ////project.Flujos = projectServices.GetAllFlujo(project);
                //project.CostProjects = projectServices.GetAllCosto(project);
                //project.IngresoProyectos = projectServices.GetAllIngreso(project);
                
                //Validation.ValidateIngresoCosto(decimal.Parse(txtIngreso.Texts), int.Parse(txtStart.Texts), int.Parse(txtEnd.Texts), project.Duration);

                //ProjectEntryDto ingresoProyecto = new ProjectEntryDto()
                //{
                //    Entry = decimal.Parse(txtIngreso.Texts),
                //    Growth = decimal.Parse(txtCrecimiento.Texts),
                //    TypeGrowth = cmbTipodeCrecimiento.SelectedIndex.ToString(),
                //    Start = int.Parse(txtStart.Texts),
                //    End = int.Parse(txtEnd.Texts),
                //    EntryType = txtTipoIngreso.Texts,
                //    IdProjectNavigation = project
                //};

                //ingresoProyectos.Add(ingresoProyecto);

                //projectServices.SetIngresoToProject(ingresoProyectos, project);
                //UCAddIngresoToProject uCAddIngresoToProject = new UCAddIngresoToProject();
                //flpIngreso.Controls.Add(uCAddIngresoToProject);
                //ingresoProyectos.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            cmbTipodeCrecimiento.Items.AddRange(Enum.GetValues(typeof(TipoCrecimiento)).Cast<object>().ToArray());
        }

        private void cmbTipodeCrecimiento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipodeCrecimiento.SelectedIndex >= 0)
            {
                cmbTipodeCrecimiento.Visible = true;
                lblIngreso.Location = new Point(493, 226);
            }
            else
            {
                cmbTipodeCrecimiento.Visible = false;
                lblIngreso.Location = new Point(387, 226);
                txtCrecimiento.Size = new Size(800, 39);
            }
        }
    }
}
