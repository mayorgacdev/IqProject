using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Helper;
using EconomicMF.SettingForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EconomicMF.Forms.Forms.Users;

public partial class FrmRegister : Form
{
    #region INIT Unit of work

    private readonly IUnitOfWork unitOfWork;

    public FrmRegister(IUnitOfWork unitOfWork)
    {
        InitializeComponent();
        this.unitOfWork = unitOfWork;
    }

    #endregion

    #region Buttons: BtnClose and MouseDownPanel

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void panelUser_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        SingletonFrm.GetForm(FormType.Login).Show();
        this.Hide();
    }

    #endregion

    private async void btnSubmit_Click(object sender, EventArgs e)
    {   
        try
        { 
            //Validation.ValidateRegister(txtName.Texts, txtDNI.Texts, txtPhone.Texts, txtEmail.Texts, txtPassword.Texts);

            User user = new User()
            {
                Name = txtName.Texts,
                Password = txtPassword.Texts,
                Email = txtEmail.Texts,
                PhoneNumber = txtPhone.Texts,
                State = true,
                Creation = DateTime.UtcNow,
                Dni = txtDNI.Texts,
            };

            bool exist = await unitOfWork.UserClient.ExistEmailAsync(user.Email);

            if (exist)
            {
                throw new Exception("Este correo ya está en uso... seleccione otro");
            }
            
            DataOnMemory.userDto = user;    
            DataOnMemory.Email = user.Email;
            DataOnMemory.Password = user.Password;
            DataOnMemory.FirstName = user.Name;
            DataOnMemory.PhoneNumber = user.PhoneNumber;

            SingletonFrm.GetForm(FormType.ValidateRegister).Show();
            
            Guid code = Guid.NewGuid();
            MemoryOnProject.Guid = code;
            unitOfWork.MailClient.SenFiles("Confirmación de codígo", $"Confirmarción de código no compartir con nadie \nesta información: {code}", new List<string>() { txtEmail.Texts });

            this.Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region OtherFunctionsNotImportants

    private void btnImage_Click(object sender, EventArgs e)
    {
        //CargarImagen(btnImage);
    }

    #endregion
}
