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
            SetRoles();
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
        }
    }
}
