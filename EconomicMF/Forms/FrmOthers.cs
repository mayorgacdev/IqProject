using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.SettingForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmOthers : Form
    {
        private readonly IUnitOfWork unitOfWork;

        public FrmOthers(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            int id = 0;
            if ((int)dtgFNE.Rows.Count > 0)
                id = (int)dtgFNE.Rows[dtgFNE.CurrentRow.Index].Cells[0].Value;

            DataOnMemory.ActivoId = id;
            SingletonFrm.GetForm(FormType.ResolveDepreciation).Show();
        }

        private void FrmOthers_Load(object sender, EventArgs e)
        {
   
            cmbTipoDeCalculos.Items.AddRange(Enum.GetValues(typeof(TipoDeCalculo)).Cast<object>().ToArray());
            cmbTipoAmortizaciónAmrt.Items.AddRange(Enum.GetValues(typeof(TipoDeAmortizacion)).Cast<object>().ToArray());
            cmbVidaActivosAsset.Items.AddRange(Enum.GetValues(typeof(VidaUtilActivos)).Cast<object>().ToArray());
            cmbTipoMetodoAsset.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());

            cmbTipoDeCalculos.SelectedIndex = 1;
            ValidateCmb();
        }

        private void cmbTipoDeCalculos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateCmb();
        }

        private void ValidateCmb()
        {
            if (cmbTipoDeCalculos.SelectedItem is TipoDeCalculo.Amortización)
            {
                cmbTipoMetodoAsset.Visible = false;
                cmbVidaActivosAsset.Visible = false;
                lblAñosComoNiAsset.Visible = false;
                lblDepreciaciónAsset.Visible = false;
                lblMontoAsset.Visible = false;
                lblTipoAsset.Visible = false;
                tgDepreciacionAsset.Visible = false;
                tglsVidaDeActivoAsset.Visible = false;
                txtVidaUtil.Visible = false;
                txtValorResidualAsset.Visible = false;
                lblValorResidualAsset.Visible = false;
                lblValorResidualAsset.Visible = false;
                lblTipoDeMetodoAsset.Visible = false;

                cmbTipoAmortizaciónAmrt.Visible = true;
                lblAñoAmrt.Visible = true;
                lblInteresAmrt.Visible = true;
                lblTipoMetodoAmrt.Visible = true;
                lbMontoAmrt.Visible = true;
                nupAportacionAmrt.Visible = true;
                txtAñosAmrt.Visible = true;
                txtInteresPrestamoAmrt.Visible = true;
            }
            else
            {
                cmbTipoAmortizaciónAmrt.Visible = false;
                lblAñoAmrt.Visible = false;
                lblInteresAmrt.Visible = false;
                lblTipoMetodoAmrt.Visible = false;
                lbMontoAmrt.Visible = false;
                nupAportacionAmrt.Visible = false;
                txtAñosAmrt.Visible = false;
                txtInteresPrestamoAmrt.Visible = false;

                cmbTipoMetodoAsset.Visible = true;
                cmbVidaActivosAsset.Visible = true;
                lblAñosComoNiAsset.Visible = true;
                lblDepreciaciónAsset.Visible = true;
                lblMontoAsset.Visible = true;
                lblTipoAsset.Visible = true;
                lblValorResidualAsset.Visible = true;
                tgDepreciacionAsset.Visible = true;
                tglsVidaDeActivoAsset.Visible = true;
                txtVidaUtil.Visible = true;
                lblValorResidualAsset.Visible = true;
                lblValorResidualAsset.Visible = true;
                txtValorResidualAsset.Visible = true;
                lblTipoDeMetodoAsset.Visible = true;
            }
        }

        private void dtgFNE_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
