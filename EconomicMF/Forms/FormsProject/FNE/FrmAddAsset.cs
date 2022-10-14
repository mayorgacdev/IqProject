using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.Services;
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
            tglsVidaDeActivo.Checked = true;
            cmbVidaActivos.Items.AddRange(Enum.GetValues(typeof(VidaUtilActivos)).Cast<object>().ToArray());
            cmbTipoMetodo.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());
        }

        private void tglsVidaDeActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (tglsVidaDeActivo.Checked)
            {
                cmbVidaActivos.Visible = true;
                txtVidaUtil.Visible = false;
            }
            else
            {
                cmbVidaActivos.Visible = false;
                txtVidaUtil.Visible = true;
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
                            AmountResidual = decimal.Parse(txtValorResidual.Texts),
                            Terms = CalculusOnMemory.GetTerms((VidaUtilActivos)cmbVidaActivos.SelectedItem),
                            DepreciationRate = "No se puede depreciar",
                            Code = Guid.NewGuid().ToString(),
                            AñosDeDepreciaciónSegunNi = tglsVidaDeActivo.Checked,
                            Status = "Activo",
                            IsActive = true,
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
                            IsActive = true,
                        };

                        await unitOfWork.AssetClient.SetAssetAsync(asset);
                        ChargeDtg();
                    }
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
                        Terms = int.Parse(txtMonto.Texts),
                        DepreciationRate = cmbTipoMetodo.SelectedItem.ToString(),
                        Code = Guid.NewGuid().ToString(),
                        AñosDeDepreciaciónSegunNi = tglsVidaDeActivo.Checked,
                        Status = "Activo",
                        IsActive = true,
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
            dtgFNE.DataSource = await unitOfWork.AssetClient.GetAllAssetAsync(DataOnMemory.ProjectId);
        }

        private void cmbVidaActivos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVidaActivos.SelectedIndex > -1 && cmbVidaActivos != null)
            {
                txtName.Texts = CalculusOnMemory.GetName((VidaUtilActivos)cmbVidaActivos.SelectedItem);
            }
        }
    }
}
