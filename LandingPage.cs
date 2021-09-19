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
	public partial class LandingPage : Form
	{
		public LandingPage()
		{
			InitializeComponent();
		}

        private void ContinueBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Program.Forms.ContainsKey("Page_1"))
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

        private void LandingPage_Load(object sender, EventArgs e)
        {
            // Once this has loaded load the next page so when the user presses next the next page loads quicker
            Form Page_1 = new Page_1();
            Program.Forms["Page_1"] = Page_1;
        }
    }
}
