using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
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
            dtgFNE.DataSource = await unitOfWork.ProjectEntryClient.GetEntriesAsync(DataOnMemory.ProjectId);
        }

        private async void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
