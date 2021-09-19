using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_calculator
{
    public partial class Page_2 : Form
    {
        public Page_2()
        {
            InitializeComponent();
        }

        private void ContinueBTN_Click(object sender, EventArgs e)
        {
            // if the user has filled everything out, if not then show error message
            if (!(Business.Checked || Private.Checked))
            {
                MessageBox.Show("Please pick either business or private.");
                return;
            } else if (OwnerName.Text == "")
            {
                MessageBox.Show("Please enter your name");
                return;
            } 

            // hide the form and if the next one already exists show it, if not create and show it
            this.Hide();
            if (Program.Forms.ContainsKey("Page_3"))
            {
                ((Page_3) Program.Forms["Page_3"]).Recompute();
                Program.Forms["Page_3"].Show();
            }
            else
            {
                Form Page_3 = new Page_3();
                Program.Forms["Page_3"] = Page_3;
                ((Page_3) Page_3).Recompute();
                Page_3.Show();
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms["Page_1"].Show();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Title_Enter(object sender, EventArgs e)
        {
            // Remove cursor from title
            Title.Enabled = false;
            Title.Enabled = true;
        }
    }
}
