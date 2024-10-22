﻿using EconomicEF.Common.UserCache;
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
    public partial class FrmCashFlowHistory : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private DataTable dt;
        private int solutionId;
        private int flujoId;
        private int nper;
        public FrmCashFlowHistory(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            dt = new DataTable();
            solutionId = DataOnMemory.SolutionId;
        }
        private async void LlenarDgv()
        {
            IEnumerable<FlujoDeCajaDto> cashFlow = await unitOfWork.flujoClient.GetBySolutionID(solutionId);
            dgvCashFlow.DataSource = cashFlow;
            dt = ConvertDatagridview.ConvertToDataTable(dgvCashFlow);
        }

        private void FrmCashFlowHistory_Load(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCashFlow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //string stringId = dgvCashFlow.Rows[e.RowIndex].Cells[0].Value.ToString();
                flujoId = int.Parse(dgvCashFlow.Rows[e.RowIndex].Cells[0].Value.ToString());
                //string stringnper = dgvCashFlow.Rows[e.RowIndex].Cells[5].Value.ToString();
                nper = (int)decimal.Parse(dgvCashFlow.Rows[e.RowIndex].Cells[5].Value.ToString());
                FrmShowCashFlowDetail frmShowCashFlowDetail = new FrmShowCashFlowDetail(unitOfWork, flujoId,nper);
                frmShowCashFlowDetail.ShowDialog();
            }
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
                dgvCashFlow.DataSource = bindingSource;
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
            dgvCashFlow.DataSource = bindingSource;
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            IEnumerable<FlujoDeCajaDto> cashFlow = await unitOfWork.flujoClient.GetBySolutionID(solutionId);
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
            path = $"{path}History{random.Next(20, 555)}.xlsx";

            CreateExcelFile.CreateExcelDocument(cashFlow.ToList(), path);
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            panel1.BackColor = Color.HotPink;
        }
    }
}
