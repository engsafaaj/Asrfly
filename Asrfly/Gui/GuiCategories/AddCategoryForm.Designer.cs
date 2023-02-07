
namespace Asrfly.Gui.GuiCategories
{
    partial class AddCategoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.richTextBoxCategoryDetails = new System.Windows.Forms.RichTextBox();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonSaveAndClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 83);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxCategoryDetails);
            this.groupBox1.Controls.Add(this.comboBoxCategoryType);
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCategoryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 561);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(68, 94);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(459, 45);
            this.textBoxCategoryName.TabIndex = 1;
            this.textBoxCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "نوع الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "الوصف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "الرصيد";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Enabled = false;
            this.textBoxBalance.Location = new System.Drawing.Point(68, 488);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(459, 45);
            this.textBoxBalance.TabIndex = 1;
            this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxCategoryType
            // 
            this.comboBoxCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.Items.AddRange(new object[] {
            "صرف",
            "قبض"});
            this.comboBoxCategoryType.Location = new System.Drawing.Point(68, 188);
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            this.comboBoxCategoryType.Size = new System.Drawing.Size(459, 45);
            this.comboBoxCategoryType.TabIndex = 2;
            // 
            // richTextBoxCategoryDetails
            // 
            this.richTextBoxCategoryDetails.Location = new System.Drawing.Point(68, 278);
            this.richTextBoxCategoryDetails.Name = "richTextBoxCategoryDetails";
            this.richTextBoxCategoryDetails.Size = new System.Drawing.Size(459, 146);
            this.richTextBoxCategoryDetails.TabIndex = 3;
            this.richTextBoxCategoryDetails.Text = "";
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.Image = global::Asrfly.Properties.Resources.icons8_save_32px;
            this.buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveAndClose.Location = new System.Drawing.Point(445, 14);
            this.buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(198, 55);
            this.buttonSaveAndClose.TabIndex = 2;
            this.buttonSaveAndClose.Text = "حفظ وغلق";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Asrfly.Properties.Resources.icons8_save_32px_1;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(14, 14);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 55);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "حفظ";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCategoryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة / تعديل صنف";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxCategoryDetails;
        private System.Windows.Forms.ComboBox comboBoxCategoryType;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAndClose;
    }
}