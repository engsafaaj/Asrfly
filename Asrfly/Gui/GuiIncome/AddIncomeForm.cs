using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using Asrfly.Gui.GuiCategories;
using Asrfly.Gui.GuiCustomers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiIncome
{
    public partial class AddIncomeForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly IncomeUserControl categoryUserControl;
        private Income income;
        private int CategoryId;
        private int SupplierId;
        private int ProjectId;
        private readonly IDataHelper<Income> dataHelper;
        private readonly IDataHelper<Customers> dataHelperCustomers;
        private readonly IDataHelper<Categories> dataHelperCategories;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;

        public AddIncomeForm(int Id, int ProjectId, IncomeUserControl ctegoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Income>)ConfigrationObjectManager.GetObject("Income");
            dataHelperCustomers = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
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
            income = new Income
            {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxCategory.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                IncomeDate = dateTimePickerDate.Value,
                CategroyId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            // Sumbit
            var result = await dataHelper.AddAsync(income);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة عملية قبض",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تمت اضافة عملية قبض  " + income.CategoryName,
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
            income = new Income
            {
                Id = ID,
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxCategory.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                IncomeDate = dateTimePickerDate.Value,
                CategroyId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            // Sumbit
            var result = await dataHelper.EditAsync(income);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل عملة قبض",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل عملة قبض  " + income.CategoryName,
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
            // Get List of Customers
            var ListCustomers = await dataHelperCustomers.GetAllDataAsync();
            comboBoxsupplier.DataSource = ListCustomers.Select(x => x.Name).ToList(); // Fill 
                                                                                      // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
            comboBoxsupplier.AutoCompleteCustomSource = autoCompleteString;

            ListCustomers.Clear(); // clear 


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
                income = await dataHelper.FindAsync(ID);
                if (income != null)
                {
                    comboBoxCategory.SelectedItem = income.CategoryName;
                    comboBoxCategory.SelectedItem = income.SupplierName;
                    textBoxRecNo.Text = income.RecNo;
                    richTextBoxDetails.Text = income.Details;
                    textBoxAmount.Text = income.Amount.ToString();
                    dateTimePickerDate.Value = income.IncomeDate;
                    CategoryId = income.CategroyId;
                    SupplierId = income.SupplierId;
                    ProjectId = income.ProjectId;
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

            SupplierId = dataHelperCustomers.GetAllData().Where(x => x.Name == SupplierName)
                .Select(x => x.Id).First();

        }

        private async void linkLabelNewCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
           var result= addCategoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get List of Categories
                var ListCategories = await dataHelperCategories.GetAllDataAsync();
                comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList(); // Fill 
                                                                                           // Auto Complete
                AutoCompleteStringCollection autoCompleteStringCategories = new AutoCompleteStringCollection();
                autoCompleteStringCategories.AddRange(ListCategories.Select(x => x.Name).ToArray());
                comboBoxsupplier.AutoCompleteCustomSource = autoCompleteStringCategories;

                ListCategories.Clear(); // clear 
            }
        }

        private async void linkLabelNewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm(0, new CustomersUserControl());
           var result= addCustomersForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get List of Customers
                var ListCustomers = await dataHelperCustomers.GetAllDataAsync();
                comboBoxsupplier.DataSource = ListCustomers.Select(x => x.Name).ToList(); // Fill 
                                                                                          // Auto Complete
                AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
                autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
                comboBoxsupplier.AutoCompleteCustomSource = autoCompleteString;

                ListCustomers.Clear(); // clear 
            }
        }

        private void AddIncomeForm_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
