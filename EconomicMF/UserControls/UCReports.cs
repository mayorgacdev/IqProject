using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCReports : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly int projectId;
        private readonly int solutionId;
        public UCReports(IUnitOfWork projectServices, int projectId, int solutionId)
        {
            InitializeComponent();
            this.unitOfWork = projectServices;
            this.projectId = projectId;
            this.solutionId = solutionId;
        }

        private void UCReports_Load(object sender, EventArgs e)
        {
            ChargeLabels();
        }

        private void ChargeLabels()
        {/*
            var data = await unitOfWork.ProjectClient.GetAsync(projectId);
            lblIdProject.Text = data.Id.ToString();
            lblNameProject.Text = data.Name.ToString();
            lblData.Text = data.CreationDate.ToString();*/
        }

        private void UCReports_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateGray;
        }

        private void UCReports_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 39);
        }

        private void btnDowloadReport_Click(object sender, EventArgs e)
        {/*
            string a = Application.StartupPath;
            Microsoft.Reporting.WinForms.LocalReport lr = new Microsoft.Reporting.WinForms.LocalReport();
            var projectAsync = await unitOfWork.ProjectClient.GetAsync(projectId);
            bool mejor = false;
            string mimetype = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string deviceInfo = "";
            string[] streamIds;

            //TODO: obtienes todos los proyectos de una solution
            IEnumerable<ProjectClient> projects = await unitOfWork.ProjectClient.GetProjectsAsync(solutionId);
            List<Project> projectWithList = new List<Project>();

            //TODO: Tienes que pasar los datos del ProjecClient al ProjectWithList
            mejor = project == ProjectCalculations.GetBestProject(projects.ToList(), projectId) ? true : false;

            // TODO: si es con financiamiento fijo tiene inversionistas
            if (projectWithList.WithFinancing)
            {
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ProjectCalculations.FlujosReport(project)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ProjectCalculations.DatosProjecto(project, mejor)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ProjectCalculations.DatosPastel(project)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet4", ProjectCalculations.Financiamientos(project)));
                lr.ReportPath = Path.Combine(Application.StartupPath, "ReportFinan.rdlc");
            }
            else
            {
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ProjectCalculations.FlujosReport(project)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ProjectCalculations.DatosProjecto(project, mejor)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ProjectCalculations.DatosPastel(project)));
                lr.ReportPath = Path.Combine(Application.StartupPath, "ReportProyect.rdlc");
            }
            var bytes = lr.Render("PDF", deviceInfo, out mimetype, out encoding, out extension, out streamIds, out warnings);
            File.WriteAllBytes(DataOnMemory.Path + project.Name + ".pdf", bytes);*/

            // TODO: recuerda rellenar ProjectWithList 
        }

        private void btnDowloadReport_Click_1(object sender, EventArgs e)
        {

        }
    }
}
