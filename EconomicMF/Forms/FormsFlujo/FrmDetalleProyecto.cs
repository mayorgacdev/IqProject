using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.DTO;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmDetalleProyecto : Form
    {
        private readonly IUnitOfWork projectServices;
        private int idSolution;
        public FrmDetalleProyecto(IUnitOfWork projectServices)
        {
            InitializeComponent();
            this.projectServices = projectServices;
            this.idSolution = DataOnMemory.SolutionId;
        }

        private FlujoGeneral GetFlujoGeneral()
        {
            Random random1 = new Random();
            // TODO: Get project by solution Id
            var project = projectServices.ProjectClient.GetAsync(idSolution);

            return new()
            {
                /*
                Id = random1.Next(1, 10),
                costoGenerals = ProjectCalculations.GetCostoGenerals(project),
                ingresosGenerals = ProjectCalculations.GetIngresosGenerals(project),
                activosGenerals = ProjectCalculations.GetActivosGenerals(project),
                gastosGenerals = ProjectCalculations.GetGastosGenerals(project),
                prestamosGenereals = ProjectCalculations.GetPrestamosGenerals(project),*/
            };
        }

        private void FrmDetalleProyecto_Load(object sender, EventArgs e)
        {
            dtgFNE.DataSource = ProjectCalculations.GetDataDTO(GetFlujoGeneral());
        }
    }
}
