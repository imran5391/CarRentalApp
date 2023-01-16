
namespace CarRentalApp
{
    partial class AddRentalRecord
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tbCutomerName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtDateReturned = new System.Windows.Forms.DateTimePicker();
            this.dtDateRented = new System.Windows.Forms.DateTimePicker();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.lblTypeofCar = new System.Windows.Forms.Label();
            this.cbTypeofCar = new System.Windows.Forms.ComboBox();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(26, 69);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(105, 19);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // tbCutomerName
            // 
            this.tbCutomerName.Location = new System.Drawing.Point(29, 98);
            this.tbCutomerName.Name = "tbCutomerName";
            this.tbCutomerName.Size = new System.Drawing.Size(200, 20);
            this.tbCutomerName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(273, 242);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 39);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtDateReturned
            // 
            this.dtDateReturned.Location = new System.Drawing.Point(272, 173);
            this.dtDateReturned.Name = "dtDateReturned";
            this.dtDateReturned.Size = new System.Drawing.Size(200, 20);
            this.dtDateReturned.TabIndex = 4;
            // 
            // dtDateRented
            // 
            this.dtDateRented.Location = new System.Drawing.Point(29, 173);
            this.dtDateRented.Name = "dtDateRented";
            this.dtDateRented.Size = new System.Drawing.Size(200, 20);
            this.dtDateRented.TabIndex = 3;
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRented.Location = new System.Drawing.Point(26, 148);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(85, 19);
            this.lblDateRented.TabIndex = 5;
            this.lblDateRented.Text = "Date Rented";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(269, 148);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(97, 19);
            this.lblDateReturned.TabIndex = 6;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // lblTypeofCar
            // 
            this.lblTypeofCar.AutoSize = true;
            this.lblTypeofCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeofCar.Location = new System.Drawing.Point(26, 226);
            this.lblTypeofCar.Name = "lblTypeofCar";
            this.lblTypeofCar.Size = new System.Drawing.Size(82, 19);
            this.lblTypeofCar.TabIndex = 7;
            this.lblTypeofCar.Text = "Type of Car";
            // 
            // cbTypeofCar
            // 
            this.cbTypeofCar.FormattingEnabled = true;
            this.cbTypeofCar.Items.AddRange(new object[] {
            "Honda",
            "Maruti"});
            this.cbTypeofCar.Location = new System.Drawing.Point(29, 260);
            this.cbTypeofCar.Name = "cbTypeofCar";
            this.cbTypeofCar.Size = new System.Drawing.Size(200, 21);
            this.cbTypeofCar.TabIndex = 5;
            // 
            // lblCarRentalSystem
            // 
            this.lblCarRentalSystem.AutoSize = true;
            this.lblCarRentalSystem.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRentalSystem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblCarRentalSystem.Location = new System.Drawing.Point(80, 9);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(331, 37);
            this.lblCarRentalSystem.TabIndex = 9;
            this.lblCarRentalSystem.Text = "Add Rental Rental ";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(273, 98);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(199, 20);
            this.tbCost.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cost";
            // 
            // AddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lblCarRentalSystem);
            this.Controls.Add(this.cbTypeofCar);
            this.Controls.Add(this.lblTypeofCar);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblDateRented);
            this.Controls.Add(this.dtDateRented);
            this.Controls.Add(this.dtDateReturned);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbCutomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "AddRentalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox tbCutomerName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtDateReturned;
        private System.Windows.Forms.DateTimePicker dtDateRented;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Label lblTypeofCar;
        private System.Windows.Forms.ComboBox cbTypeofCar;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label1;
    }
}

