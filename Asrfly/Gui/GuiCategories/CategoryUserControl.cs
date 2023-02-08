using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiCategories
{
    public partial class CategoryUserControl : UserControl
    {
        // Variables
        private static CategoryUserControl _CategoryUserControl;


        // Constructors
        public CategoryUserControl()
        {
            InitializeComponent();
        }
        #region Events
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Code.MessageCollections.ShowEmptyDataMessage();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Methods
        public static CategoryUserControl Instance()
        {
            return _CategoryUserControl ?? (new CategoryUserControl());
        }
        #endregion
    }
}

