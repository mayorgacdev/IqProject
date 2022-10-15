using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ChargeDtg()
        {
            dtgFNE.DataSource = await unitOfWork.ProjectExpense.GetAllExpenses(DataOnMemory.ProjectId);
        }
    }
}
