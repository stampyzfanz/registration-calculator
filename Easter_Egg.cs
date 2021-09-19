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
    public partial class Easter_Egg : Form
    {
        public Easter_Egg()
        {
            InitializeComponent();
        }

        private void Easter_Egg_Load(object sender, EventArgs e)
        {
            // Easter egg
            // Australia spends about 44 billion dollars a year on its military
            int peopleToOverthrow = Convert.ToInt32(Math.Ceiling(44620000m / ((Page_3) Program.Forms["Page_3"]).TotalAmountPayable));
            PeopleToOverthrowGovernmentTxt.Text = peopleToOverthrow.ToString() + " people";

            // This formula took approximately 2 hours and mathematics used in rocket science to find
            int peopleToInfiltrate = Convert.ToInt32(Math.Ceiling(33750000m / (((Page_3) Program.Forms["Page_3"]).TotalAmountPayable + 1.35m)));
            PeopleToInfiltrateGovernmentTxt.Text = peopleToInfiltrate.ToString() + " people";
        } 

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms["Page_3"].Show();
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LandingPage = new LandingPage();
            Program.Forms = new Dictionary<string, Form>();
            Program.Forms["LandingPage"] = LandingPage;
            LandingPage.Show();
        }


        private void Title_Enter(object sender, EventArgs e)
        {
            // Remove cursor from title
            Title.Enabled = false;
            Title.Enabled = true;
        }
    }
}
