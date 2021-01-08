namespace Project0
{
    partial class RemoveForm
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
            this.okRemove = new System.Windows.Forms.Button();
            this.cancelRemove = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.okRemove, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelRemove, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.question, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 181);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // okRemove
            // 
            this.okRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okRemove.Location = new System.Drawing.Point(3, 93);
            this.okRemove.Name = "okRemove";
            this.okRemove.Size = new System.Drawing.Size(256, 85);
            this.okRemove.TabIndex = 1;
            this.okRemove.Text = "YES";
            this.okRemove.UseVisualStyleBackColor = true;
            this.okRemove.Click += new System.EventHandler(this.okRemove_Click);
            // 
            // cancelRemove
            // 
            this.cancelRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelRemove.Location = new System.Drawing.Point(265, 93);
            this.cancelRemove.Name = "cancelRemove";
            this.cancelRemove.Size = new System.Drawing.Size(257, 85);
            this.cancelRemove.TabIndex = 2;
            this.cancelRemove.Text = "NO";
            this.cancelRemove.UseVisualStyleBackColor = true;
            this.cancelRemove.Click += new System.EventHandler(this.cancelRemove_Click);
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.question.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.question, 2);
            this.question.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.question.Location = new System.Drawing.Point(3, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(519, 90);
            this.question.TabIndex = 0;
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 182);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RemoveForm";
            this.Text = "Видалення";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button okRemove;
        private System.Windows.Forms.Button cancelRemove;
        private System.Windows.Forms.Label question;
    }
}