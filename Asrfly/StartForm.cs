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

namespace Asrfly
{
    public partial class StartForm : Form
    {
        private readonly IDataHelper<Users> dataHelper;

        public StartForm()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Users>)ConfigrationObjectManager.GetObject("Users");

        }

        private async void CheckCon()
        {
            labelState.Text = "جاري الاتصال بقاعدة البيانات";
            Asrfly.Data.SqlServer.DBContext dB = new Data.SqlServer.DBContext();
            if (await dB.Database.CanConnectAsync())
            {
                var data = await dataHelper.GetAllDataAsync();
                if (data.Count > 0)
                {
                    // Login Form
                    Gui.GuiUsers.UserLoginForm loginForm = new Gui.GuiUsers.UserLoginForm();
                    loginForm.Show();
                    Hide();
                }
                else
                {
                    // Add Form
                    Gui.GuiUsers.AddUserForm addUserForm = new Gui.GuiUsers.AddUserForm(0, new Gui.GuiUsers.UsersControl(), true);
                    addUserForm.Show();
                    Hide();
                }
            }
            else
            {
                Hide();
                var result = MessageBox.Show("هناك خطا في الاتصال في قاعدة البيانات, اضغط نعم لضبط الاتصال و لا للخروج من البرنامج", "خطا في الاتصال",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Gui.GuiSettings.SettingsForm settingsForm = new Gui.GuiSettings.SettingsForm(true);
                    settingsForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckCon();
        }
    }
}
