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
    public partial class Page_3 : Form
    {
        private bool IsAntiGov;
        public decimal TotalAmountPayable;

        public Page_3()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms["Page_2"].Show();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Title_Enter(object sender, EventArgs e)
        {
            // Remove cursor from title
            Title.Enabled = false;
            Title.Enabled = true;
        }

        public void Recompute()
        {
            // get inputs from the relevant forms
            // cast the Form datatype to relevant Page_x to access their specific properties not in parent Form class
            decimal weight = ((Page_1) Program.Forms["Page_1"]).weightNumeric.Value;
            decimal cost = ((Page_2) Program.Forms["Page_2"]).price.Value;
            bool isPrivate = ((Page_2) Program.Forms["Page_2"]).Private.Checked;

            // initialise values for outputs to do calculations more easily than directly editing the UI elements
            // also initialise here instead of in the block because of block scope
            decimal registrationFee = 60.0m;
            decimal stampDuty;
            decimal insurancePremium;
            decimal vehicleTax;
            if (isPrivate)
            {
                stampDuty = 0.01m * cost;
                insurancePremium = 0.02m * cost;

                if (weight <= 975)
                {
                    vehicleTax = 191m;
                }
                else if (weight <= 1154)
                {
                    vehicleTax = 220m;
                }
                else if (weight <= 1504)
                {
                    vehicleTax = 270m;
                }
                else
                {
                    vehicleTax = 441m;
                }

            }
            else
            {
                stampDuty = 0.03m * cost;
                insurancePremium = 0.05m * cost;

                if (weight <= 975)
                {
                    vehicleTax = 308m;
                }
                else if (weight <= 1154)
                {
                    vehicleTax = 351m;
                }
                else
                {
                    vehicleTax = 425m;
                }
            }

            // the sum of the values as per the assignment description
            decimal totalRegistrationCost = registrationFee + stampDuty + insurancePremium;
            this.TotalAmountPayable = vehicleTax + totalRegistrationCost;

            // Display variables to the output
            TxtRegistrationFee.Text = registrationFee.ToString("C2");
            TxtStampDuty.Text = stampDuty.ToString("C2");
            TxtInsurancePremium.Text = insurancePremium.ToString("C2");
            TxtTotalRegistrationCost.Text = totalRegistrationCost.ToString("C2");
            TxtVehicleTax.Text = vehicleTax.ToString("C2");
            TxtTotalPayable.Text = TotalAmountPayable.ToString("C2");

            // Easter Egg - decide whether continue button should be shown
            string name = ((Page_2) Program.Forms["Page_2"]).OwnerName.Text.ToLower();
            if (name.Contains("capital") || name.Contains("revolution") || name.Contains("poor") || name.Contains("private") || name.Contains("freedom") || name.Contains("anarch")) {
                IsAntiGov = true;
                ContinueBTN.Text = "Continue";
            } else 
            {
                IsAntiGov = false;
                ContinueBTN.Text = "Reset";
            }
        }

        private void ContinueBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (IsAntiGov)
            {
                if (Program.Forms.ContainsKey("Easter_Egg"))
                {
                    Program.Forms["Easter_Egg"].Show();
                }
                else {
                    Form Easter_Egg = new Easter_Egg();
                    Program.Forms["Easter_Egg"] = Easter_Egg;
                    Easter_Egg.Show();
                }
            } 
            else {
                this.Hide();
                Form LandingPage = new LandingPage();
                Program.Forms = new Dictionary<string, Form>();
                Program.Forms["LandingPage"] = LandingPage;
                LandingPage.Show();
            }
        }
    }
}
