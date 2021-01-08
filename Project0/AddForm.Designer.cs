namespace Project0
{
    partial class AddForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Singer = new System.Windows.Forms.Label();
            this.Time_duration = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SingerBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Album = new System.Windows.Forms.Label();
            this.musicTime = new System.Windows.Forms.DateTimePicker();
            this.AlbumBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Singer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Time_duration, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SingerBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConfirmButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Album, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.musicTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AlbumBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.37037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 233);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Singer
            // 
            this.Singer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Singer.AutoSize = true;
            this.Singer.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Singer.Location = new System.Drawing.Point(214, 37);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(61, 30);
            this.Singer.TabIndex = 3;
            this.Singer.Text = "Singer";
            // 
            // Time_duration
            // 
            this.Time_duration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Time_duration.AutoSize = true;
            this.Time_duration.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Time_duration.Location = new System.Drawing.Point(367, 37);
            this.Time_duration.Name = "Time_duration";
            this.Time_duration.Size = new System.Drawing.Size(80, 30);
            this.Time_duration.TabIndex = 4;
            this.Time_duration.Text = "Duration";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(3, 70);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(141, 22);
            this.NameBox.TabIndex = 0;
            // 
            // SingerBox
            // 
            this.SingerBox.Location = new System.Drawing.Point(166, 70);
            this.SingerBox.Name = "SingerBox";
            this.SingerBox.Size = new System.Drawing.Size(141, 22);
            this.SingerBox.TabIndex = 6;
            // 
            // ConfirmButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ConfirmButton, 2);
            this.ConfirmButton.Location = new System.Drawing.Point(166, 138);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(320, 51);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Album
            // 
            this.Album.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Album.AutoSize = true;
            this.Album.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Album.Location = new System.Drawing.Point(540, 37);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(63, 30);
            this.Album.TabIndex = 5;
            this.Album.Text = "Album";
            // 
            // musicTime
            // 
            this.musicTime.Location = new System.Drawing.Point(329, 70);
            this.musicTime.Name = "musicTime";
            this.musicTime.Size = new System.Drawing.Size(135, 22);
            this.musicTime.TabIndex = 9;
            // 
            // AlbumBox
            // 
            this.AlbumBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumBox.FormattingEnabled = true;
            this.AlbumBox.Location = new System.Drawing.Point(492, 70);
            this.AlbumBox.Name = "AlbumBox";
            this.AlbumBox.Size = new System.Drawing.Size(160, 24);
            this.AlbumBox.TabIndex = 2;
            this.AlbumBox.TextChanged += new System.EventHandler(this.AlbumBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.NameLabel.Location = new System.Drawing.Point(52, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 30);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 233);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddForm";
            this.Text = "Додавання";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Singer;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox AlbumBox;
        private System.Windows.Forms.Label Time_duration;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.TextBox SingerBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.DateTimePicker musicTime;
        private System.Windows.Forms.Label NameLabel;
    }
}