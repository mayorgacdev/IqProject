using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Helper;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddEntry : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmAddEntry(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            ChargeDtg();
            cmbTipodeCrecimiento.Items.AddRange(Enum.GetValues(typeof(TipoCrecimiento)).Cast<object>().ToArray());
        }

        private void cmbTipodeCrecimiento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipodeCrecimiento.SelectedIndex >= 0)
            {
                cmbTipodeCrecimiento.Visible = true;
                lblIngreso.Location = new Point(493, 226);
            }
            else
            {
                cmbTipodeCrecimiento.Visible = false;
                lblIngreso.Location = new Point(387, 226);
                txtCrecimiento.Size = new Size(800, 39);
            }

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

        private async void ChargeDtg()
        {
            dtgFNE.DataSource = null;
            dtgFNE.DataSource = await unitOfWork.ProjectEntryClient.GetEntriesAsync(DataOnMemory.ProjectId);
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }
        private void Limpiar()
        {
            txtIngreso.Texts = "";
            txtCrecimiento.Texts = "";
            txtEnd.Texts = "";
            txtStart.Texts = "";
            txtTipoIngreso.Texts = "";
            cmbTipodeCrecimiento.Texts = "";
        }

            private async void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var N = await unitOfWork.ProjectClient.GetAsync(DataOnMemory.ProjectId);
                Validation.ValidateStarEnd(int.Parse(txtStart.Texts), int.Parse(txtEnd.Texts), N.Duration);
                TipoCrecimiento crecimiento = (TipoCrecimiento)cmbTipodeCrecimiento.SelectedItem;
                if (crecimiento != TipoCrecimiento.SinCrecimiento && crecimiento
                    is TipoCrecimiento.Aritmetico || crecimiento is TipoCrecimiento.Geometrico)
                {
                    ProjectEntry projectEntry = new ProjectEntry()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Entry = Math.Round(decimal.Parse(txtIngreso.Texts)),
                        Growth = Math.Round(decimal.Parse(txtCrecimiento.Texts)),
                        TypeGrowth = cmbTipodeCrecimiento.SelectedItem.ToString(),
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        EntryType = txtTipoIngreso.Texts,

                    };

                    await unitOfWork.ProjectEntryClient.SetEntriesAsync(projectEntry);

                    ChargeDtg();
                }
                else
                {
                    ProjectEntry projectEntry = new ProjectEntry()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Entry = Math.Round(decimal.Parse(txtIngreso.Texts), 2),
                        Growth = 0,
                        TypeGrowth = "SinCrecimiento",
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        EntryType = txtTipoIngreso.Texts,

                    };

                    await unitOfWork.ProjectEntryClient.SetEntriesAsync(projectEntry);

                    ChargeDtg();
                }
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1 && dtgFNE.CurrentRow != null)
            {
                int entryId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                await unitOfWork.ProjectEntryClient.DeleteAsync(entryId);
                ChargeDtg();
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Equals(String.Empty))
            {
                ChargeDtg();
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            var assets = await unitOfWork.ProjectEntryClient.GetEntriesAsync(DataOnMemory.ProjectId);
            decimal.TryParse((txtSearch.Texts), out decimal get);

            var result = assets.Where(e => e.EntryType.Equals(txtSearch.Texts, StringComparison.OrdinalIgnoreCase)
            || e.Entry >= get || e.Growth >= get);

            dtgFNE.DataSource = null;
            dtgFNE.DataSource = result.ToList();
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }

        private void txtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateDecimalnotNegative(sender, e);
        }

        private void txtCrecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateDecimalNegative(sender, e);
        }

        private void txtStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }
    }
}
