using EconomicMF.AppCore.Contracts;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCProjectInvestor : UserControl
    {
        private readonly IUnitOfWork _context;
        private readonly int projectId;
        public UCProjectInvestor(IUnitOfWork _context, int projectId)
        {
            InitializeComponent();
            this._context = _context;
            this.projectId = projectId;
        }

        private async void ChargeData()
        {
            var project = await _context.ProjectClient.GetAsync(projectId);
            lblDuracion.Text = project.Duration.ToString();
            lblNombre.Text = project.Name.ToString();
            lblPeriodo.Text = project.Period.ToString();
            //lblValorResidual.Text = project.ValorResidual.ToString();
        }

        private void UCProjectInvestor_Load(object sender, System.EventArgs e)
        {
            ChargeData();
        }
    }
}
