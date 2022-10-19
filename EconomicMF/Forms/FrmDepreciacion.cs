
using System;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.Services;
using EconomicMF.SettingForms;
using System.Linq;
using System.Windows.Forms;
using ExportToExcel;
using EconomicMF.Helper;
using EconomicEF.Infraestructure.Repository;

namespace EconomicMF.Forms
{
    public partial class FrmDepreciacion : Form
    {
        public FrmDepreciacion()
        {
            InitializeComponent();
        }
        //private void Export()
        //{
        //    ArrayToPdf.ArrayToPdf.CreatePdf(new List<Amortizacion>() { });
        //}

        private void cmbVidaActivos_OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            tgDepreciacion.Checked = true;

            if (cmbVidaActivos.SelectedItem != null && (VidaUtilActivos)cmbVidaActivos.SelectedItem is VidaUtilActivos.Terreno)
            {
                cmbVidaUtilActivosF(false);
            }
            else
            {
                cmbVidaUtilActivosF(true);
            }
        }

        private void cmbVidaUtilActivosF(bool on)
        {
            if (cmbVidaActivos.SelectedIndex > -1 && cmbVidaActivos != null)
            {
                txtName.Texts = CalculusOnMemory.GetName((VidaUtilActivos)cmbVidaActivos.SelectedItem);

                if (on)
                {
                    lblValorResidual.Visible = on;
                    txtValorResidual.Visible = on;
                    lblTipoDeMetodo.Visible = on;
                    cmbTipoMetodo.Visible = on;
                }
                else
                {
                    lblValorResidual.Visible = on;
                    txtValorResidual.Visible = on;
                    lblTipoDeMetodo.Visible = on;
                    cmbTipoMetodo.Visible = on;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (tglsVidaDeActivo.Checked)
                {
                    if ((VidaUtilActivos)cmbVidaActivos.SelectedItem is VidaUtilActivos.Terreno)
                    {

                        AssetOther asset = new AssetOther()
                        { 
                            Name = txtName.Texts,
                            Description = txtDescription.Texts,
                            Amount = decimal.Parse(txtMonto.Texts),
                            AmountResidual = 0,
                            Terms = 0,
                            DepreciationRate = "No se puede depreciar",
                            Code = Guid.NewGuid().ToString(),
                            AñosDeDepreciaciónSegunNi = tglsVidaDeActivo.Checked,
                            Status = "Activo",
                            IsDepreciable = false,
                            
                        };

                        SingletonFrm.GetRepo().assets.Add(asset);
                        ChargeDtg();
                    }
                    else
                    {
                        AssetOther asset = new AssetOther()
                        {
                            Name = txtName.Texts,
                            Description = txtDescription.Texts,
                            Amount = decimal.Parse(txtMonto.Texts),
                            AmountResidual = decimal.Parse(txtValorResidual.Texts),
                            Terms = CalculusOnMemory.GetTerms((VidaUtilActivos)cmbVidaActivos.SelectedItem),
                            DepreciationRate = cmbTipoMetodo.SelectedItem.ToString(),
                            Code = Guid.NewGuid().ToString(),
                            AñosDeDepreciaciónSegunNi = tglsVidaDeActivo.Checked,
                            Status = "Activo",
                            IsDepreciable = true,
                        };

                        SingletonFrm.GetRepo().assets.Add(asset);
                        ChargeDtg();
                    }
                }
                else if (!tgDepreciacion.Checked)
                {
                    AssetOther asset = new AssetOther()
                    {
                        Name = txtName.Texts,
                        Description = txtDescription.Texts,
                        Amount = decimal.Parse(txtMonto.Texts),
                        AmountResidual = 0,
                        Terms = 0,
                        DepreciationRate = "No se puede depreciar",
                        Code = Guid.NewGuid().ToString(),
                        AñosDeDepreciaciónSegunNi = tglsVidaDeActivo.Checked,
                        Status = "Activo",
                        IsDepreciable = false,
                    };

                    SingletonFrm.GetRepo().assets.Add(asset);
                    ChargeDtg();
                }
                else
                {
                    AssetOther asset = new AssetOther()
                    {
                        Name = txtName.Texts,
                        Description = txtDescription.Texts,
                        Amount = decimal.Parse(txtMonto.Texts),
                        AmountResidual = decimal.Parse(txtValorResidual.Texts),
                        Terms = int.Parse(txtVidaUtil.Texts),
                        DepreciationRate = cmbTipoMetodo.SelectedItem.ToString(),
                        Code = Guid.NewGuid().ToString(),
                        AñosDeDepreciaciónSegunNi = tglsVidaDeActivo.Checked,
                        Status = "Activo",
                        IsDepreciable = true,
                    };

                    SingletonFrm.GetRepo().assets.Add(asset);
                    ChargeDtg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDepreciacion_Load(object sender, EventArgs e)
        {
            ChargeDtg();
            tgDepreciacion.Checked = true;
            tglsVidaDeActivo.Checked = true;
            cmbVidaActivos.Items.AddRange(Enum.GetValues(typeof(VidaUtilActivos)).Cast<object>().ToArray());
            cmbTipoMetodo.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());
        }

        private void ChargeDtg()
        {
            dtgFNE.DataSource = null;

            var assets = SingletonFrm.GetRepo().assets;

            if (assets.Count > 0)
            {
                dtgFNE.DataSource = SingletonFrm.GetRepo().assets;
                dtgFNE.Columns[6].Visible = false;
                dtgFNE.Columns[7].Visible = false;
                dtgFNE.Columns[8].Visible = false;
                dtgFNE.Columns[9].Visible = false;
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
            path = $"{path}DepreciationInfo{random.Next(20, 555)}.xlsx";

            CreateExcelFile.CreateExcelDocument(SingletonFrm.GetRepo().assets, path);
        }

        private void dtgFNE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                string? entryId = dtgFNE.CurrentRow.Cells[6].Value.ToString();

                if (entryId.Equals(String.Empty))
                {
                    return;
                }

                FrmShowDep frmDepreciacion = new FrmShowDep(entryId);
                frmDepreciacion.ShowDialog();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                string? entryId = dtgFNE.CurrentRow.Cells[6].Value.ToString();

                if (entryId.Equals(String.Empty))
                {
                    return;
                }

                var asset = SingletonFrm.GetRepo().assets.FirstOrDefault(e => e.Code.Equals(entryId));

                if (asset != null)
                {
                    SingletonFrm.GetRepo().assets.Remove(asset);
                    ChargeDtg();
                }
            }
        }

        private void tglsVidaDeActivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbVidaActivos.SelectedIndex = -1;

            if (tglsVidaDeActivo.Checked)
            {
                cmbVidaActivos.Visible = true;
                txtVidaUtil.Visible = false;
                lblDepreciación.Visible = false;
                tgDepreciacion.Visible = false;
            }
            else
            {
                cmbVidaActivos.Visible = false;
                txtVidaUtil.Visible = true;
                lblDepreciación.Visible = true;
                tgDepreciacion.Visible = true;

                lblValorResidual.Visible = true;
                txtValorResidual.Visible = true;
                lblTipoDeMetodo.Visible = true;
                cmbTipoMetodo.Visible = true;
            }
        }

        private void tgDepreciacion_CheckedChanged(object sender, EventArgs e)
        {
            tgDep(tgDepreciacion.Checked);
        }

        private void tgDep(bool on)
        {
            if (on)
            {
                txtValorResidual.Visible = true;
                lblValorResidual.Visible = true;
                lblTipoDeMetodo.Visible = true;
                cmbTipoMetodo.Visible = true;
                txtVidaUtil.Visible = true;

            }
            else
            {
                txtValorResidual.Visible = false;
                lblValorResidual.Visible = false;
                lblTipoDeMetodo.Visible = false;
                cmbTipoMetodo.Visible = false;
                txtVidaUtil.Visible = false;

            }
        }
    }
}


        