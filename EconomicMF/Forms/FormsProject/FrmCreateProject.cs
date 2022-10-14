using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.SettingForms;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject
{
    public partial class FrmCreateProject : Form
    {
        #region INIT

        private readonly IUnitOfWork unitOfWork;
        private readonly int solutionId;

        public FrmCreateProject(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
        }

        #endregion

        #region PanelMouseDown

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnAtrás_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Main).Show();
            this.Hide();
        }

        private void FrmCreateProject_Load(object sender, EventArgs e)
        {
            cmbPeriodo.Items.AddRange(Enum.GetValues(typeof(Periodo)).Cast<object>().ToArray());
            SingletonFrm.GetForm(FormType.Main).Hide();

        }
        #endregion

        #region OpenForm: FrmAddInvestors (IProjectServices projectServices, ISolutionServices solutionServices, IUserServices userServices, int idSolution, int idProject, bool existOrNew)

        private async void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (tgIsFinancement.Checked)
                {
                    ProjectClient project = new ProjectClient()
                    {
                        SolutionId = solutionId,
                        Name = txtNameProject.Texts,
                        Description = txtDescripción.Texts,
                        Period = cmbPeriodo.SelectedItem.ToString(),
                        Duration = int.Parse(txtDuracion.Texts),
                        WithFinancing = true,
                        TMAR = txtTmar.Value,
                        Contribution = nupAportación.Value,
                        CreationDate = DateTime.Now,
                        TMARMixta = 0M,
                    };

                    // Crear proyecto para adquirir Id
                    await unitOfWork.ProjectClient.CreateAsync(project);

                    // Obtener Id para setear al objeto de project para inversionista
                    DataOnMemory.ProjectId = await unitOfWork.ProjectClient.LastCreatedAsync();
                    
                    // Obtengo la contribution para sacar el porcentage que falta en frmAddInvestor
                    MemoryOnProject.Contribution = nupAportación.Value;
                    MemoryOnProject.LoanTerm = int.Parse(txtDuracion.Texts);
                    //Este orden es importante (TMAR) (Aportación)
                    MemoryOnProject.CalculoTmar.Add(txtTmar.Value);
                    MemoryOnProject.CalculoTmar.Add(nupAportación.Value);

                    //Abro el form para agregar los inversores
                    FrmAddInvestors frmAddInvestors = new FrmAddInvestors(unitOfWork);
                    frmAddInvestors.ShowDialog();
                }
                else
                {
                    ProjectClient project = new ProjectClient()
                    {
                        SolutionId = solutionId,
                        Name = txtNameProject.Texts,
                        Description = txtDescripción.Texts,
                        Period = cmbPeriodo.SelectedItem.ToString(),
                        Duration = int.Parse(txtDuracion.Texts),
                        WithFinancing = false,
                        TMAR = txtTmar.Value,
                        TMARMixta = 0M,
                        Contribution = 100M,
                        CreationDate = DateTime.Now,
                    };

                    await unitOfWork.ProjectClient.CreateAsync(project);
                    Clean();
                    SingletonFrm.GetForm(FormType.Main).Show();
                    this.Hide();
                }

                CleanTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void Clean()
        {
            txtNameProject.Texts = String.Empty;
            txtDescripción.Texts = String.Empty;
            txtDuracion.Texts = String.Empty;
            tgIsFinancement.Checked = false;
            txtTmar.Value = 0;
        }

        private void tgIsFinancement_CheckedChanged(object sender, EventArgs e)
        {
            if (tgIsFinancement.Checked)
            {
                label4.Visible = true;
                nupAportación.Maximum = 99;
                nupAportación.Visible = true;
            }
            else
            {
                nupAportación.Maximum = 100;
                label4.Visible = false;
                nupAportación.Visible = false;
            }
        }

        private void CleanTextBox()
        {
            txtNameProject.Texts = String.Empty;
            txtDescripción.Texts = String.Empty;
            cmbPeriodo.SelectedIndex = -1;
            txtDuracion.Texts = String.Empty;
            nupAportación.Value = 0;
            nupAportación.Visible = false;
            txtTmar.Value = 0;
            tgIsFinancement.Checked = false;
            label4.Visible = false;
            
            cmbPeriodo.SelectedIndex = -1;
        }
    }
}
