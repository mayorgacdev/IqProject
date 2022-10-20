using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Conversiones;
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
    public partial class FrmShowConversor : Form
    {
        private readonly IUnitOfWork unitOfWork;

        private string userEmail;
        DataTable dt;
        public FrmShowConversor(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
            dt = new DataTable();
        }

        private void FrmShowConversor_Load(object sender, EventArgs e)
        {
            LlenarDgv();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LlenarDgv()
        {
            IEnumerable<ConversionDto> conversions = await unitOfWork.ConversionClient.GetConversionAsync(userEmail);
            dgvConversiones.DataSource = conversions;
            dt = ConvertDatagridview.ConvertToDataTable(dgvConversiones);
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
                    bindingSource.Filter = String.Format("TipoOriginal LIKE '*{0}*' OR TipoActual LIKE '*{0}*' OR FrecCapOriginal LIKE '*{0}*' OR FrecCapActual LIKE '*{0}*'", txtSearch.Text);
                }
                dgvConversiones.DataSource = bindingSource;
            }
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
                bindingSource.Filter = String.Format("TipoOriginal LIKE '*{0}*' OR TipoActual LIKE '*{0}*' OR FrecCapOriginal LIKE '*{0}*' OR FrecCapActual LIKE '*{0}*'", txtSearch.Text);
            }
            dgvConversiones.DataSource = bindingSource;
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            IEnumerable<ConversionDto> conversions = await unitOfWork.ConversionClient.GetConversionAsync(userEmail);
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
            path = $"{path}Conversiones{random.Next(20, 555)}.xlsx";

            CreateExcelFile.CreateExcelDocument(conversions.ToList(), path);
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            panel1.BackColor = Color.HotPink;
        }
    }
}
