using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Conversiones;
using EconomicMF.Helper;
using RJCodeAdvance.RJControls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmConversor : Form
    {
        #region move
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        private readonly IUnitOfWork unitOfWork;
        private string userEmail;
        private FrecuenciaTasa frecuenciaTasa;
        public decimal tasaconvertida;
        private bool usoOtroform;
        public FrmConversor(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        public FrmConversor(FrecuenciaTasa frecuenciaTasa, IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.frecuenciaTasa = frecuenciaTasa;
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
            this.usoOtroform = true;
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
            if (usoOtroform)
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
                int idUsuario=0;
                Validar();
                //TODO: Add conversor to FRMSHOW
                if (decimal.Parse(txtOriginal.Texts) <= 0)
                {
                    throw new ArgumentException("La tasa de interes no puede ser menor o igual a 0");
                }
                User user = await unitOfWork.UserClient.GetByEmailAsync(userEmail);
                if (user is null)
                {
                    throw new Exception("Este usuario no existe");
                }
                idUsuario = user.Id;
                ConversionDto conversion = new ConversionDto()
                {
                    TasaOriginal = decimal.Parse(txtOriginal.Texts) / 100,
                    TipoOriginal = (TipoTasa)cmbInteresOriginal.SelectedItem,
                    TipoActual = (TipoTasa)cmbInteresActual.SelectedItem,
                    FrecCapOriginal = GetFrecuencia(cmbFrecOriginal),
                    FrecCapActual = GetFrecuencia(cmbFrecActual),
                    CapitalizacionActual = GetNumCap(cmbFrecActual, (TipoTasa)cmbInteresActual.SelectedItem),
                    CapitalizacionOriginal = GetNumCap(cmbFrecOriginal, (TipoTasa)cmbInteresOriginal.SelectedItem),
                    UserId = idUsuario,
                };
                conversion.TasaActual = ConversionesFactory.VerConversion(conversion).Convertir(conversion);
                conversion.TasaActual = Math.Round(conversion.TasaActual, 4);
                txtActual.Texts = (conversion.TasaActual * 100).ToString();
                await unitOfWork.ConversionClient.CreateAsync(conversion);
                tasaconvertida = conversion.TasaActual * 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
            //// solo 1 punto decimal
            //if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
            Validation.ValidateDecimalnotNegative(sender, e);
        }
        private void Validar()
        {
            if (cmbInteresOriginal.SelectedValue.Equals(cmbInteresActual.SelectedValue) && 
                cmbFrecActual.SelectedValue.Equals(cmbFrecOriginal.SelectedValue))
            {
                throw new ArgumentException("La conversion es innecesaria");
            }
            if (string.IsNullOrWhiteSpace(txtOriginal.Texts))
            {
                throw new ArgumentException("No se colocó ninguna tasa para convertir");
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

        private void FrmConversor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
