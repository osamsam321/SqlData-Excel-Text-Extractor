namespace excel_sql_app
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ddPanelCont = new System.Windows.Forms.Panel();
            this.ddLabel = new System.Windows.Forms.Label();
            this.mainAreaTitle = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentTitlePane = new System.Windows.Forms.Panel();
            this.contentSubTitlePane = new System.Windows.Forms.Panel();
            this.excelDataLabel = new System.Windows.Forms.Label();
            this.customSQLLabel = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.colTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FIlePathLabel = new System.Windows.Forms.Label();
            this.systemMSGLabel = new System.Windows.Forms.Label();
            this.mainSqlRichBox = new System.Windows.Forms.RichTextBox();
            this.dataRichBox = new System.Windows.Forms.RichTextBox();
            this.performanceCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.performanceLabel = new System.Windows.Forms.Label();
            this.uniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.ddPanelCont.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contentTitlePane.SuspendLayout();
            this.contentSubTitlePane.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddPanelCont
            // 
            this.ddPanelCont.AllowDrop = true;
            this.ddPanelCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.ddPanelCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ddPanelCont.Controls.Add(this.ddLabel);
            this.ddPanelCont.ForeColor = System.Drawing.SystemColors.Control;
            this.ddPanelCont.Location = new System.Drawing.Point(213, 97);
            this.ddPanelCont.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.ddPanelCont.Name = "ddPanelCont";
            this.ddPanelCont.Size = new System.Drawing.Size(554, 60);
            this.ddPanelCont.TabIndex = 1;
            this.ddPanelCont.DragDrop += new System.Windows.Forms.DragEventHandler(this.DdPanelCont_DragDrop);
            this.ddPanelCont.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            this.ddPanelCont.DragOver += new System.Windows.Forms.DragEventHandler(this.ddPanelCont_DragOver);
            this.ddPanelCont.Paint += new System.Windows.Forms.PaintEventHandler(this.ddPanelCont_Paint);
            // 
            // ddLabel
            // 
            this.ddLabel.AllowDrop = true;
            this.ddLabel.AutoSize = true;
            this.ddLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.ddLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ddLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ddLabel.Location = new System.Drawing.Point(195, 17);
            this.ddLabel.Name = "ddLabel";
            this.ddLabel.Size = new System.Drawing.Size(199, 24);
            this.ddLabel.TabIndex = 0;
            this.ddLabel.Text = "Drop Excel file or Text";
            this.ddLabel.Click += new System.EventHandler(this.ddLabel_Click);
            this.ddLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DdPanelCont_DragDrop);
            this.ddLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            // 
            // mainAreaTitle
            // 
            this.mainAreaTitle.AutoSize = true;
            this.mainAreaTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainAreaTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainAreaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.mainAreaTitle.Location = new System.Drawing.Point(457, -1);
            this.mainAreaTitle.Name = "mainAreaTitle";
            this.mainAreaTitle.Size = new System.Drawing.Size(72, 20);
            this.mainAreaTitle.TabIndex = 1;
            this.mainAreaTitle.Text = " Content";
            this.mainAreaTitle.Click += new System.EventHandler(this.mainAreaTitle_Click);
            // 
            // groupTextBox
            // 
            this.groupTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.groupTextBox.Location = new System.Drawing.Point(183, 200);
            this.groupTextBox.MaxLength = 10;
            this.groupTextBox.Multiline = true;
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(95, 30);
            this.groupTextBox.TabIndex = 1;
            this.groupTextBox.TextChanged += new System.EventHandler(this.GroupTextBox_TextChanged);
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.groupsLabel.Location = new System.Drawing.Point(60, 203);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(117, 20);
            this.groupsLabel.TabIndex = 4;
            this.groupsLabel.Text = "Groups (Integer)";
            this.groupsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contentTitlePane
            // 
            this.contentTitlePane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentTitlePane.Controls.Add(this.mainAreaTitle);
            this.contentTitlePane.Location = new System.Drawing.Point(0, 262);
            this.contentTitlePane.Name = "contentTitlePane";
            this.contentTitlePane.Size = new System.Drawing.Size(982, 27);
            this.contentTitlePane.TabIndex = 6;
            // 
            // contentSubTitlePane
            // 
            this.contentSubTitlePane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.contentSubTitlePane.Controls.Add(this.excelDataLabel);
            this.contentSubTitlePane.Controls.Add(this.customSQLLabel);
            this.contentSubTitlePane.Location = new System.Drawing.Point(0, 292);
            this.contentSubTitlePane.Margin = new System.Windows.Forms.Padding(0);
            this.contentSubTitlePane.Name = "contentSubTitlePane";
            this.contentSubTitlePane.Size = new System.Drawing.Size(982, 32);
            this.contentSubTitlePane.TabIndex = 8;
            // 
            // excelDataLabel
            // 
            this.excelDataLabel.AutoSize = true;
            this.excelDataLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.excelDataLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.excelDataLabel.Location = new System.Drawing.Point(708, 4);
            this.excelDataLabel.Name = "excelDataLabel";
            this.excelDataLabel.Size = new System.Drawing.Size(79, 20);
            this.excelDataLabel.TabIndex = 1;
            this.excelDataLabel.Text = "Excel Data";
            // 
            // customSQLLabel
            // 
            this.customSQLLabel.AutoSize = true;
            this.customSQLLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.customSQLLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customSQLLabel.Location = new System.Drawing.Point(144, 4);
            this.customSQLLabel.Name = "customSQLLabel";
            this.customSQLLabel.Size = new System.Drawing.Size(161, 20);
            this.customSQLLabel.TabIndex = 0;
            this.customSQLLabel.Text = "Custom SQL Statement";
            // 
            // executeBtn
            // 
            this.executeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.executeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.executeBtn.Location = new System.Drawing.Point(630, 193);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(118, 40);
            this.executeBtn.TabIndex = 3;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = false;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetBtn.Location = new System.Drawing.Point(781, 193);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(113, 40);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // colTextBox
            // 
            this.colTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.colTextBox.Location = new System.Drawing.Point(390, 200);
            this.colTextBox.MaxLength = 2;
            this.colTextBox.Multiline = true;
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(95, 30);
            this.colTextBox.TabIndex = 2;
            this.colTextBox.TextChanged += new System.EventHandler(this.ColTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(295, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Excel Col #";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // FIlePathLabel
            // 
            this.FIlePathLabel.AutoSize = true;
            this.FIlePathLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FIlePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FIlePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.FIlePathLabel.Location = new System.Drawing.Point(472, 9);
            this.FIlePathLabel.Name = "FIlePathLabel";
            this.FIlePathLabel.Size = new System.Drawing.Size(42, 18);
            this.FIlePathLabel.TabIndex = 13;
            this.FIlePathLabel.Text = "Path ";
            // 
            // systemMSGLabel
            // 
            this.systemMSGLabel.AutoSize = true;
            this.systemMSGLabel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.systemMSGLabel.ForeColor = System.Drawing.Color.Red;
            this.systemMSGLabel.Location = new System.Drawing.Point(0, 56);
            this.systemMSGLabel.MaximumSize = new System.Drawing.Size(982, 20);
            this.systemMSGLabel.MinimumSize = new System.Drawing.Size(982, 20);
            this.systemMSGLabel.Name = "systemMSGLabel";
            this.systemMSGLabel.Size = new System.Drawing.Size(982, 20);
            this.systemMSGLabel.TabIndex = 15;
            this.systemMSGLabel.Text = "This is the message box";
            this.systemMSGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.systemMSGLabel.Visible = false;
            this.systemMSGLabel.Click += new System.EventHandler(this.systemMSGLabel_Click);
            // 
            // mainSqlRichBox
            // 
            this.mainSqlRichBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.mainSqlRichBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainSqlRichBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.mainSqlRichBox.Location = new System.Drawing.Point(0, 324);
            this.mainSqlRichBox.MaxLength = 2147483;
            this.mainSqlRichBox.Name = "mainSqlRichBox";
            this.mainSqlRichBox.Size = new System.Drawing.Size(497, 427);
            this.mainSqlRichBox.TabIndex = 1;
            this.mainSqlRichBox.Text = "Select Test * from (??) \n\n";
            this.mainSqlRichBox.TextChanged += new System.EventHandler(this.mainSqlTextBox_TextChanged);
            // 
            // dataRichBox
            // 
            this.dataRichBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataRichBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataRichBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dataRichBox.Location = new System.Drawing.Point(495, 324);
            this.dataRichBox.Name = "dataRichBox";
            this.dataRichBox.ReadOnly = true;
            this.dataRichBox.Size = new System.Drawing.Size(487, 427);
            this.dataRichBox.TabIndex = 16;
            this.dataRichBox.Text = "All your data ...";
            // 
            // performanceCheckTimer
            // 
            this.performanceCheckTimer.Interval = 1;
            this.performanceCheckTimer.Tick += new System.EventHandler(this.performanceCheckTimer_Tick);
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.performanceLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.performanceLabel.Location = new System.Drawing.Point(832, 97);
            this.performanceLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.performanceLabel.MaximumSize = new System.Drawing.Size(90, 40);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(75, 32);
            this.performanceLabel.TabIndex = 18;
            this.performanceLabel.Text = "Completed in";
            this.performanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.performanceLabel.Visible = false;
            this.performanceLabel.Click += new System.EventHandler(this.performanceLabel_Click);
            // 
            // uniqueCheckBox
            // 
            this.uniqueCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.uniqueCheckBox.Location = new System.Drawing.Point(515, 194);
            this.uniqueCheckBox.Name = "uniqueCheckBox";
            this.uniqueCheckBox.Size = new System.Drawing.Size(93, 40);
            this.uniqueCheckBox.TabIndex = 19;
            this.uniqueCheckBox.Text = "Unqiue";
            this.uniqueCheckBox.UseVisualStyleBackColor = true;
            this.uniqueCheckBox.CheckedChanged += new System.EventHandler(this.uniqueCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.uniqueCheckBox);
            this.Controls.Add(this.performanceLabel);
            this.Controls.Add(this.dataRichBox);
            this.Controls.Add(this.mainSqlRichBox);
            this.Controls.Add(this.systemMSGLabel);
            this.Controls.Add(this.FIlePathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colTextBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.contentSubTitlePane);
            this.Controls.Add(this.contentTitlePane);
            this.Controls.Add(this.groupsLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.ddPanelCont);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ddPanelCont.ResumeLayout(false);
            this.ddPanelCont.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contentTitlePane.ResumeLayout(false);
            this.contentTitlePane.PerformLayout();
            this.contentSubTitlePane.ResumeLayout(false);
            this.contentSubTitlePane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel ddPanelCont;
        private System.Windows.Forms.Label ddLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label groupsLabel;
        private System.Windows.Forms.Label mainAreaTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Panel contentTitlePane;
        private System.Windows.Forms.Panel contentSubTitlePane;
        private System.Windows.Forms.Label excelDataLabel;
        private System.Windows.Forms.Label customSQLLabel;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FIlePathLabel;
        public  System.Windows.Forms.Label systemMSGLabel;
        private System.Windows.Forms.RichTextBox mainSqlRichBox;
        private System.Windows.Forms.RichTextBox dataRichBox;
        private System.Windows.Forms.Timer performanceCheckTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label performanceLabel;
        private System.Windows.Forms.CheckBox uniqueCheckBox;
        private System.Windows.Forms.TextBox colTextBox;
    }
}

