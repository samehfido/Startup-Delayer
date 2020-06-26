namespace Startup_manager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.amT_TabControl1 = new AMT_SW_GUI.AMT_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.amT_GroupBox1 = new AMT_SW_GUI.AMT_GroupBox();
            this.chkStart = new AMT_SW_GUI.AMT_CheckBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.cboxTimeType = new AMT_SW_GUI.AMT_ComboBox();
            this.amT_Label2 = new AMT_SW_GUI.AMT_Label();
            this.amT_Label1 = new AMT_SW_GUI.AMT_Label();
            this.txtapp = new System.Windows.Forms.TextBox();
            this.amT_Button1 = new AMT_SW_GUI.AMT_Button();
            this.lvApps = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOpenDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.amT_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.amT_GroupBox1.SuspendLayout();
            this.Cmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // amT_TabControl1
            // 
            this.amT_TabControl1.ActiveTabBorderColor = System.Drawing.Color.Gray;
            this.amT_TabControl1.ActiveTabColor = System.Drawing.Color.White;
            this.amT_TabControl1.ActiveTextColor = System.Drawing.Color.Black;
            this.amT_TabControl1.AllowDrop = true;
            this.amT_TabControl1.Controls.Add(this.tabPage1);
            this.amT_TabControl1.Controls.Add(this.tabPage2);
            this.amT_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amT_TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.amT_TabControl1.InactiveTabBorderColor = System.Drawing.SystemColors.Highlight;
            this.amT_TabControl1.InactiveTabColor = System.Drawing.Color.Transparent;
            this.amT_TabControl1.InactiveTextColor = System.Drawing.Color.DarkGray;
            this.amT_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.amT_TabControl1.Name = "amT_TabControl1";
            this.amT_TabControl1.SelectedIndex = 0;
            this.amT_TabControl1.Size = new System.Drawing.Size(358, 300);
            this.amT_TabControl1.TabIndex = 1;
            this.amT_TabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.SplitContainer1_DragDrop);
            this.amT_TabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.SplitContainer1_DragEnter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.amT_GroupBox1);
            this.tabPage1.Controls.Add(this.lvApps);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Applications";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // amT_GroupBox1
            // 
            this.amT_GroupBox1.AutoSize = true;
            this.amT_GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.amT_GroupBox1.BackColor = System.Drawing.Color.White;
            this.amT_GroupBox1.Controls.Add(this.chkStart);
            this.amT_GroupBox1.Controls.Add(this.txtDelay);
            this.amT_GroupBox1.Controls.Add(this.cboxTimeType);
            this.amT_GroupBox1.Controls.Add(this.amT_Label2);
            this.amT_GroupBox1.Controls.Add(this.amT_Label1);
            this.amT_GroupBox1.Controls.Add(this.txtapp);
            this.amT_GroupBox1.Controls.Add(this.amT_Button1);
            this.amT_GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amT_GroupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.amT_GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(197)))));
            this.amT_GroupBox1.LineColor = System.Drawing.SystemColors.Highlight;
            this.amT_GroupBox1.Location = new System.Drawing.Point(3, 133);
            this.amT_GroupBox1.Name = "amT_GroupBox1";
            this.amT_GroupBox1.Padding = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.amT_GroupBox1.Size = new System.Drawing.Size(344, 135);
            this.amT_GroupBox1.TabIndex = 1;
            this.amT_GroupBox1.TabStop = false;
            this.amT_GroupBox1.Text = "Add Application (Drag Drop Here)";
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.BackColor = System.Drawing.Color.Transparent;
            this.chkStart.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkStart.FlatAppearance.BorderSize = 0;
            this.chkStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkStart.Location = new System.Drawing.Point(109, 107);
            this.chkStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.chkStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(131, 24);
            this.chkStart.TabIndex = 5;
            this.chkStart.Text = "Start With Windows";
            this.chkStart.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkStart.UseCompatibleTextRendering = true;
            this.chkStart.UseVisualStyleBackColor = false;
            this.chkStart.Click += new System.EventHandler(this.chkStart_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(44, 63);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(115, 24);
            this.txtDelay.TabIndex = 4;
            this.txtDelay.Text = "30";
            this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxTimeType
            // 
            this.cboxTimeType.BackColor = System.Drawing.Color.White;
            this.cboxTimeType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.cboxTimeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxTimeType.DropDownHeight = 162;
            this.cboxTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTimeType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cboxTimeType.ForeColor = System.Drawing.Color.Black;
            this.cboxTimeType.FormattingEnabled = true;
            this.cboxTimeType.IntegralHeight = false;
            this.cboxTimeType.ItemHeight = 20;
            this.cboxTimeType.Items.AddRange(new object[] {
            "Seconds",
            "Minutes"});
            this.cboxTimeType.Location = new System.Drawing.Point(165, 62);
            this.cboxTimeType.MinimumSize = new System.Drawing.Size(0, 0);
            this.cboxTimeType.Name = "cboxTimeType";
            this.cboxTimeType.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(197)))));
            this.cboxTimeType.Size = new System.Drawing.Size(173, 26);
            this.cboxTimeType.TabIndex = 3;
            // 
            // amT_Label2
            // 
            this.amT_Label2.AutoSize = true;
            this.amT_Label2.BackColor = System.Drawing.Color.Transparent;
            this.amT_Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.amT_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.amT_Label2.Location = new System.Drawing.Point(1, 65);
            this.amT_Label2.Name = "amT_Label2";
            this.amT_Label2.Size = new System.Drawing.Size(42, 18);
            this.amT_Label2.TabIndex = 2;
            this.amT_Label2.Text = "Delay:";
            this.amT_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amT_Label2.UseCompatibleTextRendering = true;
            // 
            // amT_Label1
            // 
            this.amT_Label1.AutoSize = true;
            this.amT_Label1.BackColor = System.Drawing.Color.Transparent;
            this.amT_Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.amT_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.amT_Label1.Location = new System.Drawing.Point(8, 32);
            this.amT_Label1.Name = "amT_Label1";
            this.amT_Label1.Size = new System.Drawing.Size(35, 18);
            this.amT_Label1.TabIndex = 2;
            this.amT_Label1.Text = "Path:";
            this.amT_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amT_Label1.UseCompatibleTextRendering = true;
            // 
            // txtapp
            // 
            this.txtapp.AllowDrop = true;
            this.txtapp.Location = new System.Drawing.Point(44, 29);
            this.txtapp.Name = "txtapp";
            this.txtapp.Size = new System.Drawing.Size(294, 24);
            this.txtapp.TabIndex = 1;
            // 
            // amT_Button1
            // 
            this.amT_Button1.AutoSize = true;
            this.amT_Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.amT_Button1.BackColor = System.Drawing.Color.Transparent;
            this.amT_Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("amT_Button1.BackgroundImage")));
            this.amT_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.amT_Button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.amT_Button1.FlatAppearance.BorderSize = 0;
            this.amT_Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.amT_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.amT_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amT_Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.amT_Button1.ForeColor = System.Drawing.Color.White;
            this.amT_Button1.Location = new System.Drawing.Point(246, 102);
            this.amT_Button1.MaximumSize = new System.Drawing.Size(0, 29);
            this.amT_Button1.MinimumSize = new System.Drawing.Size(95, 29);
            this.amT_Button1.Name = "amT_Button1";
            this.amT_Button1.Size = new System.Drawing.Size(95, 29);
            this.amT_Button1.TabIndex = 0;
            this.amT_Button1.Text = "Add";
            this.amT_Button1.UseVisualStyleBackColor = false;
            this.amT_Button1.Click += new System.EventHandler(this.amT_Button1_Click);
            // 
            // lvApps
            // 
            this.lvApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvApps.ContextMenuStrip = this.Cmenu;
            this.lvApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvApps.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvApps.FullRowSelect = true;
            this.lvApps.GridLines = true;
            this.lvApps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvApps.HideSelection = false;
            this.lvApps.Location = new System.Drawing.Point(3, 3);
            this.lvApps.Name = "lvApps";
            this.lvApps.Size = new System.Drawing.Size(344, 130);
            this.lvApps.TabIndex = 0;
            this.lvApps.UseCompatibleStateImageBehavior = false;
            this.lvApps.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Delay";
            // 
            // Cmenu
            // 
            this.Cmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemove,
            this.BtnOpenDirectory});
            this.Cmenu.Name = "Cmenu";
            this.Cmenu.Size = new System.Drawing.Size(155, 48);
            // 
            // btnRemove
            // 
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 22);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // BtnOpenDirectory
            // 
            this.BtnOpenDirectory.Name = "BtnOpenDirectory";
            this.BtnOpenDirectory.Size = new System.Drawing.Size(154, 22);
            this.BtnOpenDirectory.Text = "Open Directory";
            this.BtnOpenDirectory.Click += new System.EventHandler(this.BtnOpenDirectory_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nIcon
            // 
            this.nIcon.BalloonTipTitle = "Startup Manager 1.0";
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "Startup Manager 1.0";
            this.nIcon.Visible = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 300);
            this.Controls.Add(this.amT_TabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(374, 338);
            this.MinimumSize = new System.Drawing.Size(374, 338);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup Manager 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.amT_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.amT_GroupBox1.ResumeLayout(false);
            this.amT_GroupBox1.PerformLayout();
            this.Cmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AMT_SW_GUI.AMT_TabControl amT_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AMT_SW_GUI.AMT_GroupBox amT_GroupBox1;
        private System.Windows.Forms.ListView lvApps;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtapp;
        private AMT_SW_GUI.AMT_Button amT_Button1;
        private AMT_SW_GUI.AMT_Label amT_Label1;
        private AMT_SW_GUI.AMT_ComboBox cboxTimeType;
        private System.Windows.Forms.TextBox txtDelay;
        private AMT_SW_GUI.AMT_Label amT_Label2;
        private System.Windows.Forms.ContextMenuStrip Cmenu;
        private System.Windows.Forms.ToolStripMenuItem btnRemove;
        private AMT_SW_GUI.AMT_CheckBox chkStart;
        private System.Windows.Forms.NotifyIcon nIcon;
        private System.Windows.Forms.ToolStripMenuItem BtnOpenDirectory;
    }
}

