namespace ASS2
{
    partial class Form4
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
            this.Saving_Acc = new System.Windows.Forms.DataGridView();
            this.Checking_Acc = new System.Windows.Forms.DataGridView();
            this.Loan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Saving_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checking_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loan)).BeginInit();
            this.SuspendLayout();
            // 
            // Saving_Acc
            // 
            this.Saving_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Saving_Acc.Location = new System.Drawing.Point(35, 31);
            this.Saving_Acc.Name = "Saving_Acc";
            this.Saving_Acc.Size = new System.Drawing.Size(729, 150);
            this.Saving_Acc.TabIndex = 0;
            // 
            // Checking_Acc
            // 
            this.Checking_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Checking_Acc.Location = new System.Drawing.Point(35, 224);
            this.Checking_Acc.Name = "Checking_Acc";
            this.Checking_Acc.Size = new System.Drawing.Size(729, 150);
            this.Checking_Acc.TabIndex = 1;
            this.Checking_Acc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Checking_Acc_CellContentClick);
            // 
            // Loan
            // 
            this.Loan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Loan.Location = new System.Drawing.Point(35, 404);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(729, 150);
            this.Loan.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 566);
            this.Controls.Add(this.Loan);
            this.Controls.Add(this.Checking_Acc);
            this.Controls.Add(this.Saving_Acc);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.Saving_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checking_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Saving_Acc;
        private System.Windows.Forms.DataGridView Checking_Acc;
        private System.Windows.Forms.DataGridView Loan;
    }
}