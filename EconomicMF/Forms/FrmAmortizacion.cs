using EconomicEF.Infraestructure.Repository;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.Helper;
using EconomicMF.Services.Processes.Intereses;
using EconomicMF.SettingForms;
using ExportToExcel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmAmortizacion : Form
    {
        public FrmAmortizacion()
        {
            InitializeComponent();
        }

        private void FrmAmortizacion_Load(object sender, System.EventArgs e)
        {
            cmbTipoMetodo.Items.AddRange(Enum.GetValues(typeof(TipoDeAmortizacion)).Cast<object>().ToArray());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo()
            {
                Nombre = txtName.Texts,
                Monto = decimal.Parse(txtMonto.Texts),
                Interes = double.Parse(txtInteres.Texts),
                Año = int.Parse(txtN.Texts),
                TipoDeAmortizacion = cmbTipoMetodo.SelectedItem.ToString(),
            };

            SingletonFrm.GetRepo().prestamos.Add(prestamo);
            ChargeDgv();
        }

        private void ChargeDgv()
        {
            dtgFNE.DataSource = null;
            dtgFNE.DataSource = SingletonFrm.GetRepo().prestamos;
            dtgFNE.Columns[0].Visible = false;

            dtgFNE.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgFNE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgFNE.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgFNE.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgFNE.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dtgFNE_Click(object sender, EventArgs e)
        { 

            FrmShowAmortizacion frmShowAmortizacion = new FrmShowAmortizacion();
            frmShowAmortizacion.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                string? entryId = dtgFNE.CurrentRow.Cells[0].Value.ToString();

                if (entryId.Equals(String.Empty))
                {
                    return;
                }

                var prestamo = SingletonFrm.GetRepo().prestamos.FirstOrDefault(e => e.Guid.ToString().Equals(entryId));

                if (prestamo != null)
                {
                    SingletonFrm.GetRepo().prestamos.Remove(prestamo);
                    ChargeDgv();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            string get = string.Empty;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath + "\\";
                get = folderBrowserDialog.SelectedPath + "\\";
            }
            else
            {
                return;
            }

            Random random = new Random();
            path = $"{path}AmortizationInfo{random.Next(20, 555)}.xlsx";

            CreateExcelFile.CreateExcelDocument(SingletonFrm.GetRepo().prestamos, path);
        }
    }
}
