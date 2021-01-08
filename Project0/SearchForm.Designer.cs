namespace Project0
{
    partial class SearchForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.radioButtonSinger = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.okFind = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52411F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.47589F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFind, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.okFind, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.83051F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.16949F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 186);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(243, 95);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(231, 88);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxFind, 2);
            this.groupBoxFind.Controls.Add(this.textBoxValue);
            this.groupBoxFind.Controls.Add(this.radioButtonSinger);
            this.groupBoxFind.Controls.Add(this.radioButtonName);
            this.groupBoxFind.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(471, 86);
            this.groupBoxFind.TabIndex = 1;
            this.groupBoxFind.TabStop = false;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(129, 32);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(256, 22);
            this.textBoxValue.TabIndex = 2;
            // 
            // radioButtonSinger
            // 
            this.radioButtonSinger.AutoSize = true;
            this.radioButtonSinger.Location = new System.Drawing.Point(13, 48);
            this.radioButtonSinger.Name = "radioButtonSinger";
            this.radioButtonSinger.Size = new System.Drawing.Size(88, 21);
            this.radioButtonSinger.TabIndex = 1;
            this.radioButtonSinger.TabStop = true;
            this.radioButtonSinger.Text = "By singer";
            this.radioButtonSinger.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(13, 21);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(84, 21);
            this.radioButtonName.TabIndex = 0;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "By name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // okFind
            // 
            this.okFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.okFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.okFind.Location = new System.Drawing.Point(3, 95);
            this.okFind.Name = "okFind";
            this.okFind.Size = new System.Drawing.Size(234, 88);
            this.okFind.TabIndex = 0;
            this.okFind.Text = "Find";
            this.okFind.UseVisualStyleBackColor = true;
            this.okFind.Click += new System.EventHandler(this.okFind_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 183);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchForm";
            this.Text = "Пошук";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button okFind;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.RadioButton radioButtonSinger;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button cancelButton;
    }
}