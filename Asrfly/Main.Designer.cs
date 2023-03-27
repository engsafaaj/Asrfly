
namespace Asrfly
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonHome);
            this.flowLayoutPanel1.Controls.Add(this.buttonCategory);
            this.flowLayoutPanel1.Controls.Add(this.buttonCustomers);
            this.flowLayoutPanel1.Controls.Add(this.buttonSuppliers);
            this.flowLayoutPanel1.Controls.Add(this.buttonProjects);
            this.flowLayoutPanel1.Controls.Add(this.buttonUsers);
            this.flowLayoutPanel1.Controls.Add(this.buttonSettings);
            this.flowLayoutPanel1.Controls.Add(this.buttonLogout);
            this.flowLayoutPanel1.Controls.Add(this.buttonHelp);
            this.flowLayoutPanel1.Controls.Add(this.buttonAbout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 600);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1262, 73);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::Asrfly.Properties.Resources.icons8_home_32px_1;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(1061, 10);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(165, 55);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "الرئيسة";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonCategory
            // 
            this.buttonCategory.Image = global::Asrfly.Properties.Resources.icons8_categorize_32px;
            this.buttonCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategory.Location = new System.Drawing.Point(886, 10);
            this.buttonCategory.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(165, 55);
            this.buttonCategory.TabIndex = 1;
            this.buttonCategory.Text = "الاصناف";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Image = global::Asrfly.Properties.Resources.icons8_people_32px;
            this.buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.Location = new System.Drawing.Point(711, 10);
            this.buttonCustomers.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(165, 55);
            this.buttonCustomers.TabIndex = 2;
            this.buttonCustomers.Text = "العملاء";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.Image = global::Asrfly.Properties.Resources.icons8_conference_32px;
            this.buttonSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuppliers.Location = new System.Drawing.Point(536, 10);
            this.buttonSuppliers.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(165, 55);
            this.buttonSuppliers.TabIndex = 3;
            this.buttonSuppliers.Text = "الموردين";
            this.buttonSuppliers.UseVisualStyleBackColor = true;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // buttonProjects
            // 
            this.buttonProjects.Image = global::Asrfly.Properties.Resources.icons8_microsoft_project_32px;
            this.buttonProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjects.Location = new System.Drawing.Point(361, 10);
            this.buttonProjects.Margin = new System.Windows.Forms.Padding(5);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(165, 55);
            this.buttonProjects.TabIndex = 4;
            this.buttonProjects.Text = "المشاريع";
            this.buttonProjects.UseVisualStyleBackColor = true;
            this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Image = global::Asrfly.Properties.Resources.icons8_users_32px;
            this.buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.Location = new System.Drawing.Point(186, 10);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(165, 55);
            this.buttonUsers.TabIndex = 5;
            this.buttonUsers.Text = "     المستخدمين";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = global::Asrfly.Properties.Resources.icons8_settings_32px;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(11, 10);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(165, 55);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "الاعدادات";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = global::Asrfly.Properties.Resources.icons8_Logout_32px;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(1061, 75);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(165, 55);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "خروج";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Image = global::Asrfly.Properties.Resources.icons8_help_32px;
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Location = new System.Drawing.Point(886, 75);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(165, 55);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "المساعدة";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Image = global::Asrfly.Properties.Resources.icons8_about_32px_1;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(711, 75);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(165, 55);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "حول";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1262, 600);
            this.panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asrfly";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAbout;
        public System.Windows.Forms.Panel panelContainer;
    }
}

