using Asrfly.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;
        public HomeUserControl()
        {
            InitializeComponent();
            //SetRoles();
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
    }
}
