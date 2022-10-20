using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Helper;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddExpense : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmAddExpense(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmAddExpense_Load(object sender, EventArgs e)
        {
            ChargeDtg();
            cmbTipodeCrecimiento.Items.AddRange(Enum.GetValues(typeof(TipoCrecimiento)).Cast<object>().ToArray());
        }

        private void cmbTipodeCrecimiento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TipoCrecimiento)cmbTipodeCrecimiento.SelectedItem is TipoCrecimiento.SinCrecimiento)
            {
                lblCrecimiento.Visible = false;
                txtCrecimiento.Visible = false;
            }
            else
            {
                lblCrecimiento.Visible = true;
                txtCrecimiento.Visible = true;
            }
        }
        private void Limpiar()
        {
            txtCosto.Texts = "";
            txtCrecimiento.Texts = "";
            txtEnd.Texts = "";
            txtStart.Texts = "";
            txtTipoDeCosto.Texts = "";
            cmbTipodeCrecimiento.Texts = "";
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var N = await unitOfWork.ProjectClient.GetAsync(DataOnMemory.ProjectId);
                Validation.ValidateStarEnd(int.Parse(txtStart.Texts), int.Parse(txtEnd.Texts), N.Duration);
                TipoCrecimiento crecimiento = (TipoCrecimiento)cmbTipodeCrecimiento.SelectedItem;
                if (crecimiento != TipoCrecimiento.SinCrecimiento && crecimiento
                    is TipoCrecimiento.Aritmetico || crecimiento is TipoCrecimiento.Geometrico)
                {
                    ProjectExpense projectExpense = new ProjectExpense()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Expense = Math.Round(decimal.Parse(txtCosto.Texts), 2),
                        Growth = Math.Round(decimal.Parse(txtCrecimiento.Texts), 2),
                        TypeGrowth = cmbTipodeCrecimiento.SelectedItem.ToString(),
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        TypeExpense = txtTipoDeCosto.Texts,

                    };

                    await unitOfWork.ProjectExpense.SetExpense(projectExpense);

                    ChargeDtg();
                }
                else
                {
                    ProjectExpense projectExpense = new ProjectExpense()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Expense = Math.Round(decimal.Parse(txtCosto.Texts), 2),
                        Growth = 0,
                        TypeGrowth = "SinCrecimiento",
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        TypeExpense = txtTipoDeCosto.Texts,

                    };

                    await unitOfWork.ProjectExpense.SetExpense(projectExpense);

                    ChargeDtg();
                }
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ChargeDtg()
        {
            dtgFNE.DataSource = null;
            dtgFNE.DataSource = await unitOfWork.ProjectExpense.GetAllExpenses(DataOnMemory.ProjectId);
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1 && dtgFNE.CurrentRow != null)
            {
                int expenseId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                await unitOfWork.ProjectExpense.DeleteAsync(expenseId);
                ChargeDtg();
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Equals(string.Empty))
            {
                ChargeDtg();
            }
        }

        private async void btnFInd_Click(object sender, EventArgs e)
        {
            var assets = await unitOfWork.ProjectExpense.GetAllExpenses(DataOnMemory.ProjectId);
            decimal.TryParse((txtSearch.Texts), out decimal get);

            var result = assets.Where(e => e.TypeExpense.Equals(txtSearch.Texts, StringComparison.OrdinalIgnoreCase)
            || e.Expense >= get || e.Growth >= get);

            dtgFNE.DataSource = null;
            dtgFNE.DataSource = result.ToList();
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtCrecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateDecimalNegative(sender, e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validation.ValidateDecimalnotNegative(sender, e);
        }
    }
}
