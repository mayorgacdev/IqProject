using EconomicMF.Forms.FrmConfigs;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }
        private void btnGeneral_Click(object sender, EventArgs e)
        {
            FrmUpdateUser frmUpdateUser = new FrmUpdateUser();
            AbrirFormEnPanel(frmUpdateUser);
        }
    }
}
