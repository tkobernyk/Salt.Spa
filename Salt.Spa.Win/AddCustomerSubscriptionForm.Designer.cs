namespace Salt.Spa.Win
{
    partial class AddCustomerSubscriptionForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.ddlSubscriptions = new System.Windows.Forms.ComboBox();
            this.lblSubscriptionNumber = new System.Windows.Forms.Label();
            this.txtSessionsCount = new System.Windows.Forms.NumericUpDown();
            this.lblSessionsCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSessionsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Додати";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Ім\'я:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(114, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(127, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSessionsCount);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtSessionsCount);
            this.groupBox1.Controls.Add(this.lblSubscriptionNumber);
            this.groupBox1.Controls.Add(this.ddlSubscriptions);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новий клієнт";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Прізвище:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(114, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(127, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 79);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Телефон:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(114, 76);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(127, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // ddlSubscriptions
            // 
            this.ddlSubscriptions.FormattingEnabled = true;
            this.ddlSubscriptions.Location = new System.Drawing.Point(114, 102);
            this.ddlSubscriptions.Name = "ddlSubscriptions";
            this.ddlSubscriptions.Size = new System.Drawing.Size(127, 21);
            this.ddlSubscriptions.TabIndex = 7;
            // 
            // lblSubscriptionNumber
            // 
            this.lblSubscriptionNumber.AutoSize = true;
            this.lblSubscriptionNumber.Location = new System.Drawing.Point(6, 105);
            this.lblSubscriptionNumber.Name = "lblSubscriptionNumber";
            this.lblSubscriptionNumber.Size = new System.Drawing.Size(91, 13);
            this.lblSubscriptionNumber.TabIndex = 8;
            this.lblSubscriptionNumber.Text = "Номер підписки:";
            // 
            // txtSessionsCount
            // 
            this.txtSessionsCount.Location = new System.Drawing.Point(114, 129);
            this.txtSessionsCount.Name = "txtSessionsCount";
            this.txtSessionsCount.Size = new System.Drawing.Size(127, 20);
            this.txtSessionsCount.TabIndex = 9;
            // 
            // lblSessionsCount
            // 
            this.lblSessionsCount.AutoSize = true;
            this.lblSessionsCount.Location = new System.Drawing.Point(4, 131);
            this.lblSessionsCount.Name = "lblSessionsCount";
            this.lblSessionsCount.Size = new System.Drawing.Size(97, 13);
            this.lblSessionsCount.TabIndex = 10;
            this.lblSessionsCount.Text = "Кількість сеансів:";
            // 
            // AddCustomerSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 226);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerSubscriptionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати клієнта";
            this.Load += new System.EventHandler(this.AddCustomerSubscriptionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSessionsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSessionsCount;
        private System.Windows.Forms.NumericUpDown txtSessionsCount;
        private System.Windows.Forms.Label lblSubscriptionNumber;
        private System.Windows.Forms.ComboBox ddlSubscriptions;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
    }
}