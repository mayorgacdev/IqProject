using EconomicMF.Domain.Contracts;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    
    public partial class FrmExportProject : Form
    {
        private IUnitOfWork unitOfWOrk;
        public FrmExportProject(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWOrk = unitOfWork;
        }
    }
}
