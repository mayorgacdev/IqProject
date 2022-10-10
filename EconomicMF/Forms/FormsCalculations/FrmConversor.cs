using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Conversiones;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmConversor : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private string userEmail;
        private FrecuenciaTasa frecuenciaTasa;
        public decimal tasaconvertida;

        public FrmConversor(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        public FrmConversor(FrecuenciaTasa frecuenciaTasa)
        {
            InitializeComponent();
            this.frecuenciaTasa = frecuenciaTasa;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConversor_Load(object sender, EventArgs e)
        {
            cmbInteresActual.DataSource = Enum.GetValues(typeof(TipoTasa));
            cmbInteresOriginal.DataSource = Enum.GetValues(typeof(TipoTasa));
            cmbFrecOriginal.DataSource = Enum.GetValues(typeof(Periodo));
            cmbFrecActual.DataSource = Enum.GetValues(typeof(Periodo));
            if (unitOfWork is null)
            {
                //el valor final va a estar dado por la frecuencia de pago del interes y la tasa es efectiva
                cmbInteresActual.SelectedIndex = (int)TipoTasa.Efectiva;
                cmbInteresActual.Enabled = false;
                cmbFrecActual.SelectedIndex = (int)frecuenciaTasa;
                cmbFrecActual.Enabled = false;
            }
        }

        private async void btnAddFlow_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = 0;
                VerificarIgualdad();
                //TODO: Add conversor to FRMSHOW
                if (decimal.Parse(txtOriginal.Texts) <= 0)
                {
                    throw new ArgumentException("La tasa de interes no puede ser menor o igual a 0");
                }
                if (unitOfWork != null)
                {
                    User user = await unitOfWork.UserClient.GetByEmailAsync(userEmail);
                    if (user is null)
                    {
                        throw new Exception("Este usuario no existe");
                    }
                    idUsuario = user.Id;
                }
                ConversionDto conversion = new ConversionDto()
                {
                    TasaOriginal = decimal.Parse(txtOriginal.Texts) / 100,
                    TipoOriginal = (TipoTasa)cmbInteresOriginal.SelectedItem,
                    TipoActual = (TipoTasa)cmbInteresActual.SelectedItem,
                    FrecCapOriginal = GetFrecuencia(cmbFrecOriginal),
                    FrecCapActual = GetFrecuencia(cmbFrecActual),
                    CapitalizacionActual = GetNumCap(cmbFrecActual, (TipoTasa)cmbInteresActual.SelectedItem),
                    CapitalizacionOriginal = GetNumCap(cmbFrecOriginal, (TipoTasa)cmbInteresOriginal.SelectedItem),
                    //es 0 si el formulario se usa para convertir tasas que se ocupan en otros formularios
                    UserId = idUsuario
                };
                conversion.TasaActual = ConversionesFactory.VerConversion(conversion).Convertir(conversion);
                txtActual.Texts = (conversion.TasaActual * 100).ToString();
                if (unitOfWork is not null)
                {
                    await unitOfWork.ConversionClient.CreateAsync(conversion); 
                }
                else
                {
                    tasaconvertida = conversion.TasaActual * 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void VerificarIgualdad()
        {
            if (cmbInteresOriginal.SelectedValue.Equals(cmbInteresActual.SelectedValue) && 
                cmbFrecActual.SelectedValue.Equals(cmbFrecOriginal.SelectedValue))
            {
                throw new ArgumentException("La conversion es innecesaria");
            }
        }

        private void cmbInteresOriginal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbInteresOriginal.SelectedItem.Equals(TipoTasa.Nominal))
            {
                cmbFrecOriginal.DataSource = Enum.GetValues(typeof(Periodo));
            }
            else
            {
                cmbFrecOriginal.DataSource = Enum.GetValues(typeof(FrecTasaNom));
            }
        }

        private void cmbInteresActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbInteresActual.SelectedItem.Equals(TipoTasa.Nominal))
            {
                cmbFrecActual.DataSource = Enum.GetValues(typeof(Periodo));
            }
            else
            {
                cmbFrecActual.DataSource = Enum.GetValues(typeof(FrecTasaNom));
            }
        }
        private FrecuenciaTasa GetFrecuencia(ComboBox comboBox)
        {
            string nombre = comboBox.SelectedValue.ToString();
            return (FrecuenciaTasa)Enum.Parse(typeof(FrecuenciaTasa), nombre);
        }
        private int GetNumCap(ComboBox comboBox, TipoTasa tipoTasa)
        {
            string nombre = comboBox.SelectedValue.ToString();
            if (tipoTasa.Equals(TipoTasa.Nominal))
            {
                return (int)Enum.Parse(typeof(FrecTasaNom), nombre);
            }
            return 1;
        }
    }
}
