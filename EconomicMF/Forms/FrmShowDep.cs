using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.SettingForms;
using ExportToExcel;
using NPOI.SS.Formula.Functions;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            var item = SingletonFrm.GetRepo().assets.FirstOrDefault(e => e.Code.Equals(guid));

            Random random = new Random();

            if (item is null)
            {
                return;
            }

            string path = string.Empty;
            string get = string.Empty;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath + "\\";
                get = folderBrowserDialog.SelectedPath + "\\";
            }

            if (item.DepreciationRate.Equals("DDDS"))
            {
                path = $"{path}dep{random.Next(20, 555)}.xlxs";
                CreateExcelFile.CreateExcelDocument(ProjectCalculations.DDDS(item.Amount, item.Terms, item.AmountResidual, 2), path);
                path = string.Empty;
                path = get;
            }
            else if (item.DepreciationRate.Equals("DSDA"))
            {
                path = $"{path}dep{random.Next(20, 555)}.xlxs";
                CreateExcelFile.CreateExcelDocument(ProjectCalculations.DSDA(item.Amount, item.Terms, item.AmountResidual), path);
                path = string.Empty;
                path = get;
            }
            else
            {
                path = $"{path}dep{random.Next(20, 555)}.xlxs";
                CreateExcelFile.CreateExcelDocument(ProjectCalculations.DSDA(item.Amount, item.Terms, item.AmountResidual), path);
                path = string.Empty;
                path = get;
            }
        }
    }
}
