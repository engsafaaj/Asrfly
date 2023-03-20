using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiProjects
{
    public partial class ProjectManagmentForm : Form
    {
        private readonly int projectId;
        private readonly IDataHelper<Core.Income> dataHelperIncome;
        private readonly IDataHelper<Core.Outcome> dataHelperOutCome;
        private double TotalIncome;
        private double TotalOutcome;

        public ProjectManagmentForm(int ProjectId)
        {
            dataHelperIncome = (IDataHelper<Income>)ConfigrationObjectManager.GetObject("Income");
            dataHelperOutCome = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            InitializeComponent();
            projectId = ProjectId;
            LoadOutComeUI();
            LoadIncomeUI();
        }

        private void LoadOutComeUI()
        {
            // Load OutCome UI
            GuiOutcome.OutcomeUserControl outcomeUserControl = new GuiOutcome.OutcomeUserControl(projectId);
            outcomeUserControl.Dock = DockStyle.Fill;
            panelOutcome.Controls.Add(outcomeUserControl);
        }
        private void LoadIncomeUI()
        {
            // Load OutCome UI
            GuiIncome.IncomeUserControl IncomeUserControl = new GuiIncome.IncomeUserControl(projectId);
            IncomeUserControl.Dock = DockStyle.Fill;
            panelIncome.Controls.Add(IncomeUserControl);
        }

       

      

        private  void ProjectManagmentForm_Activated(object sender, EventArgs e)
        {
            GetTotalData();
        }

        private void GetTotalData()
        {
            // Get Data
            try
            {
                TotalIncome = dataHelperIncome.GetAllData()
                    .Where(x => x.ProjectId == projectId).Select(x => x.Amount).ToArray().Sum();
                TotalOutcome = dataHelperOutCome.GetAllData()
                   .Where(x => x.ProjectId == projectId).Select(x => x.Amount).ToArray().Sum();
            }
            catch { }
            var Rev = TotalIncome - TotalOutcome;

            // Set Data to Ui
            labelIncome.Text = "المقبوضات: "+ TotalIncome.ToString("#0.00");
            labelOutcome.Text = "المصروفات: "+ TotalOutcome.ToString("#0.00");
            labelRev.Text = "الارباح: "+ Rev.ToString("#0.00");

        }
    }
}
