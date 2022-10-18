using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.SettingForms;
using EconomicMF.UserControls;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmSolution : Form
    {
        #region INIT: Unit of work 
        
        private readonly IUnitOfWork unitOfWork;
        private readonly string userEmail;

        public FrmSolution(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        private void FrmSolution_Load(object sender, EventArgs e)
        {
            Charge();
        }

        private async void Charge()
        {
            try
            {
                var solutions = await unitOfWork.SolutionClient.GetByUserEmailAsync(userEmail);

                int countUsers = solutions.Count();

                if (countUsers > 0)
                {
                    flowLayoutPanel1.Controls.Clear();

                    foreach (var item in solutions)
                    {
                        UCSolutions uCSolutions = new UCSolutions(unitOfWork, item.Id);
                        flowLayoutPanel1.Controls.Add(uCSolutions);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region FunctionMoveForm

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear_MouseEnter(object sender, EventArgs e)
        {
            btnCrear.BackColor = Color.DarkSlateGray;
        }

        private void btnCrear_MouseLeave(object sender, EventArgs e)
        {
            btnCrear.BackColor = Color.FromArgb(33, 30, 50);

        }

        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.DarkSlateGray;
        }

        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(33, 30, 50);
        }

        #endregion

        #region Create 

        private void btnCrear_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.AddSolution).Show();
            this.Hide();
        }

        #endregion

        private void btnConfig_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.ConfigInit).ShowDialog();
        }

        private async void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Equals(String.Empty))
            {
                Charge();
                return;
            }
            var solutions = await unitOfWork.SolutionClient.GetByUserEmailAsync(userEmail);
            var solutionQuery = solutions.Where(r => r.SolutionName.Equals(txtSearch.Texts) || r.Description.Equals(txtSearch.Texts));
            int countUsers = solutionQuery.Count();

            if (countUsers > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in solutionQuery)
                {
                    UCSolutions uCSolutions = new UCSolutions(unitOfWork, item.Id);
                    flowLayoutPanel1.Controls.Add(uCSolutions);
                }
            }
        }
    }
}
