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
        private int RowId;
        private readonly GuiLoading.LoadingForm loadingForm;
        private List<int> IdList = new List<int>();

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
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, this);
            addCategoryForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                var Deleteresult = MessageCollections.ShowDeleteDialog();
                if (Deleteresult)
                {
                    SetIdRowForDelete();
                    loadingForm.Show();
                    if (IdList.Count > 0)
                    {
                        for (int i = 0; i < IdList.Count; i++)
                        {
                            RowId = IdList[i];
                            var result = await dataHelper.DeleteAsync(RowId);
                            if (result == 1)
                            {
                                MessageCollections.ShowDeleteNotificaiton();
                            }
                            else
                            {
                                MessageCollections.ShowErrorServer();

                            }
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageCollections.ShowRequiredDeleteRow();
                    }
                   
                    loadingForm.Hide();
                }

            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }

        }



        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
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
            dataGridView1.DataSource = await dataHelper.GetAllDataAsync();
            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Hide();
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
        private void Edit()
        {
            if (dataGridView1.RowCount > 0)
            {
                // Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddCategoryForm addCategoryForm = new AddCategoryForm(RowId, this);
                addCategoryForm.Show();
            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }
        }
        private void SetIdRowForDelete()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }
        }
        #endregion


    }
}

