using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.SettingForms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms.Forms.Users;

public partial class FrmLogin : Form
{
    #region INIT: Unit Of work

    private readonly IUnitOfWork unitOfWork;
    
    public FrmLogin(IUnitOfWork unitOfWork)
    {
        InitializeComponent();
        this.unitOfWork = unitOfWork;
    }

    #endregion

    #region Function: Button MouseDown, BtnClose

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
        Application.Exit();
    }

    private void LogOut(object sender, FormClosedEventArgs e)
    {
        this.Show();
    }
    #endregion

    private async void btnIniciarSesión_Click(object sender, EventArgs e)
    {
        try
        {
            /*
            bool exist = await unitOfWork.UserClient.ExistEmailAsync(txtUserOrEmail.Texts);

            if (!exist)
            {
                throw new Exception("Registrate o verifica tu correo nuevamente");
            }*/

            bool access = await unitOfWork.UserClient.AccessToAppAsync(txtUserOrEmail.Texts, txtPassword.Texts);

            if (access)
            {
                #region UserDAO

                var usuario = await unitOfWork.UserClient.GetByEmailAsync(txtUserOrEmail.Texts);
                
                DataOnMemory.UserId = usuario.Id;
                DataOnMemory.Email = usuario.Email;
                DataOnMemory.Password = usuario.Password;
                DataOnMemory.FirstName = usuario.Name;
                DataOnMemory.PhoneNumber = usuario.PhoneNumber;

                #endregion
                
                SingletonFrm.GetForm(FormType.Solution).Show();
                this.Hide();

            }
            else
            {
                throw new Exception("Contraseña incorrecta");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRegistrarse_Click(object sender, EventArgs e)
    {
        SingletonFrm.GetForm(FormType.Register).Show();
        this.Hide();
    }

    private void btnForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        SingletonFrm.GetForm(FormType.ForgotPassword).Show();
        this.Hide();
    }
}