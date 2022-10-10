using EconomicMF.SettingForms;
using System.Windows.Forms;

namespace EconomicMF.Forms.FrmInitProjects
{
    public partial class FrmConfigInit : Form
    {
        public FrmConfigInit()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = (Form)formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void FrmConfigInit_Load(object sender, System.EventArgs e)
        {

        }

        private void rjToggleButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                SettingsTheme.IsDark = false;
            }
            else
            {
                SettingsTheme.IsDark = true;
            }
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
