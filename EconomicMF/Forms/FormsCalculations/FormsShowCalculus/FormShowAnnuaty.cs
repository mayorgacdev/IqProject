using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using System;
using System.Data;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations.FormsShowCalculus
{
    public partial class FormShowAnnuaty : Form
    {
        //private Anualidad anualidad;
        private readonly IUnitOfWork unitOfWork;
        private string userEmail;
        //public FormShowAnnuaty(Anualidad anualidad)
        //{
        //    //this.anualidad = anualidad;
        //}

        public FormShowAnnuaty(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        private void FormShowAnnuaty_Load(object sender, EventArgs e)
        {
            //LlenarDgv();
            //dgvAnnuaty.DataSource = economicClassService.GetAnualidades(userEmail);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LlenarDgv()
        {
            //dgvAnnuaty.DataSource = economicClassService.Get(userEmail);
            //dgvAnnuaty.Columns["IdUser"].Visible = false;
            //dgvAnnuaty.Columns["Usuario"].Visible = false;
            //dgvAnnuaty.Columns["PagoAnual"].DisplayIndex = dgvAnnuaty.ColumnCount - 4;
            //dgvAnnuaty.Columns["TipoAnualidad"].DisplayIndex = dgvAnnuaty.ColumnCount - 3;
            //dgvAnnuaty.Columns["PeriodoGracia"].DisplayIndex = dgvAnnuaty.ColumnCount - 2;
            //dgvAnnuaty.Columns["Periodo"].DisplayIndex = dgvAnnuaty.ColumnCount - 1;
        }
        private DataTable ConvertToDataTable()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvAnnuaty.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvAnnuaty.Rows)
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
