using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.SettingForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations.FormsShowCalculus
{
    public partial class FormShowAnnuaty : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int solutionId;
        private DataTable dt;

        public FormShowAnnuaty(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
            dt = new DataTable();
        }

        private void FormShowAnnuaty_Load(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LlenarDgv()
        {
            IEnumerable<AnnuityDto> conversions = await unitOfWork.EconomicClient.GetAnualidadesAsync(solutionId);
            dgvAnnuaty.DataSource = conversions;
            dt = ConvertDatagridview.ConvertToDataTable(dgvAnnuaty);
        }

        private void txtSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    LlenarDgv();
                    return;
                }
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                if (int.TryParse(txtSearch.Text, out int result))
                {
                    bindingSource.Filter = String.Format("Id = {0}", txtSearch.Text);
                }
                else
                {
                    bindingSource.Filter = String.Format("TipoAnualidad LIKE '*{0}*' OR Periodo LIKE '*{0}*' OR TipoDeCrecimiento LIKE '*{0}*'", txtSearch.Text);
                }
                dgvAnnuaty.DataSource = bindingSource;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Texts = String.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LlenarDgv();
                return;
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            if (int.TryParse(txtSearch.Text, out int result))
            {
                bindingSource.Filter = String.Format("Id = {0}", txtSearch.Text);
            }
            else
            {
                bindingSource.Filter = String.Format("TipoAnualidad LIKE '*{0}*' OR Periodo LIKE '*{0}*' OR TipoDeCrecimiento LIKE '*{0}*'", txtSearch.Text);
            }
            dgvAnnuaty.DataSource = bindingSource;
        }
    }
}
