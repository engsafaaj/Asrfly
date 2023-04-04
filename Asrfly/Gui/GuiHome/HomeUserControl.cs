using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using Asrfly.Gui.GuiCategories;
using Asrfly.Gui.GuiCustomers;
using Asrfly.Gui.GuiIncome;
using Asrfly.Gui.GuiOutcome;
using Asrfly.Gui.GuiProjects;
using Asrfly.Gui.GuiSuppliers;
using Asrfly.Gui.GuiUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;
        private int ProjectId;
        private readonly IDataHelper<Projects> dataHelper;

        public HomeUserControl()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
            SetRoles();
            SetGeneralSettings();
            SetHello();
        }

        public static HomeUserControl Instance()
        {
            return _HomeUserControl ?? (new HomeUserControl());
        }

        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxAccessCategory"))
            {
                buttonAddCategory.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessCategory"))
            {
                buttonAddCategory.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessSupllier"))
            {
                buttonAddSupplier.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessCusteorm"))
            {
                buttonAddCustomer.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessProjects"))
            {
                buttonAddProject.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessUsers"))
            {
                buttonAddUser.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessOutcome"))
            {
                buttonAddOutput.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccesIncome"))
            {
                buttonAddInput.Visible = false;
            }
        }

        private void SetGeneralSettings()
        {
            labelCompanyName.Text = Properties.Settings.Default.CompanyName;

            // Set Picture

            if (Properties.Settings.Default.CompanyLogo != string.Empty) // Check if first open
            {
                var ImgaeAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo); // Convert string to byte

                using (MemoryStream ma = new MemoryStream(ImgaeAsByte))
                {
                    pictureBoxLogo.Image = Image.FromStream(ma); // Set picture
                }
            }
        }

        private void SetHello()
        {
            labelWellcome.Text = "مرحبا بك "+ Properties.Settings.Default.UserName;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
            addCategoryForm.Show();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm(0, new CustomersUserControl());
            addCustomersForm.Show();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            AddSuppliersForm addSuppliersForm = new AddSuppliersForm(0, new SuppliersUserControl());
            addSuppliersForm.Show();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectsForm = new AddProjectForm(0, new ProjectsUserControl());
            addProjectsForm.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addCategoryForm = new AddUserForm(0, new UsersControl(), false);
            addCategoryForm.Show();
        }

        private async void HomeUserControl_Load(object sender, EventArgs e)
        {
            // Get List of Suppliers
            var ListOfProjects = await dataHelper.GetAllDataAsync();
            comboBoxProject.DataSource = ListOfProjects.Select(x => x.Name).ToList(); // Fill 
                                                                                      // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListOfProjects.Select(x => x.Name).ToArray());
            comboBoxProject.AutoCompleteCustomSource = autoCompleteString;

            ListOfProjects.Clear(); // clear 
        }

        private  void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var projectName = comboBoxProject.SelectedItem.ToString();
            ProjectId = dataHelper.GetAllData().Where(X => X.Name == projectName).Select(x => x.Id).FirstOrDefault();
        }

        private void buttonAddOutput_Click(object sender, EventArgs e)
        {
            if (ProjectId > 0)
            {
                AddOutcomeForm addOutcomeForm = new AddOutcomeForm(0, ProjectId, new OutcomeUserControl(ProjectId));
                addOutcomeForm.Show();
            }
            else
            {
                MessageBox.Show("اختر المشروع لطفا");
            }
        }

        private void buttonAddInput_Click(object sender, EventArgs e)
        {
            if (ProjectId > 0)
            {
                AddIncomeForm addIncomeForm = new AddIncomeForm(0, ProjectId, new IncomeUserControl(ProjectId));
                addIncomeForm.Show();
            }
            else
            {
                MessageBox.Show("اختر المشروع لطفا");
            }
        }
    }
}
