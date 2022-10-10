using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.SettingForms;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace EconomicMF.Forms
{
    public partial class FrmMain : Form
    {
        #region INIT ProjectServices, SolutionServices, UserServices, idSolution

        private readonly IUnitOfWork unitOfWork;
        private int solutionId;
        private string userEmail;

        public FrmMain(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            solutionId = DataOnMemory.SolutionId;
            userEmail = DataOnMemory.Email;
        }

        #endregion

        #region Charge and AbrirFormEnPanel

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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.DashBoard));
            ChargeLabels();
        }

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Solution).Show();
            this.Hide();
        }

        private void dtTIme_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void pbMinimizeButtons_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void ChargeLabels()
        {
            lblUserLogin.Text = DataOnMemory.FirstName;
            lblEmail.Text = DataOnMemory.Email;
            lblPhoneNumber.Text = DataOnMemory.PhoneNumber;
           // pbImageProfileUser.Image = byteArrayToImage(UserDao.ProfileImage);
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        #region MouseDownPanels

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelOpen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #endregion

        #region OpenForms: FrmReporte, FrmStart, FrmDashboard, FrmInversors, FrmCalculos, FrmConfig

        private void btnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Reporte));
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Start));
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.DashBoard));
        }

        private void btnInversionistas_Click(object sender, EventArgs e)
        {
            //FrmInversors frmInversors = new FrmInversors(unitOfWork);
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Inversors));
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Calculus));
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Config));
        }

        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Point leftMenu = new Point(8, 7);
            Point leftLogo = new Point(9, 100);
            Size rightPanel = new Size(60, 905);
            Size leftPanel = new Size(200, 905);
            Point rightMenu = new Point(152, 4);


            if (panelButtons.Width == 200)
            {
                panelButtons.Size = rightPanel;

                btnMenu.Location = leftMenu;
                pbLogo.Location = leftLogo;
                pbLogo.Size = new Size(42, 84);
                btnClose.Location = new Point(3, 864);
                ClearButton(true);
            }
            else
            {
                btnMenu.Location = rightMenu;
                panelButtons.Size = leftPanel;
                pbLogo.Size = new Size(180, 149);
                pbLogo.Location = new Point(9, 100);
                btnClose.Location = new Point(86, 864);
                ClearButton(false);
            }
        }


        private void ClearButton(bool clear)
        {
            if (clear)
            {
                btnDashBoard.Text = String.Empty;
                btnReporte.Text = String.Empty;
                btnProjects.Text = String.Empty;
                btnInversionistas.Text = String.Empty;
                btnGestionar.Text = String.Empty;
                btnConfigurar.Text = String.Empty;
            }
            else
            {
                btnDashBoard.Text = "Dashboard";
                btnReporte.Text = "Reportes";
                btnProjects.Text = "Proyecto";
                btnInversionistas.Text = "Inversionistas";
                btnGestionar.Text = "Gestionar";
                btnConfigurar.Text = "Configurar";
            }
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Others));
        }
    }
}
