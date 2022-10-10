using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.SettingForms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms.Forms.Users
{
    public partial class frmValidateUser : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private User user;
        public frmValidateUser(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            user = DataOnMemory.userDto;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Register);
            this.Hide();
        }

        private async void btnSuccess_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Texts.Equals(MemoryOnProject.Guid.ToString()))
                {
                    await unitOfWork.UserClient.CreateAsync(user);
                    await unitOfWork.UserClient.GetByEmailAsync(user.Email);

                    DataOnMemory.UserId = user.Id;

                    SingletonFrm.GetForm(FormType.Solution).Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Código incorrecto, intentenlo nuevamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmValidateUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
