using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.SettingForms;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.Forms.Users
{
    public partial class FrmValidateForgotPass : Form
    {
        private IUnitOfWork unitOfWork;
        public FrmValidateForgotPass(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSuccess_Click(object sender, EventArgs e)
        {
            try
            {
                string value = MemoryOnProject.Forgot.ToString();
                if (txtCode.Texts.Equals(value))
                {
                    RecoveryPassword recover = (await unitOfWork.UserClient.RecoveryPasswordAsync(DataOnMemory.Email));

                    MessageBox.Show($"Solicitud de recuperación de contraseña {recover.Password}");
                    MessageBox.Show("Revise su correo electrónico, hemos recuperado su contraseña");
                    SingletonFrm.GetForm(FormType.Login).Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Error, código incorrecto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
