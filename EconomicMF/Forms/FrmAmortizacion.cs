using EconomicEF.Infraestructure.Repository;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.Helper;
using EconomicMF.Services.Processes.Intereses;
using EconomicMF.SettingForms;
using ExportToExcel;
using RJCodeAdvance.RJControls;
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
            try
            {
                Prestamo prestamo = new Prestamo()
                {
                    Nombre = txtName.Texts,
                    Monto = decimal.Parse(txtMonto.Texts),
                    Interes = double.Parse(txtInteres.Texts),
                    Año = int.Parse(txtN.Texts),
                    TipoDeAmortizacion = cmbTipoMetodo.SelectedItem.ToString(),
                };
                Limpiar();
                SingletonFrm.GetRepo().prestamos.Add(prestamo);
                ChargeDgv();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public void Limpiar()
        {
            txtInteres.Texts = "";
            txtMonto.Texts = "";
            txtN.Texts = "";
            txtName.Texts = "";
            cmbTipoMetodo.Texts = "";
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

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateDecimalnotNegative(sender,e);
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((sender as RJTextBox).Texts.Contains(".") && (char)Keys.Back != e.KeyChar)
            {
                if ((sender as RJTextBox).Texts.Substring((sender as RJTextBox).Texts.IndexOf('.')).Length > 4)
                {
                    e.Handled = true;
                }
            }
            else
            if ((sender as RJTextBox).Texts.Length > 2 && (char)Keys.Back != e.KeyChar && '.' != e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }
    }
}
