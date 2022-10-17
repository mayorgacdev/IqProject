using DocumentFormat.OpenXml.Drawing;
using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.Helper;
using EconomicMF.Services;
using Syncfusion.Runtime.Serialization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddAsset : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmAddAsset(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmAddAsset_Load(object sender, EventArgs e)
        {
            ChargeDtg();
            tgDepreciacion.Checked = true;
            tglsVidaDeActivo.Checked = true;
            cmbVidaActivos.Items.AddRange(Enum.GetValues(typeof(VidaUtilActivos)).Cast<object>().ToArray());
            cmbTipoMetodo.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tglsVidaDeActivo.Checked)
                {
                    if ((VidaUtilActivos)cmbVidaActivos.SelectedItem is VidaUtilActivos.Terreno)
                    {
                        Asset asset = new Asset()
                        {
                            ProjectId = DataOnMemory.ProjectId,
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

                        await unitOfWork.AssetClient.SetAssetAsync(asset);
                        ChargeDtg();
                    }
                    else
                    {
                        Asset asset = new Asset()
                        {
                            ProjectId = DataOnMemory.ProjectId,
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

                        await unitOfWork.AssetClient.SetAssetAsync(asset);
                        ChargeDtg();
                    }
                }
                else if (!tgDepreciacion.Checked)
                {
                    Asset asset = new Asset()
                    {
                        ProjectId = DataOnMemory.ProjectId,
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

                    await unitOfWork.AssetClient.SetAssetAsync(asset);
                    ChargeDtg();
                }
                else
                {
                    Asset asset = new Asset()
                    {
                        ProjectId = DataOnMemory.ProjectId,
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

                    await unitOfWork.AssetClient.SetAssetAsync(asset);
                    ChargeDtg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ChargeDtg()
        {
            dtgFNE.DataSource = null;
            dtgFNE.DataSource = await unitOfWork.AssetClient.GetAllAssetAsync(DataOnMemory.ProjectId);
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
            dtgFNE.Columns[8].Visible = false;
            dtgFNE.Columns[9].Visible = false;
            dtgFNE.Columns[11].Visible = false;
        }

        private void cmbVidaActivos_OnSelectedIndexChanged(object sender, EventArgs e)
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                int assetId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                await unitOfWork.AssetClient.DeleteAsync(assetId);
                ChargeDtg();
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

        private async void dtgFNE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                int assetId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                int projectId = (int)dtgFNE.CurrentRow.Cells[1].Value;
                var asset = await unitOfWork.AssetClient.GetAsync(assetId);
                var project = await unitOfWork.ProjectClient.GetAsync(projectId);

                if (asset.IsDepreciable)
                {
                    FrmShowDepreciation frmShowDepreciation = new FrmShowDepreciation(project, asset);
                    frmShowDepreciation.ShowDialog();
                }
                else
                {
                    return;
                }
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            var assets = await unitOfWork.AssetClient.GetAllAssetAsync(DataOnMemory.ProjectId);

            var result = assets.Where(e => e.Name.Equals(txtSearchAsset.Texts, StringComparison.OrdinalIgnoreCase)
            || e.DepreciationRate.Equals(txtSearchAsset.Texts, StringComparison.OrdinalIgnoreCase));

            dtgFNE.DataSource = null;
            dtgFNE.DataSource = result.ToList();
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
            dtgFNE.Columns[8].Visible = false;
            dtgFNE.Columns[9].Visible = false;
            dtgFNE.Columns[11].Visible = false;
        }

        private void txtSearchAsset__TextChanged(object sender, EventArgs e)
        {

            if (txtSearchAsset.Texts.Equals(String.Empty))
            {
                ChargeDtg();
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtValorResidual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }
    }
}
