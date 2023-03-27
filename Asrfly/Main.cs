﻿using Asrfly.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Asrfly
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);
            // Load Home Page
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
           // SetRoles();

        }

        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Load Home Page
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        private  void buttonCategory_Click(object sender, EventArgs e)
        {
            // Load Categories Page
            pageManager.LoadPage(Gui.GuiCategories.CategoryUserControl.Instance());
        }
        #endregion

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            // Load Customers Page
            pageManager.LoadPage(Gui.GuiCustomers.CustomersUserControl.Instance());
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            // Load Suppliers Page
            pageManager.LoadPage(Gui.GuiSuppliers.SuppliersUserControl.Instance());
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            // Load Projects Page
            pageManager.LoadPage(Gui.GuiProjects.ProjectsUserControl.Instance());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            // Load Users Page
            pageManager.LoadPage(Gui.GuiUsers.UsersControl.Instance());
        }

        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxHome"))
            {
                buttonHome.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxCategory"))
            {
                buttonCategory.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSupplier"))
            {
                buttonSuppliers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxCustoemr"))
            {
                buttonCustomers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxProjects"))
            {
                buttonProjects.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxUsers"))
            {
                buttonUsers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxUsers"))
            {
                buttonUsers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSettings"))
            {
                buttonUsers.Visible = false;
            }
           /* if (!UsersRolesManager.GetRole("checkBoxSystemRecords"))
            {
                buttonSystemRecords.Visible = false;
            }*/
           
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Gui.GuiSettings.SettingsForm settingsForm = new Gui.GuiSettings.SettingsForm();
            settingsForm.Show();
        }
    }
}
