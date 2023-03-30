using Asrfly.Data.SqlServer;
using Asrfly.Gui.GuiLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiSettings
{
    public partial class SettingsForm : Form
    {
        private LoadingForm loading;
        private readonly bool firstStart;

        public SettingsForm(bool FirstStart)
        {
            InitializeComponent();
            SetGeneralSettings();
            loading = new LoadingForm();
            firstStart = FirstStart;
        }

        private void buttonSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            SaveGeneralSettings();
        }

        private void SaveGeneralSettings()
        {
            Properties.Settings.Default.CompanyName = textBoxCompany.Text;
            Properties.Settings.Default.HideNotificaitonInterval = Convert.ToInt32(numericUpDownNotification.Value);
            Properties.Settings.Default.DataGridViewRowNo = Convert.ToInt32(numericUpDownDataRow.Value);

            // Save Picture
            using (MemoryStream ma = new MemoryStream())
            {
                pictureBoxLogo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
            }

            // Save Settings
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات بنجاح");

        }
        private void SetGeneralSettings()
        {
            textBoxCompany.Text = Properties.Settings.Default.CompanyName;
            numericUpDownNotification.Value = Properties.Settings.Default.HideNotificaitonInterval;
            numericUpDownDataRow.Value = Properties.Settings.Default.DataGridViewRowNo;

            // Set Picture

            if (Properties.Settings.Default.CompanyLogo != string.Empty) // Check if first open
            {
                var ImgaeAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo); // Convert string to byte

                using (MemoryStream ma = new MemoryStream(ImgaeAsByte))
                {
                    pictureBoxLogo.Image = Image.FromStream(ma); // Set picture
                }
            }
        }

        private void buttonSaveConString_Click(object sender, EventArgs e)
        {
            var Server = textBoxServer.Text;
            var DataBase = textBoxDataBase.Text;
            var Timout = numericUpDownTimeout.Value;
            var UserName = textBoxUserName.Text;
            var Password = textBoxPassword.Text;
            if (radioButtonLocalCon.Checked == true)
            {
                // Local Con
                SetLocalCon(Server, DataBase);
            }
            else
            {
                // Network Con
                SetNetWorkCon(Server, DataBase, UserName, Password, Timout);
            }

            MessageBox.Show("تم حفظ نص الاتصال بنجاح , اعد تشغيل البرنامج لطفا");
            Application.Exit();

        }

        private void SetNetWorkCon(string server, string dataBase, string userName, string password, decimal timout)
        {
            var ConString = @"Server=" + server + ";Database=" + dataBase + ";User Id=" + userName + ";Password=" + password + ";Timeout=" + timout + "";

            Properties.Settings.Default.SqlServerConString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

        private void SetLocalCon(string server, string dataBase)
        {
            var ConString = @"Server=" + server + ";Database=" + dataBase + ";Trusted_Connection=True;";
            Properties.Settings.Default.SqlServerConString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_Activated(object sender, EventArgs e)
        {
        }

        private void radioButtonLocalCon_CheckedChanged(object sender, EventArgs e)
        {

            textBoxUserName.Enabled = false;
            textBoxPassword.Enabled = false;
            numericUpDownTimeout.Enabled = false;
        }

        private void radioButtonNetworkCon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = true;
            textBoxPassword.Enabled = true;
            numericUpDownTimeout.Enabled = true;
        }

        private void linkLabelImportImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر شعار المؤسسة";
            openFileDialog.RestoreDirectory = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private async void buttonBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "اختر مسار حفظ النسخة الاحتياطية وتجنب اختيار القرص النظام";
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loading.Show();
                string processResult = await Task.Run(() => backUpRestoreHelper.BackUp(folderBrowserDialog.SelectedPath));
                if (processResult == "1")
                {
                    loading.Hide();
                    MessageBox.Show("تم اجراء النسخ الاحتياطي بنجاح");
                }
                else
                {
                    loading.Hide();
                    MessageBox.Show(processResult + "لم نتمكن من اجراء عملية النسخ الاحتياطي بسبب ");
                }
            }
        }

        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر ملف النسخة الاحتياطية";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Bak File|*.bak";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loading.Show();
                string processResult = await Task.Run(() => backUpRestoreHelper.Restore(openFileDialog.FileName));
                if (processResult == "1")
                {
                    loading.Hide();
                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");
                }
                else
                {
                    loading.Hide();
                    MessageBox.Show(processResult + "لم نتمكن من استعادة  النسخة الاحتياطية بسبب ");
                }
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firstStart == true)
            {
                Application.Exit();
            }
        }
    }

}

