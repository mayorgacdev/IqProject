using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Contracts;
using EconomicMF.Domain.Contracts;
using EconomicMF.SettingForms;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms.Forms.Users
{
    public partial class FrmForgotPassword : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmForgotPassword(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Login).Show();
            this.Hide();
        }

        #region Functions

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        private void FrmForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await unitOfWork.UserClient.GetByEmailAsync(txtNameOrEmail.Texts);

                if (data is null)
                {
                    return;
                }
                else
                {
                    Guid code = Guid.NewGuid();
                    MemoryOnProject.Forgot = code;
                    DataOnMemory.Email = txtNameOrEmail.Texts;
                    unitOfWork.mailRepository.SendMail("Confirmación de codígo", 
                        $"Confirmarción de código no compartir con nadie \nesta información:" +
                        $" {code.ToString()}", new List<string>() { data.Email });

                    SingletonFrm.GetForm(FormType.ValidateUser).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
