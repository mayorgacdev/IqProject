using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Others;
using EconomicMF.SettingForms;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmOthers : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly int solutionId;

        public FrmOthers(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.solutionId = DataOnMemory.SolutionId;
            this.unitOfWork = unitOfWork;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Activo activo = new()
            {
                Nombre = txtNombre.Texts,
                SolutionId = solutionId,
                Precio = decimal.Parse(txtPrecio.Texts),
                Tiempo = int.Parse(txtTiempo.Texts),
                ValorResidual = decimal.Parse(txtValorResidual.Texts),
                Descripcion = txtDescripcion.Texts,
                Creación = DateTime.UtcNow,
            };

            //solutionServices.SetActivoToSolution(activo, solutionId);
            Charge();
        }

        private void Charge()
        {
            //if (solutionServices.GetAllActivoById(solutionId) is null)
            //{
            //    return;
            //}

            //dtgvDepreciación.DataSource = solutionServices.GetAllActivoById(solutionId);
        }

        private void FrmOthers_Load(object sender, EventArgs e)
        {
            Charge();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            int id = 0;
            if ((int)dtgvDepreciación.Rows.Count > 0)
                id = (int)dtgvDepreciación.Rows[dtgvDepreciación.CurrentRow.Index].Cells[0].Value;

            DataOnMemory.ActivoId = id;
            SingletonFrm.GetForm(FormType.ResolveDepreciation).Show();
        }
    }
}
