
namespace Registration_calculator
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.Title = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.PictureBox();
            this.ContinueBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Text_1 = new System.Windows.Forms.TextBox();
            this.Text_2 = new System.Windows.Forms.TextBox();
            this.Text_3 = new System.Windows.Forms.TextBox();
            this.Text_4 = new System.Windows.Forms.TextBox();
            this.Text_5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Highlight;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(27, 28);
            this.Title.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(1455, 68);
            this.Title.TabIndex = 2;
            this.Title.Text = "Vehicle Registration Cost Calculator ";
            this.Title.Enter += new System.EventHandler(this.Title_Enter);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Highlight;
            this.Header.Location = new System.Drawing.Point(-18, -8);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1234, 126);
            this.Header.TabIndex = 1;
            this.Header.TabStop = false;
            // 
            // ContinueBTN
            // 
            this.ContinueBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.ContinueBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContinueBTN.ForeColor = System.Drawing.Color.White;
            this.ContinueBTN.Location = new System.Drawing.Point(1006, 628);
            this.ContinueBTN.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ContinueBTN.Name = "ContinueBTN";
            this.ContinueBTN.Size = new System.Drawing.Size(174, 43);
            this.ContinueBTN.TabIndex = 0;
            this.ContinueBTN.Text = "Continue";
            this.ContinueBTN.UseVisualStyleBackColor = false;
            this.ContinueBTN.Click += new System.EventHandler(this.ContinueBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelBTN.ForeColor = System.Drawing.Color.White;
            this.CancelBTN.Location = new System.Drawing.Point(804, 628);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(174, 43);
            this.CancelBTN.TabIndex = 4;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.SystemColors.Control;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(18, 149);
            this.Car.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(608, 448);
            this.Car.TabIndex = 5;
            this.Car.TabStop = false;
            // 
            // Text_1
            // 
            this.Text_1.BackColor = System.Drawing.SystemColors.Control;
            this.Text_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_1.Enabled = false;
            this.Text_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Text_1.Location = new System.Drawing.Point(606, 169);
            this.Text_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_1.Name = "Text_1";
            this.Text_1.Size = new System.Drawing.Size(610, 30);
            this.Text_1.TabIndex = 15;
            this.Text_1.Text = "Welcome to the Vehicle Registration Cost Caculator.";
            // 
            // Text_2
            // 
            this.Text_2.BackColor = System.Drawing.SystemColors.Control;
            this.Text_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_2.Enabled = false;
            this.Text_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Text_2.Location = new System.Drawing.Point(606, 312);
            this.Text_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_2.Name = "Text_2";
            this.Text_2.Size = new System.Drawing.Size(610, 30);
            this.Text_2.TabIndex = 16;
            this.Text_2.Text = "Please enter your car details in the apropreate boxes.";
            // 
            // Text_3
            // 
            this.Text_3.BackColor = System.Drawing.SystemColors.Control;
            this.Text_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_3.Enabled = false;
            this.Text_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Text_3.Location = new System.Drawing.Point(606, 352);
            this.Text_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_3.Name = "Text_3";
            this.Text_3.Size = new System.Drawing.Size(610, 30);
            this.Text_3.TabIndex = 17;
            this.Text_3.Text = "Use the back button to go back to change any input.";
            // 
            // Text_4
            // 
            this.Text_4.BackColor = System.Drawing.SystemColors.Control;
            this.Text_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_4.Enabled = false;
            this.Text_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Text_4.Location = new System.Drawing.Point(606, 392);
            this.Text_4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_4.Name = "Text_4";
            this.Text_4.Size = new System.Drawing.Size(610, 30);
            this.Text_4.TabIndex = 18;
            this.Text_4.Text = "On the last page all of your costs will be displayed.";
            // 
            // Text_5
            // 
            this.Text_5.BackColor = System.Drawing.SystemColors.Control;
            this.Text_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_5.Enabled = false;
            this.Text_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Text_5.Location = new System.Drawing.Point(534, 566);
            this.Text_5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_5.Name = "Text_5";
            this.Text_5.Size = new System.Drawing.Size(678, 30);
            this.Text_5.TabIndex = 19;
            this.Text_5.Text = "Press continue to begin, Thank you for using our calculator!";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Text_5);
            this.Controls.Add(this.Text_4);
            this.Controls.Add(this.Text_3);
            this.Controls.Add(this.Text_2);
            this.Controls.Add(this.Text_1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.ContinueBTN);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Header);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LandingPage";
            this.Text = "Landing Page";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.Button ContinueBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.TextBox Text_1;
        private System.Windows.Forms.TextBox Text_2;
        private System.Windows.Forms.TextBox Text_3;
        private System.Windows.Forms.TextBox Text_4;
        private System.Windows.Forms.TextBox Text_5;
    }
}

