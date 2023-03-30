
namespace Asrfly.Gui.GuiSettings
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveGeneralSettings = new System.Windows.Forms.Button();
            this.linkLabelImportImage = new System.Windows.Forms.LinkLabel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.numericUpDownDataRow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNotification = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSaveConString = new System.Windows.Forms.Button();
            this.radioButtonNetworkCon = new System.Windows.Forms.RadioButton();
            this.radioButtonLocalCon = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonBackUp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotification)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveGeneralSettings);
            this.groupBox1.Controls.Add(this.linkLabelImportImage);
            this.groupBox1.Controls.Add(this.pictureBoxLogo);
            this.groupBox1.Controls.Add(this.numericUpDownDataRow);
            this.groupBox1.Controls.Add(this.numericUpDownNotification);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCompany);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 625);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاعدادات العامة";
            // 
            // buttonSaveGeneralSettings
            // 
            this.buttonSaveGeneralSettings.Image = global::Asrfly.Properties.Resources.icons8_save_32px_1;
            this.buttonSaveGeneralSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveGeneralSettings.Location = new System.Drawing.Point(17, 553);
            this.buttonSaveGeneralSettings.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            this.buttonSaveGeneralSettings.Size = new System.Drawing.Size(471, 55);
            this.buttonSaveGeneralSettings.TabIndex = 8;
            this.buttonSaveGeneralSettings.Text = "حفظ ";
            this.buttonSaveGeneralSettings.UseVisualStyleBackColor = true;
            this.buttonSaveGeneralSettings.Click += new System.EventHandler(this.buttonSaveGeneralSettings_Click);
            // 
            // linkLabelImportImage
            // 
            this.linkLabelImportImage.AutoSize = true;
            this.linkLabelImportImage.Location = new System.Drawing.Point(198, 450);
            this.linkLabelImportImage.Name = "linkLabelImportImage";
            this.linkLabelImportImage.Size = new System.Drawing.Size(70, 37);
            this.linkLabelImportImage.TabIndex = 4;
            this.linkLabelImportImage.TabStop = true;
            this.linkLabelImportImage.Text = "تحميل";
            this.linkLabelImportImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelImportImage_LinkClicked);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Asrfly.Properties.Resources.Logo_2021;
            this.pictureBoxLogo.Location = new System.Drawing.Point(123, 301);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(219, 146);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // numericUpDownDataRow
            // 
            this.numericUpDownDataRow.Location = new System.Drawing.Point(17, 193);
            this.numericUpDownDataRow.Name = "numericUpDownDataRow";
            this.numericUpDownDataRow.Size = new System.Drawing.Size(150, 45);
            this.numericUpDownDataRow.TabIndex = 2;
            this.numericUpDownDataRow.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numericUpDownNotification
            // 
            this.numericUpDownNotification.Location = new System.Drawing.Point(17, 115);
            this.numericUpDownNotification.Name = "numericUpDownNotification";
            this.numericUpDownNotification.Size = new System.Drawing.Size(150, 45);
            this.numericUpDownNotification.TabIndex = 2;
            this.numericUpDownNotification.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(176, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "شعار المؤسسة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(322, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "عدد البيانات المعروضة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(278, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "فترة عرض الاشعارات (ثواني) ";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(17, 44);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(294, 45);
            this.textBoxCompany.TabIndex = 1;
            this.textBoxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المؤسسة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(528, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 629);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قواعد البيانات";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSaveConString);
            this.groupBox4.Controls.Add(this.radioButtonNetworkCon);
            this.groupBox4.Controls.Add(this.radioButtonLocalCon);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxPassword);
            this.groupBox4.Controls.Add(this.textBoxUserName);
            this.groupBox4.Controls.Add(this.textBoxDataBase);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numericUpDownTimeout);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxServer);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(7, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 470);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "نص الاتصال";
            // 
            // buttonSaveConString
            // 
            this.buttonSaveConString.Image = global::Asrfly.Properties.Resources.icons8_save_32px_1;
            this.buttonSaveConString.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveConString.Location = new System.Drawing.Point(8, 404);
            this.buttonSaveConString.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSaveConString.Name = "buttonSaveConString";
            this.buttonSaveConString.Size = new System.Drawing.Size(167, 55);
            this.buttonSaveConString.TabIndex = 8;
            this.buttonSaveConString.Text = "حفظ ";
            this.buttonSaveConString.UseVisualStyleBackColor = true;
            this.buttonSaveConString.Click += new System.EventHandler(this.buttonSaveConString_Click);
            // 
            // radioButtonNetworkCon
            // 
            this.radioButtonNetworkCon.AutoSize = true;
            this.radioButtonNetworkCon.Location = new System.Drawing.Point(6, 28);
            this.radioButtonNetworkCon.Name = "radioButtonNetworkCon";
            this.radioButtonNetworkCon.Size = new System.Drawing.Size(82, 36);
            this.radioButtonNetworkCon.TabIndex = 0;
            this.radioButtonNetworkCon.Text = "شبكي";
            this.radioButtonNetworkCon.UseVisualStyleBackColor = true;
            this.radioButtonNetworkCon.CheckedChanged += new System.EventHandler(this.radioButtonNetworkCon_CheckedChanged);
            // 
            // radioButtonLocalCon
            // 
            this.radioButtonLocalCon.AutoSize = true;
            this.radioButtonLocalCon.Checked = true;
            this.radioButtonLocalCon.Location = new System.Drawing.Point(122, 28);
            this.radioButtonLocalCon.Name = "radioButtonLocalCon";
            this.radioButtonLocalCon.Size = new System.Drawing.Size(78, 36);
            this.radioButtonLocalCon.TabIndex = 0;
            this.radioButtonLocalCon.TabStop = true;
            this.radioButtonLocalCon.Text = "محلي";
            this.radioButtonLocalCon.UseVisualStyleBackColor = true;
            this.radioButtonLocalCon.CheckedChanged += new System.EventHandler(this.radioButtonLocalCon_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(402, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "فترة الاتصال (ثانية)";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(24, 323);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(355, 39);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Location = new System.Drawing.Point(24, 261);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(355, 39);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDataBase
            // 
            this.textBoxDataBase.Location = new System.Drawing.Point(24, 137);
            this.textBoxDataBase.Name = "textBoxDataBase";
            this.textBoxDataBase.Size = new System.Drawing.Size(355, 39);
            this.textBoxDataBase.TabIndex = 1;
            this.textBoxDataBase.Text = "AsrflyDataBase";
            this.textBoxDataBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(454, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "كلمة السر";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(423, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "اسم المستخدم";
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Enabled = false;
            this.numericUpDownTimeout.Location = new System.Drawing.Point(24, 199);
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(355, 39);
            this.numericUpDownTimeout.TabIndex = 2;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(434, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "قاعدة البيانات";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(24, 75);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxServer.Size = new System.Drawing.Size(355, 39);
            this.textBoxServer.TabIndex = 1;
            this.textBoxServer.Text = ".\\SQLEXPRESS";
            this.textBoxServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(473, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "السيرفر";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRestore);
            this.groupBox3.Controls.Add(this.buttonBackUp);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 108);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "النسخ الاحتياطي والتعيين";
            // 
            // buttonRestore
            // 
            this.buttonRestore.ForeColor = System.Drawing.Color.Black;
            this.buttonRestore.Image = global::Asrfly.Properties.Resources.icons8_Database_Restore_32px_1;
            this.buttonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestore.Location = new System.Drawing.Point(25, 40);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(263, 55);
            this.buttonRestore.TabIndex = 8;
            this.buttonRestore.Text = "استعادة النسخة الاحتياطية";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonBackUp
            // 
            this.buttonBackUp.ForeColor = System.Drawing.Color.Black;
            this.buttonBackUp.Image = global::Asrfly.Properties.Resources.icons8_data_backup_32px;
            this.buttonBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackUp.Location = new System.Drawing.Point(320, 40);
            this.buttonBackUp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBackUp.Name = "buttonBackUp";
            this.buttonBackUp.Size = new System.Drawing.Size(221, 55);
            this.buttonBackUp.TabIndex = 8;
            this.buttonBackUp.Text = "النسخ الاحتياطي";
            this.buttonBackUp.UseVisualStyleBackColor = true;
            this.buttonBackUp.Click += new System.EventHandler(this.buttonBackUp_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات النظام";
            this.Activated += new System.EventHandler(this.SettingsForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotification)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelImportImage;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.NumericUpDown numericUpDownDataRow;
        private System.Windows.Forms.NumericUpDown numericUpDownNotification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveGeneralSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonBackUp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSaveConString;
        private System.Windows.Forms.RadioButton radioButtonNetworkCon;
        private System.Windows.Forms.RadioButton radioButtonLocalCon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label5;
    }
}