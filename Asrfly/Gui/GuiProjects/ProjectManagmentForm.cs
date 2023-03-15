using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiProjects
{
    public partial class ProjectManagmentForm : Form
    {
        private readonly int projectId;

        public ProjectManagmentForm(int ProjectId)
        {
            InitializeComponent();
            projectId = ProjectId;
            LoadOutComeUI();


        }

        private void LoadOutComeUI()
        {
            // Load OutCome UI
            GuiOutcome.OutcomeUserControl outcomeUserControl = new GuiOutcome.OutcomeUserControl(projectId);
            outcomeUserControl.Dock = DockStyle.Fill;
            panelOutcome.Controls.Add(outcomeUserControl);
        }
    }
}
