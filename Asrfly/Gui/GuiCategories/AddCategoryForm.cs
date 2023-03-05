using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiCategories
{
    public partial class AddCategoryForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly CategoryUserControl categoryUserControl;
        private Categories categories;
        private readonly IDataHelper<Categories> dataHelper;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;

        public AddCategoryForm(int Id, CategoryUserControl ctegoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");

            loadingForm = new GuiLoading.LoadingForm();
            this.ID = Id;
            this.categoryUserControl = ctegoryUserControl;

        }

        #region Events
        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            if (IsFiledsEmpty())
            {
                MessageCollections.ShowFiledsRequired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        MessageCollections.ShowAddNotificaiton();
                    }
                    else
                    {
                        MessageCollections.ShowUpdateNotificaiton();
                    }
                    Close();
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsFiledsEmpty())
            {
                MessageCollections.ShowFiledsRequired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        MessageCollections.ShowAddNotificaiton();
                    }
                    else
                    {
                        MessageCollections.ShowUpdateNotificaiton();
                    }
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
        }
        private  void AddCategoryForm_Load(object sender, EventArgs e)
        {
            loadingForm.Show();
            SetFiledData();
            loadingForm.Hide();

        }
        #endregion

        #region Methods

        private async Task<bool> SaveData()
        {
            // Add
            if (ID == 0)
            {
                return await AddData();
            }
            // Edit
            else
            {
                return await EditData();
            }
        }

        private bool IsFiledsEmpty()
        {
            if (textBoxName.Text == string.Empty || comboBoxType.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> AddData()
        {
            // Set Data
            categories = new Categories
            {
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.AddAsync(categories);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة صنف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تمت اضافة صنف  "+categories.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                categoryUserControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> EditData()
        {
            // Set Data
            categories = new Categories
            {
                Id = ID,
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.EditAsync(categories);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل صنف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل صنف  " + categories.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                // Toast 
                categoryUserControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void SetFiledData()
        {
            if (ID > 0)
            {
                // Set Filed
                categories = await dataHelper.FindAsync(ID);
                if (categories != null)
                {
                    textBoxName.Text = categories.Name;
                    textBoxBalance.Text = categories.Balance.ToString();
                    comboBoxType.SelectedItem = categories.Type;
                    richTextBoxDetails.Text = categories.Details;
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
            }
        }
        #endregion


    }
}
