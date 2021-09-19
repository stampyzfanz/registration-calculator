
namespace Registration_calculator
{
    partial class Page_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_3));
            this.Car = new System.Windows.Forms.PictureBox();
            this.BackBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.PictureBox();
            this.TxtRegistrationFee = new System.Windows.Forms.TextBox();
            this.Registration_fee = new System.Windows.Forms.TextBox();
            this.TxtStampDuty = new System.Windows.Forms.TextBox();
            this.Stamp_duty = new System.Windows.Forms.TextBox();
            this.TxtInsurancePremium = new System.Windows.Forms.TextBox();
            this.Insurance_premium = new System.Windows.Forms.TextBox();
            this.TxtTotalRegistrationCost = new System.Windows.Forms.TextBox();
            this.Total_registration_cost = new System.Windows.Forms.TextBox();
            this.TxtTotalPayable = new System.Windows.Forms.TextBox();
            this.Total_amount_payable = new System.Windows.Forms.TextBox();
            this.TxtVehicleTax = new System.Windows.Forms.TextBox();
            this.Vehicle_tax = new System.Windows.Forms.TextBox();
            this.ContinueBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            this.SuspendLayout();
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.SystemColors.Control;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(13, 111);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(405, 291);
            this.Car.TabIndex = 10;
            this.Car.TabStop = false;
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackBTN.ForeColor = System.Drawing.Color.White;
            this.BackBTN.Location = new System.Drawing.Point(550, 416);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(106, 26);
            this.BackBTN.TabIndex = 9;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(683, 416);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(106, 26);
            this.CloseBTN.TabIndex = 8;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Highlight;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(13, 26);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(751, 46);
            this.Title.TabIndex = 39;
            this.Title.Text = "Vehicle Registration Cost Calculator ";
            this.Title.Enter += new System.EventHandler(this.Title_Enter);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Highlight;
            this.Header.Location = new System.Drawing.Point(-11, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(823, 82);
            this.Header.TabIndex = 7;
            this.Header.TabStop = false;
            // 
            // TxtRegistrationFee
            // 
            this.TxtRegistrationFee.BackColor = System.Drawing.SystemColors.Control;
            this.TxtRegistrationFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegistrationFee.Enabled = false;
            this.TxtRegistrationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TxtRegistrationFee.Location = new System.Drawing.Point(633, 136);
            this.TxtRegistrationFee.Name = "TxtRegistrationFee";
            this.TxtRegistrationFee.Size = new System.Drawing.Size(153, 20);
            this.TxtRegistrationFee.TabIndex = 22;
            // 
            // Registration_fee
            // 
            this.Registration_fee.BackColor = System.Drawing.SystemColors.Control;
            this.Registration_fee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registration_fee.Enabled = false;
            this.Registration_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Registration_fee.Location = new System.Drawing.Point(445, 136);
            this.Registration_fee.Name = "Registration_fee";
            this.Registration_fee.Size = new System.Drawing.Size(157, 20);
            this.Registration_fee.TabIndex = 21;
            this.Registration_fee.Text = "Registration fee:";
            // 
            // TxtStampDuty
            // 
            this.TxtStampDuty.BackColor = System.Drawing.SystemColors.Control;
            this.TxtStampDuty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStampDuty.Enabled = false;
            this.TxtStampDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TxtStampDuty.Location = new System.Drawing.Point(633, 175);
            this.TxtStampDuty.Name = "TxtStampDuty";
            this.TxtStampDuty.Size = new System.Drawing.Size(153, 20);
            this.TxtStampDuty.TabIndex = 24;
            // 
            // Stamp_duty
            // 
            this.Stamp_duty.BackColor = System.Drawing.SystemColors.Control;
            this.Stamp_duty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stamp_duty.Enabled = false;
            this.Stamp_duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Stamp_duty.Location = new System.Drawing.Point(445, 175);
            this.Stamp_duty.Name = "Stamp_duty";
            this.Stamp_duty.Size = new System.Drawing.Size(157, 20);
            this.Stamp_duty.TabIndex = 23;
            this.Stamp_duty.Text = "Stamp duty:";
            // 
            // TxtInsurancePremium
            // 
            this.TxtInsurancePremium.BackColor = System.Drawing.SystemColors.Control;
            this.TxtInsurancePremium.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInsurancePremium.Enabled = false;
            this.TxtInsurancePremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TxtInsurancePremium.Location = new System.Drawing.Point(633, 218);
            this.TxtInsurancePremium.Name = "TxtInsurancePremium";
            this.TxtInsurancePremium.Size = new System.Drawing.Size(153, 20);
            this.TxtInsurancePremium.TabIndex = 26;
            // 
            // Insurance_premium
            // 
            this.Insurance_premium.BackColor = System.Drawing.SystemColors.Control;
            this.Insurance_premium.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Insurance_premium.Enabled = false;
            this.Insurance_premium.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Insurance_premium.Location = new System.Drawing.Point(445, 218);
            this.Insurance_premium.Name = "Insurance_premium";
            this.Insurance_premium.Size = new System.Drawing.Size(157, 20);
            this.Insurance_premium.TabIndex = 25;
            this.Insurance_premium.Text = "Insurance premium:";
            // 
            // TxtTotalRegistrationCost
            // 
            this.TxtTotalRegistrationCost.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTotalRegistrationCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotalRegistrationCost.Enabled = false;
            this.TxtTotalRegistrationCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TxtTotalRegistrationCost.Location = new System.Drawing.Point(633, 258);
            this.TxtTotalRegistrationCost.Name = "TxtTotalRegistrationCost";
            this.TxtTotalRegistrationCost.Size = new System.Drawing.Size(153, 20);
            this.TxtTotalRegistrationCost.TabIndex = 28;
            // 
            // Total_registration_cost
            // 
            this.Total_registration_cost.BackColor = System.Drawing.SystemColors.Control;
            this.Total_registration_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_registration_cost.Enabled = false;
            this.Total_registration_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Total_registration_cost.Location = new System.Drawing.Point(445, 258);
            this.Total_registration_cost.Name = "Total_registration_cost";
            this.Total_registration_cost.Size = new System.Drawing.Size(193, 20);
            this.Total_registration_cost.TabIndex = 27;
            this.Total_registration_cost.Text = "Total registration cost:";
            // 
            // TxtTotalPayable
            // 
            this.TxtTotalPayable.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTotalPayable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotalPayable.Enabled = false;
            this.TxtTotalPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TxtTotalPayable.Location = new System.Drawing.Point(633, 335);
            this.TxtTotalPayable.Name = "TxtTotalPayable";
            this.TxtTotalPayable.Size = new System.Drawing.Size(153, 20);
            this.TxtTotalPayable.TabIndex = 32;
            // 
            // Total_amount_payable
            // 
            this.Total_amount_payable.BackColor = System.Drawing.SystemColors.Control;
            this.Total_amount_payable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_amount_payable.Enabled = false;
            this.Total_amount_payable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Total_amount_payable.Location = new System.Drawing.Point(445, 335);
            this.Total_amount_payable.Name = "Total_amount_payable";
            this.Total_amount_payable.Size = new System.Drawing.Size(169, 20);
            this.Total_amount_payable.TabIndex = 31;
            this.Total_amount_payable.Text = "Total amount payable:";
            // 
            // TxtVehicleTax
            // 
            this.TxtVehicleTax.BackColor = System.Drawing.SystemColors.Control;
            this.TxtVehicleTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVehicleTax.Enabled = false;
            this.TxtVehicleTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TxtVehicleTax.Location = new System.Drawing.Point(633, 295);
            this.TxtVehicleTax.Name = "TxtVehicleTax";
            this.TxtVehicleTax.Size = new System.Drawing.Size(153, 20);
            this.TxtVehicleTax.TabIndex = 30;
            // 
            // Vehicle_tax
            // 
            this.Vehicle_tax.BackColor = System.Drawing.SystemColors.Control;
            this.Vehicle_tax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vehicle_tax.Enabled = false;
            this.Vehicle_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Vehicle_tax.Location = new System.Drawing.Point(445, 295);
            this.Vehicle_tax.Name = "Vehicle_tax";
            this.Vehicle_tax.Size = new System.Drawing.Size(157, 20);
            this.Vehicle_tax.TabIndex = 29;
            this.Vehicle_tax.Text = "Vehicle tax:";
            // 
            // ContinueBTN
            // 
            this.ContinueBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.ContinueBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContinueBTN.ForeColor = System.Drawing.Color.White;
            this.ContinueBTN.Location = new System.Drawing.Point(423, 416);
            this.ContinueBTN.Name = "ContinueBTN";
            this.ContinueBTN.Size = new System.Drawing.Size(106, 26);
            this.ContinueBTN.TabIndex = 40;
            this.ContinueBTN.Text = "Continue";
            this.ContinueBTN.UseVisualStyleBackColor = false;
            this.ContinueBTN.Click += new System.EventHandler(this.ContinueBTN_Click);
            // 
            // Page_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinueBTN);
            this.Controls.Add(this.TxtTotalPayable);
            this.Controls.Add(this.Total_amount_payable);
            this.Controls.Add(this.TxtVehicleTax);
            this.Controls.Add(this.Vehicle_tax);
            this.Controls.Add(this.TxtTotalRegistrationCost);
            this.Controls.Add(this.Total_registration_cost);
            this.Controls.Add(this.TxtInsurancePremium);
            this.Controls.Add(this.Insurance_premium);
            this.Controls.Add(this.TxtStampDuty);
            this.Controls.Add(this.Stamp_duty);
            this.Controls.Add(this.TxtRegistrationFee);
            this.Controls.Add(this.Registration_fee);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Header);
            this.Name = "Page_3";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.TextBox TxtRegistrationFee;
        private System.Windows.Forms.TextBox Registration_fee;
        private System.Windows.Forms.TextBox TxtStampDuty;
        private System.Windows.Forms.TextBox Stamp_duty;
        private System.Windows.Forms.TextBox TxtInsurancePremium;
        private System.Windows.Forms.TextBox Insurance_premium;
        private System.Windows.Forms.TextBox TxtTotalRegistrationCost;
        private System.Windows.Forms.TextBox Total_registration_cost;
        private System.Windows.Forms.TextBox TxtTotalPayable;
        private System.Windows.Forms.TextBox Total_amount_payable;
        private System.Windows.Forms.TextBox TxtVehicleTax;
        private System.Windows.Forms.TextBox Vehicle_tax;
        private System.Windows.Forms.Button ContinueBTN;
    }
}