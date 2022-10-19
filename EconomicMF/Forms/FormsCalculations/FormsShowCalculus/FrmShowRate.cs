using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.SettingForms;
using ExportToExcel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations.FormsShowCalculus
{
    public partial class FrmShowRate : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int solutionId;
        private DataTable dt;

        public FrmShowRate(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
            dt = new DataTable();
        }

        private void FrmShowRate_Load(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private async void LlenarDgv()
        {
            IEnumerable<RateDto> conversions = await unitOfWork.EconomicClient.GetInteresAsync(solutionId);
            dgvInteres.DataSource = conversions;
            dgvInteres.Columns["Capitalizacion"].Visible = false;
            dt = ConvertDatagridview.ConvertToDataTable(dgvInteres);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
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
                    bindingSource.Filter = String.Format("TipoInteres LIKE '*{0}*' OR FrecuenciaTasa LIKE '*{0}*'", txtSearch.Text);
                }
                dgvInteres.DataSource = bindingSource;
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
                bindingSource.Filter = String.Format("TipoInteres LIKE '*{0}*' OR FrecuenciaTasa LIKE '*{0}*'", txtSearch.Text);
            }
            dgvInteres.DataSource = bindingSource;
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            IEnumerable<RateDto> conversions = await unitOfWork.EconomicClient.GetInteresAsync(solutionId);
            string path = string.Empty;
            string get = string.Empty;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath + "\\";
                get = folderBrowserDialog.SelectedPath + "\\";
            }
            else
            {
                return;
            }

            Random random = new Random();
            path = $"{path}Interés{random.Next(20, 555)}.xlsx";

            CreateExcelFile.CreateExcelDocument(conversions.ToList(), path);

        }
    }
}
