using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.SettingForms;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmShowDep : Form
    {
        private string guid;
        public FrmShowDep(string guid)
        {
            InitializeComponent();
            this.guid = guid;
        }

        private void FrmShowDep_Load(object sender, EventArgs e)
        {
            Charge();
        }

        private void Charge()
        {
            var asset = SingletonFrm.GetRepo().assets.FirstOrDefault(e => e.Code.Equals(guid));

            if ( asset is null)
            {
                return;
            }

            string dep = asset.DepreciationRate;

            dtgFNE.DataSource = null;

            if (dep.Equals("DDDS"))
            {
                dtgFNE.DataSource = ProjectCalculations.DDDS(asset.Amount, asset.Terms);
                ChargeDTGC(true);
            }
            if (dep.Equals("DSDA"))
            {
                dtgFNE.DataSource = ProjectCalculations.DSDA(asset.Amount, asset.Terms);
                ChargeDTGC(false);
            }
            if (dep.Equals("DLR"))
            {
                dtgFNE.DataSource = ProjectCalculations.DLR(asset.Amount, asset.Terms);
                ChargeDTGC(true);
            }
        }

        private void ChargeDTGC(bool stonks)
        {
            if (stonks)
            {
                dtgFNE.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dtgFNE.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmShowDep_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
