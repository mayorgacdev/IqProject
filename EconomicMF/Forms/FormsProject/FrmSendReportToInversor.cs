using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Windows.Graphics.Printing.PrintTicket;

namespace EconomicMF.Forms.FormsProject
{
    public partial class FrmSendReportToInversor : Form
    {
        List<string> paths;
        private IUnitOfWork unitOfWork;
        private string typeOfPath = String.Empty;
        public FrmSendReportToInversor(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            paths = new List<string>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            unitOfWork.MailClient.SenFiles("Envío de archivos de proyecto",
                bodyMessage.Text, new List<string> { txtEmail.Texts });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Texts.Equals(String.Empty))
                {
                    throw new Exception("Por favor agrega el email");
                }

                if (unitOfWork.MailClient.IsValidEmail(txtEmail.Texts))
                {
                    string ruta = "";
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        typeOfPath = "Any Files|*.BMP;*.JPG;*.GIF;*.PNG;*.doc;*.xls;*.ppt;*.pdf";

                        openFileDialog.Filter = typeOfPath;
                        openFileDialog.Title = "Open file";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            ruta = openFileDialog.FileName;
                        }
                    }

                    unitOfWork.MailClient.AddMessage(new EmailProp() { Email = txtEmail.Texts, Ruta = ruta });

                    FrmShowReceptor frmShowReceptor = new FrmShowReceptor(unitOfWork);
                    frmShowReceptor.ShowDialog();
                }
                else
                {
                    throw new Exception("El correo al que desea enviar el mensaje no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
