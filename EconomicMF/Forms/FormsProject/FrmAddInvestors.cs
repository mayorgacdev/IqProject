using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.SettingForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject
{
    public partial class FrmAddInvestors : Form
    {
        #region INIT: Entidades(List<>), projectServices, SolutionServices, UserServices, idProject, idSolution, ExistOrNew
        
        private readonly IUnitOfWork unitOfWork;

        // Necesario para poder saber el porcentage total de aportación
        List<decimal> aportacion;

        // Importante para calculo de TMAR
        List<decimal> tmar;

        // Este objeto sirve para recuperar el proyecto ya creado desde FrmProject
        private ProjectClient projectClient = null!;

        public FrmAddInvestors(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            aportacion = new List<decimal>();
            tmar = new List<decimal>();
        }

        #endregion
        
        #region ButtonsNotImportants and ConvertImage

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmAddInvestors_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Add investor and project
        decimal tmamixta = 0M;

        private async void btnAddInvestor_Click(object sender, EventArgs e)
        {
            try
            {
                // Llevando siempre el mismo orden de FrmProject (TMAR) (Aportación)
                tmar.Add(txtInteresPrestamo.Value);
                aportacion.Add(nupAportacionUser.Value);
                MemoryOnProject.CalculoTmar.Add(txtInteresPrestamo.Value);
                MemoryOnProject.CalculoTmar.Add(nupAportacionUser.Value);
                ValidatePorcentage();

                InvesmentEntity entidadInv = new InvesmentEntity()
                {
                    ProjectId = projectClient.Id,
                    Name = txtNameInvestor.Texts,
                    Email = txtEmail.Texts,
                    IsPorcentage = true,
                    Contribution = nupAportacionUser.Value,
                    Rate = txtInteresPrestamo.Value,
                    TipoDeAmortización = cmbAmortización.SelectedItem.ToString(),
                    MoneyLoan = true,
                    FeeLevel = false,
                    LoanTerm = MemoryOnProject.LoanTerm,
                };

                MemoryOnProject.CalculoTmar.Add(txtInteresPrestamo.Value);
                MemoryOnProject.CalculoTmar.Add(nupAportacionUser.Value);

                CleanTextBoxs();
                await unitOfWork.InvesmentEntityClient.SetInvesmentEntityAsync(entidadInv);
                nupAportacionUser.Maximum = 0;
                nupAportacionUser.Value = 0;
                ChargeData();

                nupAportacionUser.Maximum = 0;
                nupAportacionUser.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region OpenForm: FrmMain

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Main).Show();
            SingletonFrm.GetForm(FormType.CreateProject).Hide();
            this.Hide();
        }

        private decimal GetTmarMixta()
        {
            decimal aux = 0M, aux2 = 0M, sum = 0M;
            int count = MemoryOnProject.CalculoTmar.Count();

            for (int i = 0; i < count; i++)
            {
                if (i + 1 == count)
                {
                    return sum;
                }

                aux = MemoryOnProject.CalculoTmar[i];
                aux2 = MemoryOnProject.CalculoTmar[i + 1];
                sum += aux * aux2;
            }

            return sum;
        }

        public decimal limSup = 100 - MemoryOnProject.Contribution;
        decimal newLim = 0M;
        private bool ValidatePorcentage()
        {
            decimal totalSum = aportacion.Sum() + MemoryOnProject.Contribution;
            decimal sum = aportacion.Sum();

            if (totalSum == 100)
            {
                tmamixta = Math.Round(GetTmarMixta() / 100, 2);
                lblResultTMAR.Text = Math.Round(GetTmarMixta() / 100, 2) + " %";
                btnSiguiente.Visible = true;
                btnSiguiente.Enabled = true;
                btnAddInvestor.Enabled = false;
                txtSumTotal.Text = totalSum + " %";
                return true;
            }
            else
            {
                totalSum = aportacion.Sum() + MemoryOnProject.Contribution;
                newLim = limSup - sum;
                nupAportacionUser.Maximum = newLim;
                txtSumTotal.Text = totalSum + " %";
                return false;
            }
        }
        #endregion

        private async void FrmAddInvestors_Load(object sender, EventArgs e)
        {
            ValidatePorcentage();

            projectClient = await unitOfWork.ProjectClient.GetAsync(DataOnMemory.ProjectId);
            cmbAmortización.Items.AddRange(Enum.GetValues(typeof(TipoDeAmortizacion)).Cast<object>().ToArray());

            if (limSup == 1)
            {
                nupAportacionUser.Minimum = 1;
            }

            nupAportacionUser.Value = limSup;
            lblNameProject.Text = projectClient.Name;
            lblTmarProject.Text = projectClient.TMAR+"";
            MemoryOnProject.CalculoTmar.Clear();
        }

        private async void ChargeData()
        {
            dtgvData.DataSource = null;
            dtgvData.DataSource = await unitOfWork.InvesmentEntityClient.GetUniqueNames(projectClient.SolutionId);
        }
        
        private void CleanTextBoxs()
        {
            txtNameInvestor.Texts = String.Empty;
            txtInteresPrestamo.Value = 0;
            txtEmail.Texts = String.Empty;
            cmbAmortización.SelectedIndex = -1;
        }
    }
}
