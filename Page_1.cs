using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Registration_calculator
{
    public partial class Page_1 : Form
    {
        static private Dictionary<string, List<string>> makeToModel { get; set; }

        public Page_1()
        {
            InitializeComponent();

            // load the json while displaying the window rather than waiting for it
            JSON.Load();
            string jsonString = JSON.Data;
            makeToModel = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonString);


            foreach (var row in makeToModel)
            {
                // add each make to combo box
                makeComboBox.Items.Add(row.Key);

                foreach (string model in row.Value)
                {
                    // add each model to combo box
                    modelComboBox.Items.Add(model);
                }
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms["LandingPage"].Show();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void makeComboBox_TextChanged(object sender, EventArgs e)
        {
            // If the make has been chosen, and it exists in the car database then clear the 
            // list of models and replace it with the models that are developed by the make
            if (makeToModel.ContainsKey(makeComboBox.Text))
            {
                modelComboBox.Items.Clear();
                foreach (string model in makeToModel[makeComboBox.Text])
                {
                    modelComboBox.Items.Add(model);
                }
            }
        }

        private void ContinueBTN_Click(object sender, EventArgs e)
        {
            if (makeComboBox.Text == "")
            {
                MessageBox.Show("Please enter the car's make.");
                return;
            } else if (modelComboBox.Text == "")
            {
                MessageBox.Show("Please enter the car's model.");
                return;
            } else if (!(Sedan.Checked || Wagon.Checked))
            {
                MessageBox.Show("Please pick a body type.");
                return;
            }


            this.Hide();

            if (Program.Forms.ContainsKey("Page_2"))
            {
                Program.Forms["Page_2"].Show();
            }
            else
            {
                Form Page_2 = new Page_2();
                Program.Forms["Page_2"] = Page_2;
                Page_2.Show();
            }
        }

        private void Title_Enter(object sender, EventArgs e)
        {
            // Remove cursor from title
            Title.Enabled = false;
            Title.Enabled = true;
        }
    }
}


        

 