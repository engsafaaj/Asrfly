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

namespace Asrfly.Gui.GuiUsers
{
    public partial class AddUserForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly UsersControl categoryUserControl;
        private readonly bool firstStart;
        private Users users;
        private readonly IDataHelper<Users> dataHelper;
        private readonly IDataHelper<UsersRoles> dataHelperUsersRoles;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private Dictionary<string, bool> ListOfRoles = new Dictionary<string, bool>();

        public AddUserForm(int Id, UsersControl ctegoryUserControl, bool FirstStart)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Users>)ConfigrationObjectManager.GetObject("Users");
            dataHelperUsersRoles = (IDataHelper<UsersRoles>)ConfigrationObjectManager.GetObject("UsersRoles");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");

            loadingForm = new GuiLoading.LoadingForm();
            this.ID = Id;
            this.categoryUserControl = ctegoryUserControl;
            firstStart = FirstStart;
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
                        this.DialogResult = DialogResult.OK;
                        MessageCollections.ShowAddNotificaiton();
                    }
                    else
                    {
                        MessageCollections.ShowUpdateNotificaiton();
                    }
                    if (firstStart == true)
                    {
                        MessageBox.Show("اعد تشغيل البرنامج لطفا");
                        Application.Exit();
                    }
                    else
                    {
                        Close();
                    }
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
                        this.DialogResult = DialogResult.OK;
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
            if (firstStart == true)
            {
                buttonSave.Visible = false;
            }

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
            if (textBoxName.Text == string.Empty 
                || textBoxUserName.Text == string.Empty
                || textBoxPassword.Text == string.Empty
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
            users = new Users
            {
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Phone=textBoxPhoneNumber.Text,
                Email=textBoxEmail.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.AddAsync(users);
            if (result == 1)
            {
                // Add Roles
                var data = await dataHelper.GetAllDataAsync();
                var userid = data.Select(x => x.Id).LastOrDefault();
                SetRoles();
                
                // Loop into List of Roles

                for(int i = 0; i < ListOfRoles.Count; i++)
                {
                    UsersRoles usersRoles = new UsersRoles
                    {
                        UserId = userid,
                        Key = ListOfRoles.Keys.ToList()[i],
                        Value = ListOfRoles.Values.ToList()[i]
                    };
                    await dataHelperUsersRoles.AddAsync(usersRoles);
                }          
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة مستخدم",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تمت اضافة مستخدم  "+users.UserName,
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

        private void SetRoles()
        {
            ListOfRoles.Clear();
            ListOfRoles.Add(checkBoxHome.Name, checkBoxHome.Checked);
            ListOfRoles.Add(checkBoxCategory.Name, checkBoxCategory.Checked);
            ListOfRoles.Add(checkBoxSupplier.Name, checkBoxSupplier.Checked);
            ListOfRoles.Add(checkBoxCustoemr.Name, checkBoxCustoemr.Checked);
            ListOfRoles.Add(checkBoxProjects.Name, checkBoxProjects.Checked);
            ListOfRoles.Add(checkBoxUsers.Name, checkBoxUsers.Checked);
            ListOfRoles.Add(checkBoxSettings.Name, checkBoxSettings.Checked);
            ListOfRoles.Add(checkBoxSystemRecords.Name, checkBoxSystemRecords.Checked);

            //
            ListOfRoles.Add(checkBoxAccessCategory.Name, checkBoxAccessCategory.Checked);
            ListOfRoles.Add(checkBoxAccessSupllier.Name, checkBoxAccessSupllier.Checked);
            ListOfRoles.Add(checkBoxAccessCusteorm.Name, checkBoxAccessCusteorm.Checked);
            ListOfRoles.Add(checkBoxAccessProjects.Name, checkBoxAccessProjects.Checked);
            ListOfRoles.Add(checkBoxAccessUsers.Name, checkBoxAccessUsers.Checked);
            ListOfRoles.Add(checkBoxAccessOutcome.Name, checkBoxAccessOutcome.Checked);
            ListOfRoles.Add(checkBoxAccesIncome.Name, checkBoxAccesIncome.Checked);

            //
            ListOfRoles.Add(checkBoxAdd.Name, checkBoxAdd.Checked);
            ListOfRoles.Add(checkBoxDelete.Name, checkBoxDelete.Checked);
            ListOfRoles.Add(checkBoxEdit.Name, checkBoxEdit.Checked);
            ListOfRoles.Add(checkBoxExport.Name, checkBoxExport.Checked);
            ListOfRoles.Add(checkBoxSearch.Name, checkBoxSearch.Checked);
            ListOfRoles.Add(checkBoxExplor.Name, checkBoxExplor.Checked);


        }

        private async Task<bool> EditData()
        {
            // Set Data
            users = new Users
            {
                Id = ID,
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.EditAsync(users);
            if (result == 1)
            {
                // Add Roles
                var rolesData = await dataHelperUsersRoles.GetAllDataAsync();
                var ListOfRolesId = rolesData.Where(x => x.UserId == ID).Select(X => X.Id).ToList();
                // Loop into ListOfRolesId ==> Delete
                for (int j=0;j< ListOfRolesId.Count; j++)
                {
                    var userid = ListOfRolesId[j];
                    await dataHelperUsersRoles.DeleteAsync(userid);
                }

                SetRoles();

                // Loop into List of Roles
                for (int i = 0; i < ListOfRoles.Count; i++)
                {
                    UsersRoles usersRoles = new UsersRoles
                    {
                        UserId = ID,
                        Key = ListOfRoles.Keys.ToList()[i],
                        Value = ListOfRoles.Values.ToList()[i]
                    };
                    await dataHelperUsersRoles.AddAsync(usersRoles);
                }
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل مستخدم",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل مستخدم  " + users.UserName,
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
                users = await dataHelper.FindAsync(ID);
                var rolesData= await dataHelperUsersRoles.GetAllDataAsync();
                var ListOfRoles = rolesData.Where(X => X.UserId == ID).Select(x => x.Value).ToList();

                if (users != null)
                {
                    textBoxName.Text = users.FullName;
                    textBoxUserName.Text = users.UserName;
                    textBoxPassword.Text = users.Password;
                    textBoxPhoneNumber.Text = users.Phone;
                    textBoxEmail.Text = users.Email;

                    // Set Current Roles

                    checkBoxHome.Checked= ListOfRoles[0];
                    checkBoxCategory.Checked = ListOfRoles[1];
                    checkBoxSupplier.Checked = ListOfRoles[2];
                    checkBoxCustoemr.Checked = ListOfRoles[3];
                    checkBoxProjects.Checked = ListOfRoles[4];
                    checkBoxUsers.Checked = ListOfRoles[5];
                    checkBoxSettings.Checked = ListOfRoles[6];
                    checkBoxSystemRecords.Checked = ListOfRoles[7];
                    
                    checkBoxAccessCategory.Checked = ListOfRoles[8];
                    checkBoxAccessSupllier.Checked = ListOfRoles[9];
                    checkBoxAccessCusteorm.Checked = ListOfRoles[10];
                    checkBoxAccessProjects.Checked = ListOfRoles[11];
                    checkBoxAccessUsers.Checked = ListOfRoles[12];
                    checkBoxAccessOutcome.Checked = ListOfRoles[13];
                    checkBoxAccesIncome.Checked = ListOfRoles[14];

                    checkBoxAdd.Checked = ListOfRoles[15];
                    checkBoxDelete.Checked = ListOfRoles[16];
                    checkBoxEdit.Checked = ListOfRoles[17];
                    checkBoxExport.Checked = ListOfRoles[18];
                    checkBoxSearch.Checked = ListOfRoles[19];
                    checkBoxExplor.Checked = ListOfRoles[20];
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
            }
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (firstStart == true)
            {
                Application.Exit();
            }
        }
    }
}
