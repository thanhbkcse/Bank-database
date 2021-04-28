namespace ASS2
{
    partial class Form3
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
            this.Anumber = new System.Windows.Forms.TextBox();
            this.CusCode = new System.Windows.Forms.TextBox();
            this.Acccode1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AccountCode2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Saving = new System.Windows.Forms.CheckBox();
            this.Checking = new System.Windows.Forms.CheckBox();
            this.Loan = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Anumber
            // 
            this.Anumber.Location = new System.Drawing.Point(77, 78);
            this.Anumber.Name = "Anumber";
            this.Anumber.Size = new System.Drawing.Size(100, 20);
            this.Anumber.TabIndex = 0;
            // 
            // CusCode
            // 
            this.CusCode.Location = new System.Drawing.Point(234, 78);
            this.CusCode.Name = "CusCode";
            this.CusCode.Size = new System.Drawing.Size(100, 20);
            this.CusCode.TabIndex = 1;
            // 
            // Acccode1
            // 
            this.Acccode1.Location = new System.Drawing.Point(395, 78);
            this.Acccode1.Name = "Acccode1";
            this.Acccode1.Size = new System.Drawing.Size(100, 20);
            this.Acccode1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account Type Code";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(545, 74);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Information For New Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(237, 273);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 10;
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(395, 273);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(100, 20);
            this.Balance.TabIndex = 11;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(548, 273);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 20);
            this.Rate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rate";
            // 
            // AccountCode2
            // 
            this.AccountCode2.Location = new System.Drawing.Point(313, 187);
            this.AccountCode2.Name = "AccountCode2";
            this.AccountCode2.Size = new System.Drawing.Size(100, 20);
            this.AccountCode2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Enter Account Code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Saving
            // 
            this.Saving.AutoSize = true;
            this.Saving.Location = new System.Drawing.Point(81, 261);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(102, 17);
            this.Saving.TabIndex = 21;
            this.Saving.Text = "Saving Account";
            this.Saving.UseVisualStyleBackColor = true;
            // 
            // Checking
            // 
            this.Checking.AutoSize = true;
            this.Checking.Location = new System.Drawing.Point(81, 297);
            this.Checking.Name = "Checking";
            this.Checking.Size = new System.Drawing.Size(114, 17);
            this.Checking.TabIndex = 22;
            this.Checking.Text = "Checking Account";
            this.Checking.UseVisualStyleBackColor = true;
            // 
            // Loan
            // 
            this.Loan.AutoSize = true;
            this.Loan.Location = new System.Drawing.Point(81, 330);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(50, 17);
            this.Loan.TabIndex = 23;
            this.Loan.Text = "Loan";
            this.Loan.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Loan);
            this.Controls.Add(this.Checking);
            this.Controls.Add(this.Saving);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AccountCode2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Acccode1);
            this.Controls.Add(this.CusCode);
            this.Controls.Add(this.Anumber);
            this.Name = "Form3";
            this.Text = "Create New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Anumber;
        private System.Windows.Forms.TextBox CusCode;
        private System.Windows.Forms.TextBox Acccode1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AccountCode2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Saving;
        private System.Windows.Forms.CheckBox Checking;
        private System.Windows.Forms.CheckBox Loan;
    }
}