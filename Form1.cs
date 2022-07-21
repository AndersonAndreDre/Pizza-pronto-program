using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {


        const double MARGCost = 60;
        const double SPBFCost = 100;
        const double CHPDCost = 95;
        const double FSNSCost = 85;
        const double VGTNCost = 60;
        const double VATRate = 0.15;






        public Form1()
        {

            InitializeComponent();
        }


        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPizzaCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            double dblQty = Convert.ToDouble(txtQty.Text);
            double discount = 0;
            double dblVATAmount;
            double dblDiscountAmt;
            double dbltotalAmtOwwing = 0;
            double dblTotalDiscount = 0;
            double dblTotalVat = 0;
            double dblAmtOwing = 0;
            while (txtPizzaCode.Text != "XXXX")
            {
                if (txtPizzaCode.Text == "XXXX")
                {
                    break;
                }
                txtPizzaCode.Text = (InputBox("Please enter Pizza Code", "PizzaCode INPUT", ""));
                dblQty = Convert.ToDouble((InputBox("Enter Quantity", "QTY INPUT", "")));

                if (radButCard.Checked)
                {
                    discount = 0;
                }
                else
                if (radButCash.Checked)
                {
                    discount = 0.05;

                }

                if (txtPizzaCode.Text == "MARG")
                {
                    dblAmtOwing = dblQty * MARGCost;
                }

                if (txtPizzaCode.Text == "SPBF")
                {
                    dblAmtOwing = dblQty * SPBFCost;
                }

                if (txtPizzaCode.Text == "CHPD")
                {
                    dblAmtOwing = dblQty * CHPDCost;
                }

                if (txtPizzaCode.Text == "FSNS")
                {
                    dblAmtOwing = dblQty * FSNSCost;
                }

                if (txtPizzaCode.Text == "VGTN")
                {

                    dblAmtOwing = dblQty * VGTNCost;

                }
                ///MATH

                dblDiscountAmt = dblAmtOwing * discount;
                dblAmtOwing -= dblDiscountAmt;
                dblVATAmount = VATRate * dblAmtOwing;
                dblAmtOwing += (dblVATAmount);


                 dblTotalVat += dblVATAmount;
                 dblTotalDiscount+= dblDiscountAmt;
                dbltotalAmtOwwing += dblAmtOwing;
                bool blnValidInput = true;
                blnValidInput = ValidateInput(blnValidInput);
                if (blnValidInput == true)
                {
                    DisplayOutput(dblVATAmount, dblDiscountAmt, dblAmtOwing, dbltotalAmtOwwing,dblTotalVat, dblTotalDiscount);
                }

            }


        }
        private void DisplayOutput(double AccumVATAmt, double AccumDiscount, double AccumAmtOwn,double dbltotalAmtOwwing, double dblTotalVat,double dblTotalDiscount)
        {






            lblMessage.Text = "R" + AccumAmtOwn.ToString("F2");
            lblDiscount.Text = "R" + AccumDiscount.ToString("F2");
            lblVat.Text = "R" + AccumVATAmt.ToString("F2");


            lblAccumAmt.Text = "R" + dbltotalAmtOwwing.ToString("F2");

            // DisplayOutput(dblVATAmount, dblDiscountAmt, dblAmtOwing);
            lblAccumDiscount.Text = "R" + dblTotalDiscount.ToString("F2");
            lblAccumVat.Text = "R" + dblTotalVat.ToString("F2");
        }
        private bool ValidateInput(bool blnValidInput)
        {

            double dblQty = Convert.ToDouble(txtQty.Text);
            if (dblQty < 1)
            {

                MessageBox.Show("Invalid Quantity", "ERROR");
                blnValidInput = false;
            }

            if (txtPizzaCode.Text != "MARG")
            {
                if (txtPizzaCode.Text != "CHPD")
                {
                    if (txtPizzaCode.Text != "VGTN")
                    {
                        if (txtPizzaCode.Text != "FSNS")
                        {

                            //if (txtPizzaCode.Text != "MARG" || txtPizzaCode.Text != "VGTN" || txtPizzaCode.Text != "CHPD" || txtPizzaCode.Text != "FSNS")
                            if (txtPizzaCode.Text != "SPBF")
                            {
                                if (txtPizzaCode.Text != "XXXX")
                                {
                                    MessageBox.Show("Invalid Pizza Code", "ERROR");
                                    blnValidInput = false;

                                }

                            }



                        }
                    }
                }
            }


            if (txtPhoneNo.Text == "")
            {

                MessageBox.Show("Please Enter Phone Number", "ERROR");
                blnValidInput = false;
            }
            if (!radButCard.Checked && !radButCash.Checked)
            {
                MessageBox.Show("Select payment method", "ERROR");
                blnValidInput = false;
            }

            return blnValidInput;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhoneNo.Text = "";
            txtPizzaCode.Text = "";
            txtQty.Text = "";
            lblMessage.Text = "0.00";
            txtPhoneNo.Focus();
            lblDiscount.Text = "0.00";
            lblVat.Text = "0.00";
            radButCash.Checked = false;
            radButCard.Checked = false;
        }

        private void grpBoxSamTot_Enter(object sender, EventArgs e)
        {




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void radButCash_CheckedChanged(object sender, EventArgs e)
        {
            //radButCash.Element.ToolTipText = "MyButton";;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
