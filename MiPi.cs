using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmMiPi : Form
    {
        public frmMiPi()
        {
            InitializeComponent();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void frmMiPi_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();


        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button =
                MessageBox.Show(
                    "Do you want to Exit?",
                    "Exit Form", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            
            if (button == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            const double TAXRATE = 0.07;                                        //Calculate Price
            double subtotal = Double.Parse(txtSubtotal.Text);
            double tax = subtotal * TAXRATE;
            double grandtotal = subtotal + tax;
            txtTax.Text = tax.ToString();
            txtTotal.Text = grandtotal.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPayment_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpCustomerInfo_Enter(object sender, EventArgs e)
        {
            lblPhoneNbrError.Visible = false;
            lblNameError.Visible = false;
            lblAddressError.Visible = false;
            lblCityError.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void tmrDT_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString()   +  "  "  + DateTime.Now.ToLongTimeString();
        }

        private void mtbPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void mtbZipCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblPhoneNbrError_Click(object sender, EventArgs e)
        {

        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Length < 10)
            {
                lblPhoneNbrError.Visible = true;  //turn on error label
                mtbPhone.SelectAll();             //highlight text
                mtbPhone.Focus();                 //place focus back in box
            }

            else
            {
                lblPhoneNbrError.Visible = false;


            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 5)
            {
                lblNameError.Visible = true;      //turn on error label
                txtName.SelectAll();             //highlight text
                txtName.Focus();                 //place focus back in box
            }

            else
            {
                lblNameError.Visible = false;
            }

        }

        private void lblNameError_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress1_Leave(object sender, EventArgs e)
        {
            if (txtAddress1.Text.Length < 5)
            {
                lblAddressError.Visible = true;      //turn on error label
                txtAddress1.SelectAll();             //highlight text
                txtAddress1.Focus();                 //place focus back in box
            }

            else
            {
                lblAddressError.Visible = false;
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Length < 2)
            {
                lblCityError.Visible = true;      //turn on error label
                txtCity.SelectAll();             //highlight text
                txtCity.Focus();                 //place focus back in box
            }

            else
            {
                lblCityError.Visible = false;
            }
        }
        private void lblZipCode_Click(object sender, EventArgs e)
        {

        }
        private void mtbZipCode_Validating(object sender, CancelEventArgs e)
        {
            if (mtbZipCode.Text.Length == 5 | mtbZipCode.Text.Length == 9)
            {
                mtbZipCode.ForeColor = Color.Black;
            }
            else
            {
                mtbZipCode.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpCustomerInfo.Controls)
            {

                if (c is TextBox)                                  // Clear All Text Boxes
                {
                    ((TextBox)c).Clear();
                }
                else if (c is MaskedTextBox)                         //Clear All MaskedTextBoxes
                {
                    ((MaskedTextBox)c).Text = "";
                }
                else if (c is ComboBox)                               //Clear ComboBox
                {
                    ((ComboBox)c).Text = "";
                }

            }

            foreach (Control a in grpOrderInfo.Controls)          //Clear Numeric UpDown
            {
                if (a is NumericUpDown)
                {
                    ((NumericUpDown)a).Value = 1;
                }
            }

            foreach (Control x in grpSize.Controls)
            {

                if (x is RadioButton)                              //Clear all Radio Buttons
                {
                    ((RadioButton)x).Checked = false;
                }
            }

            foreach (Control i in grpToppings.Controls)            //Clear all Checkboxes
            {
                if (i is CheckBox)
                {
                    ((CheckBox)i).Checked = false;
                }
            }

            foreach (Control c in grpPayment.Controls)              //Clear combobox
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }

            foreach (Control c in grpPricing.Controls)              //Clear combobox
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }

                mtbPhone.Focus();


            




        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        public void CalculatePrice()
        {
            throw new System.NotImplementedException();
            double PriceSize = 0.00;
            double PriceEachTopping, PriceToppings, TotalOrder;
            int Pepperoni, Sausage, Cheese, Ham, Hamburger, Mushrooms, BlackOlives, GreenOlives, Pineapple, Onions;

            if (radSmall.Checked == true)
                PriceSize = double.Parse(radSmall.Text);
            if (radMedium.Checked == true)
                PriceSize = double.Parse(radMedium.Text);
            if (radLarge.Checked == true)
                PriceSize = double.Parse(radLarge.Text);
            if (chkPepperoni.Checked == true)
                Pepperoni = 1;
            else 
                Pepperoni = 0;
            if (chkSausage.Checked == true)
                Sausage = 1;
            else 
                Sausage = 0;

            if (chkCheese.Checked == true)
                Cheese = 1;
            else 
                Cheese = 0;

            if (chkHam.Checked == true)
                Ham = 1;
            else 
                Ham = 0;

            if (chkHamburger.Checked == true)
                Hamburger = 1;
            else 
                Hamburger = 0;

            if (chkMushrooms.Checked == true)
                Mushrooms = 1;
            else 
                Mushrooms = 0;

            if (chkBlackOlives.Checked == true)
                BlackOlives = 1;
            else 
                BlackOlives = 0;

            if (chkGreenOlives.Checked == true)
                GreenOlives = 1;
            else 
                GreenOlives = 0;

            if (chkPineapple.Checked == true)
                Pineapple = 1;
            else 
                Pineapple = 0;

            if (chkOnions.Checked == true)
                Onions = 1;
            else 
                Onions = 0;

            

        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkBlackOlives_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice
        }
    }
}
