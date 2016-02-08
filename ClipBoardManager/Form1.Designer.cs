namespace ClipBoardManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFilesAndFolders = new System.Windows.Forms.GroupBox();
            this.lbFilesAndFolders = new System.Windows.Forms.ListBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.lbText = new System.Windows.Forms.ListBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.rbBotomRight = new System.Windows.Forms.RadioButton();
            this.rbBotomLeft = new System.Windows.Forms.RadioButton();
            this.rbTopRight = new System.Windows.Forms.RadioButton();
            this.rbTopLeft = new System.Windows.Forms.RadioButton();
            this.gbContentToCopy = new System.Windows.Forms.GroupBox();
            this.cbFilesAndFolders = new System.Windows.Forms.CheckBox();
            this.cbText = new System.Windows.Forms.CheckBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.gbCategorySortPriority = new System.Windows.Forms.GroupBox();
            this.rbFilesAndFoldersFirst = new System.Windows.Forms.RadioButton();
            this.rbFirstText = new System.Windows.Forms.RadioButton();
            this.rbSortByCategory = new System.Windows.Forms.RadioButton();
            this.rbSortByTime = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudHistorySize = new System.Windows.Forms.NumericUpDown();
            this.cbRememberHistory = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuCloseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuShowHideBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.gbFilesAndFolders.SuspendLayout();
            this.gbText.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.gbContentToCopy.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbCategorySortPriority.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistorySize)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuCloseBtn,
            this.contextMenuShowHideBtn});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(104, 48);
            this.contextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenu_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fileMenu.Location = new System.Drawing.Point(0, 0);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(606, 24);
            this.fileMenu.TabIndex = 1;
            this.fileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearClipboardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearClipboardToolStripMenuItem
            // 
            this.clearClipboardToolStripMenuItem.Name = "clearClipboardToolStripMenuItem";
            this.clearClipboardToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearClipboardToolStripMenuItem.Text = "Clear clipboard";
            this.clearClipboardToolStripMenuItem.Click += new System.EventHandler(this.clearClipboardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gbFilesAndFolders
            // 
            this.gbFilesAndFolders.Controls.Add(this.lbFilesAndFolders);
            this.gbFilesAndFolders.Location = new System.Drawing.Point(12, 27);
            this.gbFilesAndFolders.Name = "gbFilesAndFolders";
            this.gbFilesAndFolders.Size = new System.Drawing.Size(166, 340);
            this.gbFilesAndFolders.TabIndex = 2;
            this.gbFilesAndFolders.TabStop = false;
            this.gbFilesAndFolders.Text = "Files and folders";
            // 
            // lbFilesAndFolders
            // 
            this.lbFilesAndFolders.FormattingEnabled = true;
            this.lbFilesAndFolders.Location = new System.Drawing.Point(6, 19);
            this.lbFilesAndFolders.Name = "lbFilesAndFolders";
            this.lbFilesAndFolders.Size = new System.Drawing.Size(154, 316);
            this.lbFilesAndFolders.TabIndex = 0;
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.lbText);
            this.gbText.Location = new System.Drawing.Point(184, 27);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(166, 340);
            this.gbText.TabIndex = 3;
            this.gbText.TabStop = false;
            this.gbText.Text = "Text";
            // 
            // lbText
            // 
            this.lbText.FormattingEnabled = true;
            this.lbText.Location = new System.Drawing.Point(6, 19);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(151, 316);
            this.lbText.TabIndex = 0;
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.rbBotomRight);
            this.gbPosition.Controls.Add(this.rbBotomLeft);
            this.gbPosition.Controls.Add(this.rbTopRight);
            this.gbPosition.Controls.Add(this.rbTopLeft);
            this.gbPosition.Location = new System.Drawing.Point(358, 27);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(238, 114);
            this.gbPosition.TabIndex = 4;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "groupBox1";
            // 
            // rbBotomRight
            // 
            this.rbBotomRight.AutoSize = true;
            this.rbBotomRight.Checked = true;
            this.rbBotomRight.Location = new System.Drawing.Point(6, 88);
            this.rbBotomRight.Name = "rbBotomRight";
            this.rbBotomRight.Size = new System.Drawing.Size(83, 17);
            this.rbBotomRight.TabIndex = 3;
            this.rbBotomRight.TabStop = true;
            this.rbBotomRight.Text = "Botom Right";
            this.rbBotomRight.UseVisualStyleBackColor = true;
            // 
            // rbBotomLeft
            // 
            this.rbBotomLeft.AutoSize = true;
            this.rbBotomLeft.Location = new System.Drawing.Point(6, 65);
            this.rbBotomLeft.Name = "rbBotomLeft";
            this.rbBotomLeft.Size = new System.Drawing.Size(76, 17);
            this.rbBotomLeft.TabIndex = 2;
            this.rbBotomLeft.Text = "Botom Left";
            this.rbBotomLeft.UseVisualStyleBackColor = true;
            // 
            // rbTopRight
            // 
            this.rbTopRight.AutoSize = true;
            this.rbTopRight.Location = new System.Drawing.Point(6, 42);
            this.rbTopRight.Name = "rbTopRight";
            this.rbTopRight.Size = new System.Drawing.Size(72, 17);
            this.rbTopRight.TabIndex = 1;
            this.rbTopRight.Text = "Top Right";
            this.rbTopRight.UseVisualStyleBackColor = true;
            // 
            // rbTopLeft
            // 
            this.rbTopLeft.AutoSize = true;
            this.rbTopLeft.Location = new System.Drawing.Point(6, 18);
            this.rbTopLeft.Name = "rbTopLeft";
            this.rbTopLeft.Size = new System.Drawing.Size(99, 17);
            this.rbTopLeft.TabIndex = 0;
            this.rbTopLeft.Text = "Top Left Corner";
            this.rbTopLeft.UseVisualStyleBackColor = true;
            // 
            // gbContentToCopy
            // 
            this.gbContentToCopy.Controls.Add(this.cbFilesAndFolders);
            this.gbContentToCopy.Controls.Add(this.cbText);
            this.gbContentToCopy.Location = new System.Drawing.Point(358, 147);
            this.gbContentToCopy.Name = "gbContentToCopy";
            this.gbContentToCopy.Size = new System.Drawing.Size(114, 72);
            this.gbContentToCopy.TabIndex = 5;
            this.gbContentToCopy.TabStop = false;
            this.gbContentToCopy.Text = "groupBox1";
            // 
            // cbFilesAndFolders
            // 
            this.cbFilesAndFolders.AutoSize = true;
            this.cbFilesAndFolders.Checked = true;
            this.cbFilesAndFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFilesAndFolders.Location = new System.Drawing.Point(7, 44);
            this.cbFilesAndFolders.Name = "cbFilesAndFolders";
            this.cbFilesAndFolders.Size = new System.Drawing.Size(105, 17);
            this.cbFilesAndFolders.TabIndex = 1;
            this.cbFilesAndFolders.Text = "Files and Folders";
            this.cbFilesAndFolders.UseVisualStyleBackColor = true;
            // 
            // cbText
            // 
            this.cbText.AutoSize = true;
            this.cbText.Checked = true;
            this.cbText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbText.Location = new System.Drawing.Point(7, 20);
            this.cbText.Name = "cbText";
            this.cbText.Size = new System.Drawing.Size(47, 17);
            this.cbText.TabIndex = 0;
            this.cbText.Text = "Text";
            this.cbText.UseVisualStyleBackColor = true;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.gbCategorySortPriority);
            this.gbSort.Controls.Add(this.rbSortByCategory);
            this.gbSort.Controls.Add(this.rbSortByTime);
            this.gbSort.Location = new System.Drawing.Point(358, 225);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(238, 142);
            this.gbSort.TabIndex = 6;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sort Items";
            // 
            // gbCategorySortPriority
            // 
            this.gbCategorySortPriority.Controls.Add(this.rbFilesAndFoldersFirst);
            this.gbCategorySortPriority.Controls.Add(this.rbFirstText);
            this.gbCategorySortPriority.Location = new System.Drawing.Point(24, 67);
            this.gbCategorySortPriority.Name = "gbCategorySortPriority";
            this.gbCategorySortPriority.Size = new System.Drawing.Size(205, 66);
            this.gbCategorySortPriority.TabIndex = 2;
            this.gbCategorySortPriority.TabStop = false;
            this.gbCategorySortPriority.Text = "groupBox1";
            // 
            // rbFilesAndFoldersFirst
            // 
            this.rbFilesAndFoldersFirst.AutoSize = true;
            this.rbFilesAndFoldersFirst.Location = new System.Drawing.Point(7, 43);
            this.rbFilesAndFoldersFirst.Name = "rbFilesAndFoldersFirst";
            this.rbFilesAndFoldersFirst.Size = new System.Drawing.Size(177, 17);
            this.rbFilesAndFoldersFirst.TabIndex = 1;
            this.rbFilesAndFoldersFirst.TabStop = true;
            this.rbFilesAndFoldersFirst.Text = "First Files and Folders, then Text";
            this.rbFilesAndFoldersFirst.UseVisualStyleBackColor = true;
            // 
            // rbFirstText
            // 
            this.rbFirstText.AutoSize = true;
            this.rbFirstText.Location = new System.Drawing.Point(7, 19);
            this.rbFirstText.Name = "rbFirstText";
            this.rbFirstText.Size = new System.Drawing.Size(173, 17);
            this.rbFirstText.TabIndex = 0;
            this.rbFirstText.TabStop = true;
            this.rbFirstText.Text = "First text, then Files and Folders";
            this.rbFirstText.UseVisualStyleBackColor = true;
            // 
            // rbSortByCategory
            // 
            this.rbSortByCategory.AutoSize = true;
            this.rbSortByCategory.Location = new System.Drawing.Point(7, 44);
            this.rbSortByCategory.Name = "rbSortByCategory";
            this.rbSortByCategory.Size = new System.Drawing.Size(82, 17);
            this.rbSortByCategory.TabIndex = 1;
            this.rbSortByCategory.Text = "By Category";
            this.rbSortByCategory.UseVisualStyleBackColor = true;
            // 
            // rbSortByTime
            // 
            this.rbSortByTime.AutoSize = true;
            this.rbSortByTime.Checked = true;
            this.rbSortByTime.Location = new System.Drawing.Point(7, 20);
            this.rbSortByTime.Name = "rbSortByTime";
            this.rbSortByTime.Size = new System.Drawing.Size(59, 17);
            this.rbSortByTime.TabIndex = 0;
            this.rbSortByTime.TabStop = true;
            this.rbSortByTime.Text = "By time";
            this.rbSortByTime.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudHistorySize);
            this.groupBox3.Controls.Add(this.cbRememberHistory);
            this.groupBox3.Location = new System.Drawing.Point(478, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 72);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // nudHistorySize
            // 
            this.nudHistorySize.Location = new System.Drawing.Point(7, 20);
            this.nudHistorySize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudHistorySize.Name = "nudHistorySize";
            this.nudHistorySize.Size = new System.Drawing.Size(102, 20);
            this.nudHistorySize.TabIndex = 1;
            this.nudHistorySize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cbRememberHistory
            // 
            this.cbRememberHistory.AutoSize = true;
            this.cbRememberHistory.Checked = true;
            this.cbRememberHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRememberHistory.Location = new System.Drawing.Point(6, 46);
            this.cbRememberHistory.Name = "cbRememberHistory";
            this.cbRememberHistory.Size = new System.Drawing.Size(112, 17);
            this.cbRememberHistory.TabIndex = 0;
            this.cbRememberHistory.Text = "Remember History";
            this.cbRememberHistory.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Simple Clipboard Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuCloseBtn
            // 
            this.contextMenuCloseBtn.Name = "contextMenuCloseBtn";
            this.contextMenuCloseBtn.Size = new System.Drawing.Size(152, 22);
            this.contextMenuCloseBtn.Text = "Close";
            this.contextMenuCloseBtn.Click += new System.EventHandler(this.contextMenuCloseBtn_Click);
            // 
            // contextMenuShowHideBtn
            // 
            this.contextMenuShowHideBtn.Name = "contextMenuShowHideBtn";
            this.contextMenuShowHideBtn.Size = new System.Drawing.Size(152, 22);
            this.contextMenuShowHideBtn.Text = "Show";
            this.contextMenuShowHideBtn.Click += new System.EventHandler(this.contextMenuShowHideBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 375);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.gbContentToCopy);
            this.Controls.Add(this.gbPosition);
            this.Controls.Add(this.gbText);
            this.Controls.Add(this.gbFilesAndFolders);
            this.Controls.Add(this.fileMenu);
            this.MainMenuStrip = this.fileMenu;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenu.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            this.fileMenu.PerformLayout();
            this.gbFilesAndFolders.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.gbContentToCopy.ResumeLayout(false);
            this.gbContentToCopy.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.gbCategorySortPriority.ResumeLayout(false);
            this.gbCategorySortPriority.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistorySize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.MenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbFilesAndFolders;
        private System.Windows.Forms.ListBox lbFilesAndFolders;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.ListBox lbText;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.RadioButton rbBotomRight;
        private System.Windows.Forms.RadioButton rbBotomLeft;
        private System.Windows.Forms.RadioButton rbTopRight;
        private System.Windows.Forms.RadioButton rbTopLeft;
        private System.Windows.Forms.GroupBox gbContentToCopy;
        private System.Windows.Forms.CheckBox cbFilesAndFolders;
        private System.Windows.Forms.CheckBox cbText;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.GroupBox gbCategorySortPriority;
        private System.Windows.Forms.RadioButton rbFilesAndFoldersFirst;
        private System.Windows.Forms.RadioButton rbFirstText;
        private System.Windows.Forms.RadioButton rbSortByCategory;
        private System.Windows.Forms.RadioButton rbSortByTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudHistorySize;
        private System.Windows.Forms.CheckBox cbRememberHistory;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCloseBtn;
        private System.Windows.Forms.ToolStripMenuItem contextMenuShowHideBtn;
    }
}

