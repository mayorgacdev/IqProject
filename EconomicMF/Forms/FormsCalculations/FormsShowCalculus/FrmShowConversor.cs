using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using System;
using System.Data;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations.FormsShowCalculus
{
    public partial class FrmShowConversor : Form
    {
        private readonly IUnitOfWork unitOfWork;

        private string userEmail;

        public FrmShowConversor(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        private void FrmShowConversor_Load(object sender, EventArgs e)
        {
            LlenarDgv();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable ConvertToDataTable()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvConversiones.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvConversiones.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            return dt;
        }

        private void txtSearchReport_KeyDown(object sender, KeyEventArgs e)
        {
            //TODO: No sirve
            MessageBox.Show("Test");
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtSearchReport.Text))
                {
                    LlenarDgv();
                    return;
                }

                DataTable dt = ConvertToDataTable();
                dt.DefaultView.RowFilter = string.Format("TipoOriginal LIKE '*{0}*' OR TipoActual LIKE '*{0}*' OR FrecCapOriginal LIKE '*{0}*' FrecCapActual OR Id = '{0}'", txtSearchReport.Text);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgvConversiones.DataSource = bs;
            }
        }
        private void LlenarDgv()
        {
            //dgvConversiones.DataSource = null;
            //dgvConversiones.DataSource = conversionService.FindByUserEmail(userEmail);
            //dgvConversiones.Columns[dgvConversiones.Columns.Count - 1].Visible = false;
            ////para ocultar el userId
            //dgvConversiones.Columns[1].Visible = false;
        }

        private void txtSearchReport__TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            if (string.IsNullOrWhiteSpace(txtSearchReport.Text))
            {
                LlenarDgv();
                return;
            }

            DataTable dt = ConvertToDataTable();
            dt.DefaultView.RowFilter = string.Format("TipoOriginal LIKE '*{0}*' OR TipoActual LIKE '*{0}*' OR FrecCapOriginal LIKE '*{0}*' FrecCapActual OR Id = '{0}'", txtSearchReport.Text);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgvConversiones.DataSource = bs;
        }
    }
}
