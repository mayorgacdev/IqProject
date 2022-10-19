using EconomicEF.Common.UserCache;
using EconomicEF.Infraestructure.Repository;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Entities.FlowTool;
using EconomicMF.SettingForms;
using ExportToExcel;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmShowAmortizacion : Form
    {
        List<List<Amortizacion>> Amortizacions = new List<List<Amortizacion>>();
        private int index = 0;
        private int countM = 0;

        public FrmShowAmortizacion()
        {
            InitializeComponent();
        }

        private void ValidateButtons()
        {

            Amortizacions = ProjectCalculations.Amortizaciones(SingletonFrm.GetRepo().prestamos);

            countM = Amortizacions.Count;

            if (countM == 1)
            {
                dtgFNE.DataSource = null;
                btnAnterior.Visible = false;
                btnSiguiente.Visible = false;
                ChargeDtg(index);
            }
            else
            {
                dtgFNE.DataSource = null;

                btnAnterior.Visible = true;
                btnSiguiente.Visible = true;
                index = 0;
                ChargeDtg(index);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            index++;

            if (index == countM)
            {
                index = 0;
                ChargeDtg(index);
            }
            else
            {
                ChargeDtg(index);
            }
        }

        private void ChargeDtg(int index)
        {
            dtgFNE.DataSource = null;

            if (dtgFNE.Rows.Count > 0)
            {
                if (index > countM || index < 0)
                {
                    return;
                }
                else
                {
                    dtgFNE.DataSource = null;
                    dtgFNE.DataSource = Amortizacions[index];
                }

                dtgFNE.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dtgFNE.DataSource = Amortizacions[index];
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            index--;

            if (index <= 0)
            {
                index = countM - 1;
                ChargeDtg(index);
            }
            else
            {
                ChargeDtg(index);
            }
        }

        private void FrmShowAmortizacion_Load(object sender, EventArgs e)
        {
            ValidateButtons();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void FrmShowAmortizacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string path = string.Empty;
            string get = string.Empty;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath + "\\";
                get = folderBrowserDialog.SelectedPath + "\\";
            }

            path = $"{path}Amortización{random.Next(20, 555)}Amt.xlsx";
            CreateExcelFile.CreateExcelDocument(Amortizacions[index], path);
        }
    }
}
