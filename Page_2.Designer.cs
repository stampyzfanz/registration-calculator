
namespace Registration_calculator
{
    partial class Page_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_2));
            this.Title = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.ContinueBTN = new System.Windows.Forms.Button();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.Wholesale_price = new System.Windows.Forms.TextBox();
            this.OwnerNameLabel = new System.Windows.Forms.TextBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.PictureBox();
            this.Business = new System.Windows.Forms.RadioButton();
            this.Private = new System.Windows.Forms.RadioButton();
            this.price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Highlight;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(18, 18);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(970, 46);
            this.Title.TabIndex = 39;
            this.Title.Text = "Vehicle Registration Cost Calculator ";
            this.Title.Enter += new System.EventHandler(this.Title_Enter);
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelBTN.ForeColor = System.Drawing.Color.White;
            this.CancelBTN.Location = new System.Drawing.Point(421, 412);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(106, 26);
            this.CancelBTN.TabIndex = 38;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackBTN.ForeColor = System.Drawing.Color.White;
            this.BackBTN.Location = new System.Drawing.Point(549, 412);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(106, 26);
            this.BackBTN.TabIndex = 37;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // ContinueBTN
            // 
            this.ContinueBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.ContinueBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContinueBTN.ForeColor = System.Drawing.Color.White;
            this.ContinueBTN.Location = new System.Drawing.Point(682, 412);
            this.ContinueBTN.Name = "ContinueBTN";
            this.ContinueBTN.Size = new System.Drawing.Size(106, 26);
            this.ContinueBTN.TabIndex = 36;
            this.ContinueBTN.Text = "Continue";
            this.ContinueBTN.UseVisualStyleBackColor = false;
            this.ContinueBTN.Click += new System.EventHandler(this.ContinueBTN_Click);
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(612, 223);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(173, 20);
            this.OwnerName.TabIndex = 33;
            // 
            // Wholesale_price
            // 
            this.Wholesale_price.BackColor = System.Drawing.SystemColors.Control;
            this.Wholesale_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Wholesale_price.Enabled = false;
            this.Wholesale_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Wholesale_price.Location = new System.Drawing.Point(439, 327);
            this.Wholesale_price.Name = "Wholesale_price";
            this.Wholesale_price.Size = new System.Drawing.Size(218, 20);
            this.Wholesale_price.TabIndex = 30;
            this.Wholesale_price.Text = "Wholesale Price ($):";
            // 
            // OwnerNameLabel
            // 
            this.OwnerNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.OwnerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OwnerNameLabel.Enabled = false;
            this.OwnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.OwnerNameLabel.Location = new System.Drawing.Point(439, 221);
            this.OwnerNameLabel.Name = "OwnerNameLabel";
            this.OwnerNameLabel.Size = new System.Drawing.Size(157, 20);
            this.OwnerNameLabel.TabIndex = 29;
            this.OwnerNameLabel.Text = "Owner Name:";
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.SystemColors.Control;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(1, 119);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(405, 291);
            this.Car.TabIndex = 27;
            this.Car.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Highlight;
            this.Header.Location = new System.Drawing.Point(-11, -13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(823, 82);
            this.Header.TabIndex = 25;
            this.Header.TabStop = false;
            // 
            // Business
            // 
            this.Business.AutoSize = true;
            this.Business.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Business.Location = new System.Drawing.Point(439, 125);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(101, 26);
            this.Business.TabIndex = 42;
            this.Business.TabStop = true;
            this.Business.Text = "Business";
            this.Business.UseVisualStyleBackColor = true;
            // 
            // Private
            // 
            this.Private.AutoSize = true;
            this.Private.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Private.Location = new System.Drawing.Point(625, 126);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(84, 26);
            this.Private.TabIndex = 43;
            this.Private.TabStop = true;
            this.Private.Text = "Private";
            this.Private.UseVisualStyleBackColor = true;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(612, 327);
            this.price.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(173, 20);
            this.price.TabIndex = 44;
            // 
            // Page_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Private);
            this.Controls.Add(this.Business);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.ContinueBTN);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.Wholesale_price);
            this.Controls.Add(this.OwnerNameLabel);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Header);
            this.Name = "Page_2";
            this.Text = "Input Page 2";
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button ContinueBTN;
        public System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.TextBox OwnerNameLabel;
        private System.Windows.Forms.TextBox Wholesale_price;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.RadioButton Business;
        public System.Windows.Forms.RadioButton Private;
        public System.Windows.Forms.NumericUpDown price;
    }
}