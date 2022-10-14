using EconomicMF.Domain.Contracts;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmInversors : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmInversors(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmInversors_Load(object sender, EventArgs e)
        { }
    }
}
