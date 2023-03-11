using Asrfly.Code;
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

        }

        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Load Home Page
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        private void buttonCategory_Click(object sender, EventArgs e)
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
    }
}
