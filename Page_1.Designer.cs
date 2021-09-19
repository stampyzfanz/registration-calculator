
namespace Registration_calculator
{
    partial class Page_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_1));
            this.Header = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Make = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.BackBTN = new System.Windows.Forms.Button();
            this.ContinueBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.weightNumeric = new System.Windows.Forms.NumericUpDown();
            this.Sedan = new System.Windows.Forms.RadioButton();
            this.Wagon = new System.Windows.Forms.RadioButton();
            this.Body_shape = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Highlight;
            this.Header.Location = new System.Drawing.Point(-11, -13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(823, 82);
            this.Header.TabIndex = 7;
            this.Header.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Make
            // 
            this.Make.BackColor = System.Drawing.SystemColors.Control;
            this.Make.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Make.Enabled = false;
            this.Make.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Make.Location = new System.Drawing.Point(439, 146);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(157, 20);
            this.Make.TabIndex = 14;
            this.Make.Text = "Make:";
            // 
            // Weight
            // 
            this.Weight.BackColor = System.Drawing.SystemColors.Control;
            this.Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Weight.Enabled = false;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Weight.Location = new System.Drawing.Point(439, 303);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(157, 20);
            this.Weight.TabIndex = 16;
            this.Weight.Text = "Weight (Kg):";
            // 
            // Model
            // 
            this.Model.BackColor = System.Drawing.SystemColors.Control;
            this.Model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Model.Enabled = false;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Model.Location = new System.Drawing.Point(439, 201);
            this.Model.Name = "Model";
            this.Model.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Model.Size = new System.Drawing.Size(157, 20);
            this.Model.TabIndex = 15;
            this.Model.Text = "Model:";
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
            this.BackBTN.TabIndex = 22;
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
            this.ContinueBTN.TabIndex = 21;
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
            this.CancelBTN.Location = new System.Drawing.Point(425, 412);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(106, 26);
            this.CancelBTN.TabIndex = 23;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Highlight;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 12);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(647, 46);
            this.Title.TabIndex = 24;
            this.Title.Text = "Vehicle Registration Cost Calculator ";
            this.Title.Enter += new System.EventHandler(this.Title_Enter);
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(1, 99);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(405, 291);
            this.Car.TabIndex = 11;
            this.Car.TabStop = false;
            // 
            // makeComboBox
            // 
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Location = new System.Drawing.Point(549, 146);
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(226, 21);
            this.makeComboBox.TabIndex = 25;
            this.makeComboBox.TextChanged += new System.EventHandler(this.makeComboBox_TextChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(549, 202);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(226, 21);
            this.modelComboBox.TabIndex = 26;
            // 
            // weightNumeric
            // 
            this.weightNumeric.Location = new System.Drawing.Point(549, 306);
            this.weightNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.weightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNumeric.Name = "weightNumeric";
            this.weightNumeric.Size = new System.Drawing.Size(226, 20);
            this.weightNumeric.TabIndex = 27;
            this.weightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Sedan
            // 
            this.Sedan.AutoSize = true;
            this.Sedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Sedan.Location = new System.Drawing.Point(676, 251);
            this.Sedan.Name = "Sedan";
            this.Sedan.Size = new System.Drawing.Size(80, 26);
            this.Sedan.TabIndex = 45;
            this.Sedan.TabStop = true;
            this.Sedan.Text = "Sedan";
            this.Sedan.UseVisualStyleBackColor = true;
            // 
            // Wagon
            // 
            this.Wagon.AutoSize = true;
            this.Wagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Wagon.Location = new System.Drawing.Point(549, 251);
            this.Wagon.Name = "Wagon";
            this.Wagon.Size = new System.Drawing.Size(85, 26);
            this.Wagon.TabIndex = 44;
            this.Wagon.TabStop = true;
            this.Wagon.Text = "Wagon";
            this.Wagon.UseVisualStyleBackColor = true;
            // 
            // Body_shape
            // 
            this.Body_shape.BackColor = System.Drawing.SystemColors.Control;
            this.Body_shape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Body_shape.Enabled = false;
            this.Body_shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Body_shape.Location = new System.Drawing.Point(439, 254);
            this.Body_shape.Name = "Body_shape";
            this.Body_shape.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Body_shape.Size = new System.Drawing.Size(104, 20);
            this.Body_shape.TabIndex = 46;
            this.Body_shape.Text = "Body shape:";
            // 
            // Page_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Body_shape);
            this.Controls.Add(this.Sedan);
            this.Controls.Add(this.Wagon);
            this.Controls.Add(this.weightNumeric);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.makeComboBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.ContinueBTN);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Header);
            this.Name = "Page_1";
            this.Text = "Input Page 1";
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Make;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button ContinueBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        public System.Windows.Forms.NumericUpDown weightNumeric;
        private System.Windows.Forms.RadioButton Sedan;
        private System.Windows.Forms.RadioButton Wagon;
        private System.Windows.Forms.TextBox Body_shape;
    }
}