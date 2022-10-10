using EconomicMF.Domain.Contracts;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCInversor : UserControl
    {
        private readonly IUnitOfWork IUnitOfWork;
        private readonly int inversorId;

        public UCInversor(IUnitOfWork unitOfWork, int inversorId)
        {
            InitializeComponent();
            this.IUnitOfWork = unitOfWork;
            this.inversorId = inversorId;
        }

        private void ChargeLabels()
        {
            //var data = projectServices.GetByIdEntidad(idInversor);
            //lblNameInversor.Text = data.Name;
            //pbProfileImage.Image = ByteArrayToImage(data.ProfileImage);
        }

        private Image ByteArrayToImage(byte[] source)
        {
            MemoryStream ms = new MemoryStream(source);
            Image ret = Image.FromStream(ms);
            return ret;
        }

        private void UCInversor_Load(object sender, EventArgs e)
        {
            ChargeLabels();
        }
    }
}
