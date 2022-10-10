using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Forms.FormsFlujo;
using EconomicMF.SettingForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmChargeData : Form
    {
        private readonly IUnitOfWork projectServices;

        private int idProject;
        public FrmChargeData(IUnitOfWork projectServices)
        {
            InitializeComponent();
            this.projectServices = projectServices;
            this.idProject = DataOnMemory.ProjectId;
        }

        private void FrmChargeData_Load(object sender, EventArgs e)
        {
            lblTasa.Text = MemoryOnProject.TmarMixta + "";
            ValidateInvestors();
            ChargeLabels();
            ChargeInversors();
        }

        private void ValidateInvestors()
        {
            //var investors = projectServices.GetEntitiesByProjectId(idProject);
            //var project = projectServices.GetById(idProject);
            //if (investors is null || investors.Count <= 0)
            //{
                
            //    const string wait = "Esperando..";
            //    btnEspecificado.Visible = false;
            //    lblTasa.Text = wait;
            //    lblTir.Text = wait;
            //    lblVpn.Text = wait;
            //    lblInversionistas.Text = wait;  
            //    lblPeriodo.Text = $"{project.Period}";
            //}
            //else
            //{
            //    lblPeriodo.Text = $"{project.Period}";
            //    btnEspecificado.Visible = true;
            //    ChargeInversors();
            //}
        }
        private void ChargeLabels()
        {
            try
            {
                //var (project, flows) = ChargeProject();
                //lblInversionistas.Text = project.EntidadInvs.Count.ToString();
                //lblPeriodo.Text = project.Period.ToString();
                //lblTasa.Text = "27%";
                //ValidateInvestors();

                //if (project.AreaInversions.Count > 0 && project.CostProjects.Count > 0 && project.EntidadInvs.Count > 0)
                //{
                //    lblTir.Text = Math.Round(ProjectCalculations.TIR(flows, 10), 2).ToString();
                //    lblVpn.Text = Math.Round(ProjectCalculations.VPN(flows, 10), 2).ToString();
                //    btnEspecificado.Visible = true;
                //}
                //else
                //{
                //    lblVpn.Text = "Esperando...";
                //    btnEspecificado.Visible = false;
                //}

                //dtgFNE.DataSource = flows;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private (Project, List<Flujo>) ChargeProject()
        //{
        //    var project = projectServices.GetById(idProject);
        //    var inversiones = projectServices.GetAllInversionsByProject(project);
        //    var costos = projectServices.GetAllCosto(project);
        //    var ingresos = projectServices.GetAllIngreso(project);
        //    var flujos = ProjectCalculations.FNE(project);

        //    project.IngresoProyectos = ingresos;
        //    project.CostProjects = costos;
        //    project.AreaInversions = inversiones;

        //    return (project, flujos);
        //}

        private void btnEspecificado_Click(object sender, EventArgs e)
        {
        }

        private void ChargeInversors()
        {
            //flpInvestors.Controls.Clear();
            //foreach (var item in projectServices.GetEntitiesByProjectId(idProject))
            //{
            //    UCInvestorForCharge uCInvestorForCharge = new UCInvestorForCharge();
            //    flpInvestors.Controls.Add(uCInvestorForCharge);
            //}
        }

        private void btnAddInvestor_Click(object sender, EventArgs e)
        {
            FrmAddInvestors frmAddInvestors = new FrmAddInvestors(projectServices);
            frmAddInvestors.ShowDialog();
            ChargeInversors();
            ValidateInvestors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.EditarInversor));
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);
            Form fh = (Form)formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }
    }
}
