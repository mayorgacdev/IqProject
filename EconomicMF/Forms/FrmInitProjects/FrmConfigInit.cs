using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FrmInitProjects
{
    public partial class FrmConfigInit : Form
    {
        private IUnitOfWork unitOfWork;
        public FrmConfigInit(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private async void FrmConfigInit_Load(object sender, System.EventArgs e)
        {
            var user = await unitOfWork.UserClient.GetAsync(DataOnMemory.UserId);
            txtNameUser.Texts = user.Name;
            txtPhone.Texts = user.PhoneNumber;
            txtDNI.Texts = user.Dni;

            TgBtnActive(false);
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void tgUpdatePassword_CheckedChanged_1(object sender, System.EventArgs e)
        {
            TgBtnActive(tgUpdatePassword.Checked);
        }

        private void TgBtnActive(bool isUse)
        {
            if (tgUpdatePassword.Checked)
            {

                lblContraseñaNueva.Visible = isUse;
                txtContraseñaNueva.Visible = isUse;
            }
            else
            {

                lblContraseñaNueva.Visible = isUse;
                txtContraseñaNueva.Visible = isUse;
            }
        }

        private async void btnDesactivar_Click(object sender, System.EventArgs e)
        {

            if (txtConfirmar.Texts.Equals(String.Empty))
            {
                throw new Exception("Por favor introduzca la contraseña");
            }

            var user = await unitOfWork.UserClient.GetByEmailAsync(DataOnMemory.Email);

            user.State = false;

            bool exist = await unitOfWork.UserClient.AccessToAppAsync(user.Email.ToString(), txtConfirmar.Texts);

            await unitOfWork.UserClient.UpdateAsync(new User()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Dni = user.Dni,
                Password = txtConfirmar.Texts,
                State = user.State,
                Creation = user.Creation,
            });

            Application.Exit();
        }

        private async void btnActualizar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (tgUpdatePassword.Checked)
                {
                    var user = await unitOfWork.UserClient.GetByEmailAsync(DataOnMemory.Email);
                    user.Name = txtNameUser.Texts;
                    user.PhoneNumber = txtPhone.Texts;
                    user.Dni = txtDNI.Texts;

                    bool exist = await unitOfWork.UserClient.AccessToAppAsync(user.Email.ToString(), txtConfirmar.Texts);

                    if (exist)
                    {
                        await unitOfWork.UserClient.UpdateAsync(new User()
                        {
                            Id = user.Id,
                            Name = user.Name,
                            Email = user.Email,
                            PhoneNumber = user.PhoneNumber,
                            Dni = user.Dni,
                            Password = txtContraseñaNueva.Texts,
                            State = user.State,
                            Creation = user.Creation,
                        });
                        MessageBox.Show("Actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos, verifique su contraseña");
                    }
                }
                else
                {
                    var user = await unitOfWork.UserClient.GetByEmailAsync(DataOnMemory.Email);
                    user.Name = txtNameUser.Texts;
                    user.PhoneNumber = txtPhone.Texts;
                    user.Dni = txtDNI.Texts;

                    bool exist = await unitOfWork.UserClient.AccessToAppAsync(user.Email.ToString(), txtConfirmar.Texts);

                    if (exist)
                    {
                        await unitOfWork.UserClient.UpdateAsync(new User()
                        {
                            Id = user.Id,
                            Name = user.Name,
                            Email = user.Email,
                            PhoneNumber = user.PhoneNumber,
                            Dni = user.Dni,
                            Password = txtConfirmar.Texts,
                            State = user.State,
                            Creation = user.Creation,
                        });
                        MessageBox.Show("Actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos, verifique su contraseña");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
