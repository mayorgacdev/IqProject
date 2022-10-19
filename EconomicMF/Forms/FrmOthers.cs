using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Enums;
using EconomicMF.SettingForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmOthers : Form
    {
        private readonly IUnitOfWork unitOfWork;

        public FrmOthers(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            //int id = 0;
            //if ((int)dtgFNE.Rows.Count > 0)
            //    id = (int)dtgFNE.Rows[dtgFNE.CurrentRow.Index].Cells[0].Value;

            //DataOnMemory.ActivoId = id;
            //SingletonFrm.GetForm(FormType.ResolveDepreciation).Show();
        }

        private void FrmOthers_Load(object sender, EventArgs e)
        {
            cmbTipoDeCalculos.Items.AddRange(Enum.GetValues(typeof(TipoDeCalculo)).Cast<object>().ToArray());
            cmbTipoDeCalculos.SelectedIndex = 1;
            ValidateCmb();
        }

        private void cmbTipoDeCalculos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateCmb();
        }
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);


            Form fh = (Form)formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }



        private void ValidateCmb()
        {
            if (cmbTipoDeCalculos.SelectedItem is TipoDeCalculo.Amortización)
            {
                AbrirFormEnPanel(SingletonFrm.GetForm(FormType.OtherAmt));
            }
            else
            {
                AbrirFormEnPanel(SingletonFrm.GetForm(FormType.OtherDep));
            }
        }

        private void dtgFNE_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
