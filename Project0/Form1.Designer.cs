namespace Project0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel = new System.Windows.Forms.GroupBox();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.byAlbum = new System.Windows.Forms.RadioButton();
            this.allAlbums = new System.Windows.Forms.RadioButton();
            this.musicList = new System.Windows.Forms.ListView();
            this.NameHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Singer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Song_duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.findButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.211F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.musicList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAdd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menu, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.30456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.23787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.45757F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel
            // 
            this.groupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupPanel, 2);
            this.groupPanel.Controls.Add(this.comboBoxAlbums);
            this.groupPanel.Controls.Add(this.byAlbum);
            this.groupPanel.Controls.Add(this.allAlbums);
            this.groupPanel.Location = new System.Drawing.Point(3, 33);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(549, 101);
            this.groupPanel.TabIndex = 3;
            this.groupPanel.TabStop = false;
            this.groupPanel.Text = "View";
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Items.AddRange(new object[] {
            "Single"});
            this.comboBoxAlbums.Location = new System.Drawing.Point(195, 61);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(239, 24);
            this.comboBoxAlbums.TabIndex = 2;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // byAlbum
            // 
            this.byAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.byAlbum.AutoSize = true;
            this.byAlbum.Location = new System.Drawing.Point(9, 61);
            this.byAlbum.Name = "byAlbum";
            this.byAlbum.Size = new System.Drawing.Size(87, 21);
            this.byAlbum.TabIndex = 1;
            this.byAlbum.TabStop = true;
            this.byAlbum.Text = "By album";
            this.byAlbum.UseVisualStyleBackColor = true;
            this.byAlbum.Click += new System.EventHandler(this.byAlbum_Click);
            // 
            // allAlbums
            // 
            this.allAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allAlbums.AutoSize = true;
            this.allAlbums.Location = new System.Drawing.Point(9, 21);
            this.allAlbums.Name = "allAlbums";
            this.allAlbums.Size = new System.Drawing.Size(93, 21);
            this.allAlbums.TabIndex = 0;
            this.allAlbums.TabStop = true;
            this.allAlbums.Text = "All albums";
            this.allAlbums.UseVisualStyleBackColor = true;
            this.allAlbums.Click += new System.EventHandler(this.allAlbums_Click);
            // 
            // musicList
            // 
            this.musicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHead,
            this.Singer,
            this.Song_duration,
            this.Album});
            this.tableLayoutPanel1.SetColumnSpan(this.musicList, 3);
            this.musicList.FullRowSelect = true;
            this.musicList.GridLines = true;
            this.musicList.HideSelection = false;
            this.musicList.Location = new System.Drawing.Point(3, 149);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(827, 171);
            this.musicList.TabIndex = 5;
            this.musicList.UseCompatibleStateImageBehavior = false;
            this.musicList.View = System.Windows.Forms.View.Details;
            this.musicList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.musicList_MouseClick);
            // 
            // NameHead
            // 
            this.NameHead.Text = "Name";
            this.NameHead.Width = 154;
            // 
            // Singer
            // 
            this.Singer.Text = "Singer";
            this.Singer.Width = 154;
            // 
            // Song_duration
            // 
            this.Song_duration.Text = "Duration";
            this.Song_duration.Width = 154;
            // 
            // Album
            // 
            this.Album.Text = "Album";
            this.Album.Width = 154;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxAdd, 3);
            this.groupBoxAdd.Controls.Add(this.findButton);
            this.groupBoxAdd.Controls.Add(this.addButton);
            this.groupBoxAdd.Location = new System.Drawing.Point(3, 326);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(827, 112);
            this.groupBoxAdd.TabIndex = 6;
            this.groupBoxAdd.TabStop = false;
            // 
            // findButton
            // 
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findButton.Location = new System.Drawing.Point(475, 21);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(155, 72);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(195, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(155, 72);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.menu, 3);
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(833, 28);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Довідник меломана";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupPanel.ResumeLayout(false);
            this.groupPanel.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupPanel;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.RadioButton byAlbum;
        private System.Windows.Forms.RadioButton allAlbums;
        private System.Windows.Forms.ListView musicList;
        private System.Windows.Forms.ColumnHeader NameHead;
        private System.Windows.Forms.ColumnHeader Singer;
        private System.Windows.Forms.ColumnHeader Song_duration;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button addButton;
    }
}

