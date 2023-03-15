using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiOutcome
{
    public partial class AddOutcomeForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly OutcomeUserControl categoryUserControl;
        private Outcome outcome;
        private int CategoryId;
        private int SupplierId;
        private int ProjectId;
        private readonly IDataHelper<Outcome> dataHelper;
        private readonly IDataHelper<Suppliers> dataHelperSuppliers;
        private readonly IDataHelper<Categories> dataHelperCategories;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;

        public AddOutcomeForm(int Id, int ProjectId, OutcomeUserControl ctegoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            dataHelperSuppliers = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
            dataHelperCategories = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");

            loadingForm = new GuiLoading.LoadingForm();
            this.ID = Id;
            this.categoryUserControl = ctegoryUserControl;
            this.ProjectId = ProjectId;

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
        private void AddCategoryForm_Load(object sender, EventArgs e)
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
                var SupplierName = comboBoxsupplier.SelectedItem.ToString();
                var CategoyName = comboBoxCategory.SelectedItem.ToString();
                await Task.Run(() => SetCategoryId(CategoyName));
                await Task.Run(() => SetSupplierId(SupplierName));

                return await AddData();
            }
            // Edit
            else
            {
                var SupplierName = comboBoxsupplier.SelectedItem.ToString();
                var CategoyName = comboBoxCategory.SelectedItem.ToString();
                await Task.Run(() => SetCategoryId(CategoyName));
                await Task.Run(() => SetSupplierId(SupplierName));
                return await EditData();
            }
        }

        private bool IsFiledsEmpty()
        {
            if (comboBoxCategory.SelectedItem == null ||
                comboBoxsupplier.SelectedItem == null ||
                textBoxAmount.Text == string.Empty

                )
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
            outcome = new Outcome
            {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxCategory.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                OutcomeDate = dateTimePickerDate.Value,
                CategroyId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            // Sumbit
            var result = await dataHelper.AddAsync(outcome);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة عملية صرف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تمت اضافة عملية صرف  " + outcome.CategoryName,
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
            outcome = new Outcome
            {
                Id = ID,
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxCategory.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                OutcomeDate = dateTimePickerDate.Value,
                CategroyId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            // Sumbit
            var result = await dataHelper.EditAsync(outcome);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل عملة صرف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل عملة صرف  " + outcome.CategoryName,
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
            // Get List of Suppliers
            var ListSuppliers = await dataHelperSuppliers.GetAllDataAsync();
            comboBoxsupplier.DataSource = ListSuppliers.Select(x => x.Name).ToList(); // Fill 
                                                                                      // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListSuppliers.Select(x => x.Name).ToArray());
            comboBoxsupplier.AutoCompleteCustomSource = autoCompleteString;

            ListSuppliers.Clear(); // clear 


            // Get List of Categories
            var ListCategories = await dataHelperCategories.GetAllDataAsync();
            comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList(); // Fill 
                                                                                       // Auto Complete
            AutoCompleteStringCollection autoCompleteStringCategories = new AutoCompleteStringCollection();
            autoCompleteStringCategories.AddRange(ListCategories.Select(x => x.Name).ToArray());
            comboBoxsupplier.AutoCompleteCustomSource = autoCompleteStringCategories;

            ListCategories.Clear(); // clear 

            if (ID > 0)
            {
                // Set Fileds
                outcome = await dataHelper.FindAsync(ID);
                if (outcome != null)
                {
                    comboBoxCategory.SelectedItem = outcome.CategoryName;
                    comboBoxCategory.SelectedItem = outcome.SupplierName;
                    textBoxRecNo.Text = outcome.RecNo;
                    richTextBoxDetails.Text = outcome.Details;
                    textBoxAmount.Text = outcome.Amount.ToString();
                    dateTimePickerDate.Value = outcome.OutcomeDate;
                    CategoryId = outcome.CategroyId;
                    SupplierId = outcome.SupplierId;
                    ProjectId = outcome.ProjectId;
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
            }
        }

        #endregion



        private void SetCategoryId(string CategoyName)
        {

            CategoryId = dataHelperCategories.GetAllData().Where(x => x.Name == CategoyName)
                .Select(x => x.Id).First();

        }
        private void SetSupplierId(string SupplierName)
        {

            SupplierId = dataHelperSuppliers.GetAllData().Where(x => x.Name == SupplierName)
                .Select(x => x.Id).First();

        }
    }
}
