using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        {
            Charge();
        }

        private async void Charge()
        {
            cmbPeriodo.Items.AddRange(Enum.GetValues(typeof(Periodo)).Cast<object>().ToArray());
            cmbTipoAmortizacion.Items.AddRange(Enum.GetValues(typeof(TipoDeAmortizacion)).Cast<object>().ToArray());

            dtgFNE.DataSource = null;
            var projectSolutions = (await unitOfWork.ProjectClient.GetProjectsAsync(DataOnMemory.SolutionId));
            var forDtgFne = from e in projectSolutions select new { e.Id, e.Name, e.Duration, e.WithFinancing, e.TMAR, e.TMARMixta, e.Contribution, e.Period };
            dtgFNE.DataSource = forDtgFne.ToList();


            if (dtgFNE.Rows.Count > 0)
            {
                dtgXD.DataSource = null;
                var test = dtgFNE.Rows[0].Cells[0].Value;
                int projectId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                dtgXD.DataSource = (from e in (await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(projectId)) 
                                           select new { e.Id, e.ProjectId, e.Name, e.Contribution, e.Rate, e.TipoDeAmortización, e.Email, e.LoanTerm}).ToList();
                dtgXD.Columns[0].Visible = false;
                dtgFNE.Columns[0].Visible = false;
            }
        }

        private async void dtgFNE_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgFNE.Rows.Count > 0)
            {
                int projectId = (int)dtgFNE.Rows[e.RowIndex].Cells[0].Value;
                string? projectName = dtgFNE.Rows[e.RowIndex].Cells[1].Value.ToString();
                int duration = (int)dtgFNE.Rows[e.RowIndex].Cells[2].Value;
                bool withFinancing = (bool)dtgFNE.Rows[e.RowIndex].Cells[3].Value;
                decimal tmar = (decimal)dtgFNE.Rows[e.RowIndex].Cells[4].Value;
                decimal tmarMixta = (decimal)dtgFNE.Rows[e.RowIndex].Cells[5].Value;
                decimal contribution = (decimal)dtgFNE.Rows[e.RowIndex].Cells[6].Value;
                string? period = dtgFNE.Rows[e.RowIndex].Cells[7].Value.ToString();

                cmbPeriodo.SelectedItem = period;
                nupContribution.Value = contribution;
                nupDuration.Value = duration;
                nupTMAR.Value = tmar;
                tgIsFinancement.Checked = withFinancing;

                dtgXD.DataSource = (from inv in (await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(projectId))
                                    select new { inv.Id, inv.ProjectId, inv.Name, inv.Contribution, inv.Rate, inv.TipoDeAmortización, inv.Email, inv.LoanTerm }).ToList();
            }
               
        }

        private void dtgXD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgXD.Rows.Count > 0)
            { 
                string? tipoAmortizacion = dtgXD.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (tipoAmortizacion.Equals(TipoDeAmortizacion.AmortizacionNivelada.ToString()))
                {
                    cmbPeriodo.SelectedIndex = 0;
                }
                else
                {
                    cmbPeriodo.SelectedIndex = 1;   
                }
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{=
                if (dtgFNE.SelectedRows.Count >= 1)
                {
                    int projectId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                    await unitOfWork.ProjectClient.DeleteAsync(projectId);
                    Charge();
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Por favor seleccione la celda correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgXD.SelectedRows.Count == 1)
                {
                    int investmentId = (int)dtgXD.CurrentRow.Cells[0].Value;
                    InvesmentEntity invesmentEntity = await unitOfWork.InvesmentEntityClient.GetAsync(investmentId);
                    ProjectClient projectClient = await unitOfWork.ProjectClient.GetAsync(invesmentEntity.ProjectId);

                    projectClient.Contribution += invesmentEntity.Contribution;

                    await unitOfWork.InvesmentEntityClient.DeleteAsync(investmentId);

                    if (projectClient.Contribution == 100)
                    {
                        projectClient.WithFinancing = false;
                        await unitOfWork.ProjectClient.UpdateAsync(projectClient);
                    }

                    await unitOfWork.ProjectClient.UpdateAsync(projectClient);
                    Charge();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor seleccione la celda correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUdpateMethodAmortization_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgXD.SelectedRows.Count == 1)
                {
                    int investmentId = (int)dtgXD.CurrentRow.Cells[0].Value;
                    InvesmentEntity invesmentEntity = await unitOfWork.InvesmentEntityClient.GetAsync(investmentId);
                    
                    if (invesmentEntity.TipoDeAmortización != cmbTipoAmortizacion.SelectedItem.ToString())
                    {
                        invesmentEntity.TipoDeAmortización = cmbTipoAmortizacion.SelectedItem.ToString();
                        await unitOfWork.InvesmentEntityClient.UpdateAsync(invesmentEntity);
                        Charge();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor seleccione la celda correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
