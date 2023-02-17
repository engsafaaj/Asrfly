using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
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
        private readonly IDataHelper<Categories> dataHelper;
        private static CategoryUserControl _CategoryUserControl;
        private readonly GuiLoading.LoadingForm loadingForm;


        // Constructors
        public CategoryUserControl()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
            loadingForm = new GuiLoading.LoadingForm();
            LoadData();
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
        public async void LoadData()
        {
            loadingForm.Show();
            dataGridView1.DataSource =await dataHelper.GetAllDataAsync();
            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Close();
        }
        private void SetColumnsTitle()
        {
            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "النوع";
            dataGridView1.Columns[3].HeaderText = "التفاصيل";
            dataGridView1.Columns[4].HeaderText = "الرصيد";
            dataGridView1.Columns[5].HeaderText = "تاريخ الاضافة";
        }
        #endregion
    }
}

