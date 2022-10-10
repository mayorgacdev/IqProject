using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.UserControls
{
    public partial class UCAddCostToProject : UserControl
    {
        private readonly ProjectCost costProject;
        public UCAddCostToProject(ProjectCost costProject)
        {
            InitializeComponent();
            this.costProject = costProject;
        }
    }
}
