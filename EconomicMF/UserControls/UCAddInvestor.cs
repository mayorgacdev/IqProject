using EconomicMF.Domain.Contracts;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCAddInvestor : UserControl
    {
        private IUnitOfWork projectServices;
        private int idEntidad;
        public UCAddInvestor(IUnitOfWork projectServices, int idEntidad)
        {
            InitializeComponent();
            this.projectServices = projectServices;
            this.idEntidad = idEntidad;
        }

        private void UCAddInvestor_Load(object sender, EventArgs e)
        {
            var data = projectServices.InvesmentEntityClient.GetAsync(idEntidad);
            lblNameInversor.Text = data.Result.Name;
            //cpImageInversor.Image = ByteArrayToImage(data.ProfileImage);
            //lblAportación.Text = data.Aportacion.ToString();
        }

        private Image ByteArrayToImage(byte[] source)
        {
            MemoryStream ms = new MemoryStream(source);
            Image ret = Image.FromStream(ms);
            return ret;
        }
    }
}
