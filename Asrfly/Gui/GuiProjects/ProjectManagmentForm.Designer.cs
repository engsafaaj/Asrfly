
namespace Asrfly.Gui.GuiProjects
{
    partial class ProjectManagmentForm
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
            this.labelRev = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelOutcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.panelOutcome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRev);
            this.panel1.Controls.Add(this.labelIncome);
            this.panel1.Controls.Add(this.labelOutcome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 106);
            this.panel1.TabIndex = 0;
            // 
            // labelRev
            // 
            this.labelRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRev.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRev.Location = new System.Drawing.Point(428, 0);
            this.labelRev.Name = "labelRev";
            this.labelRev.Size = new System.Drawing.Size(214, 106);
            this.labelRev.TabIndex = 3;
            this.labelRev.Text = "الارباح: 0000000";
            this.labelRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncome
            // 
            this.labelIncome.BackColor = System.Drawing.Color.Gold;
            this.labelIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIncome.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelIncome.Location = new System.Drawing.Point(214, 0);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(214, 106);
            this.labelIncome.TabIndex = 2;
            this.labelIncome.Text = "المقبوضات: 0000000";
            this.labelIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOutcome
            // 
            this.labelOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelOutcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutcome.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOutcome.Location = new System.Drawing.Point(0, 0);
            this.labelOutcome.Name = "labelOutcome";
            this.labelOutcome.Size = new System.Drawing.Size(214, 106);
            this.labelOutcome.TabIndex = 1;
            this.labelOutcome.Text = "المصروفات: 0000000";
            this.labelOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(696, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "ادراة صرفيات المشاريع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelIncome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelOutcome, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 567);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelIncome
            // 
            this.panelIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIncome.Location = new System.Drawing.Point(3, 3);
            this.panelIncome.Name = "panelIncome";
            this.panelIncome.Size = new System.Drawing.Size(525, 561);
            this.panelIncome.TabIndex = 0;
            // 
            // panelOutcome
            // 
            this.panelOutcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutcome.Location = new System.Drawing.Point(534, 3);
            this.panelOutcome.Name = "panelOutcome";
            this.panelOutcome.Size = new System.Drawing.Size(525, 561);
            this.panelOutcome.TabIndex = 1;
            // 
            // ProjectManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ProjectManagmentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أدارة المشروع";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ProjectManagmentForm_Activated);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRev;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelOutcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelIncome;
        private System.Windows.Forms.Panel panelOutcome;
    }
}