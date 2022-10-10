using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using System;
using System.Data;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations.FormsShowCalculus
{
    public partial class FrmShowRate : Form
    {
        //private Interes interes;
        private readonly IUnitOfWork unitOfWork;
        private string userEmail;
        //public FrmShowRate(Interes interes)
        //{
        //    //this.interes = interes;
        //}

        public FrmShowRate(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        private void FrmShowRate_Load(object sender, EventArgs e)
        {
            LlenarDgv();
            //dgvInteres.DataSource = economicClassService.GetAll().Where(x => x.GetType().Equals(typeof(Interes))).ToList();
        }

        private void LlenarDgv()
        {
            //dgvInteres.DataSource = economicClassService.GetInteres(userEmail);
            //dgvInteres.Columns["IdUser"].Visible = false;
            //dgvInteres.Columns["Usuario"].Visible = false;
            //dgvInteres.Columns["TipoInteres"].DisplayIndex = dgvInteres.ColumnCount-3;
            //dgvInteres.Columns["FrecuenciaTasa"].DisplayIndex = dgvInteres.ColumnCount - 2;
            //dgvInteres.Columns["Capitalizacion"].DisplayIndex = dgvInteres.ColumnCount - 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable ConvertToDataTable()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvInteres.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvInteres.Rows)
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
    }
}
