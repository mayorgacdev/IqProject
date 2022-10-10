using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.SettingForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FormMain : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int projectId;
        public FormMain(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.projectId = DataOnMemory.ProjectId; 
        }
        private void AbrirFormEnPanel(Form formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Entry));
        }

        private void btnCosto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Cost));
        }

        private void btnInversion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Inversion));
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.ChargeData));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Main).Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Inversion));
            btnEvaluar.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelButtons.Width == 218)
            {
                btnIngresos.Text = String.Empty;
                btnEvaluar.Text = String.Empty;
                btnCosto.Text = String.Empty;
                btnInversion.Text = String.Empty;
                pbProfile.Size = new Size(41, 41);
                pbProfile.Location = new Point(7, 68);
                btnClose.Location = new Point(176, 725);
                panelButtons.Width = 53;
                
            }
            else
            {
                panelButtons.Width = 218;
                btnIngresos.Text = "Ingreso";
                btnEvaluar.Text = "Evaluar";
                btnCosto.Text = "Costo";
                btnInversion.Text = "Inversion";
                pbProfile.Size = new Size(108, 108);
                
                pbProfile.Location = new Point(56, 69);
                btnClose.Location = new Point(103, 725);
            }
        }
    }
}
