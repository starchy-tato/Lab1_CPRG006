using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
CPRG006 RAD Concepts Assignment 1
Author: Tiffanie Wong 
Date: Aug 29 2021

Purpose: Creating a lunch order form that handles add ons for main 
courses and is able to calculate order totals properly
 */

namespace TWong_Lab1_CPRG006
{
    public partial class frmLunchOrder : Form
    {
        //constant for the 5% tax
        const double taxRate = 0.05;

        /* 
        constants for main course options and assigning them to the radio buttons;
        strings assigned to hamburger, pizza and salad with appropriate prices
        */
        const string mcHamburger = "Hambuger - $6.95";
        const string mcPizza = "Pizza - $5.95";
        const string mcSalad = "Salad - $4.95";

        /* 
        when the hamburger option is selected, these defined constants will appear 
        as add on items for further selection
        */
        const string grpBoxHamburger = "Add-On Items ($0.75/ each)";
        const string addOnHam1 = "Lettuce, Tomatoes, and Onions";
        const string addOnHam2 = "Ketchup, Mustard, and Mayo";
        const string addOnHam3 = "French Fries";

        //est. constants for group box and add on items for pizza main course
        const string grpBoxPizza = "Add-On Items ($0.50/ each)";
        const string addOnPizza1 = "Peperoni";
        const string addOnPizza2 = "Sausage";
        const string addOnPizza3 = "Olives";

        //est. constants for group box and add on items for salad main course
        const string grpBoxSalad = "Add-On Items ($0.25/ each)";
        const string addOnSalad1 = "Croutons";
        const string addOnSalad2 = "Bacon Bits";
        const string addOnSalad3 = "Bread Sticks";

        //assigned constant prices for main courses for calculations
        const double totalHamburger = 6.95;
        const double totalPizza = 5.95;
        const double totalSalad = 4.95;

        //assigned prices for add on items for each main course in constants for calculations
        const double addOnHam = 0.75;
        const double addOnPizza = 0.5;
        const double addOnSalad = 0.25;

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void ResetFields()
        {
            /* 
            method to reset all check boxes and text boxes
            */
            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            txtBoxSubtotal.Text = String.Empty;
            txtBoxTax.Text = String.Empty;
            txtBoxOrderTotal.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //event handler for exit button to close application
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //event handler for reset button to clear order total fields and set hamburger as selected
            txtBoxSubtotal.Text = String.Empty;
            txtBoxTax.Text = String.Empty;
            txtBoxOrderTotal.Text = String.Empty;
            radioBtnHam.Checked = true;
        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            radioBtnHam.Text = mcHamburger;
            radioBtnPizza.Text = mcPizza;
            radioBtnSalad.Text = mcSalad;
            radioBtnHam.Checked = true;
        }

        private void radioBtnHam_CheckedChanged(object sender, EventArgs e)
        {
            //reset button to call method
            ResetFields();

            /*
            the group box, and each add on specific for the hamburger main course
            has been assigned a constant
             */
            grpBoxAddOn.Text = grpBoxHamburger;
            chkBox1.Text = addOnHam1;
            chkBox2.Text = addOnHam2;
            chkBox3.Text = addOnHam3;
        }

        private void radioBtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            //reset button to call method
            ResetFields();

            /*
            the group box, and each add on specific for the pizza main course
            has been assigned a constant
             */
            grpBoxAddOn.Text = grpBoxPizza;
            chkBox1.Text = addOnPizza1;
            chkBox2.Text = addOnPizza2;
            chkBox3.Text = addOnPizza3;
        }

        private void radioBtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            //reset button to call method
            ResetFields();

            /*
            the group box, and each add on specific for the salad main course
            has been assigned a constant
             */
            grpBoxAddOn.Text = grpBoxSalad;
            chkBox1.Text = addOnSalad1;
            chkBox2.Text = addOnSalad2;
            chkBox3.Text = addOnSalad3;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            totalOrderCalc();
        }

        void taxOrderTotalCalc(double subTotal, out double taxAmt, out double orderTotal)
        {
            //method recieves sub total, returns tax amount and total amount
            taxAmt = Math.Round((subTotal * taxRate), 2);
            orderTotal = Math.Round((subTotal + taxAmt), 2);
        }

        void totalOrderCalc()
        {
            //method to calculate total order amount with sub total and any checked add on items
            //add on count
            int totalAddOns = 0;

            // incrementally add any checked add on items
            if (chkBox1.Checked)
                totalAddOns++;
            if (chkBox2.Checked)
                totalAddOns++;
            if (chkBox3.Checked)
                totalAddOns++;

            //sub total calculation multiplies any collected add ons by the appropriate main course add on price
            double subTotal = radioBtnHam.Checked ? totalHamburger + (totalAddOns * addOnHam)
            : radioBtnPizza.Checked ? subTotal = totalPizza + (totalAddOns * addOnPizza)
            : radioBtnSalad.Checked ? subTotal = totalSalad + (totalAddOns * addOnSalad)
            : 0;

            /*
           an external method to calculate tax amount and order total and returns them;
           total order is calculated in this method 
           */
            taxOrderTotalCalc(subTotal, out double subTotalTax, out double orderTotal);

            // Display order sub-total, order tax, and order total in the text fields with currency foramt
            txtBoxSubtotal.Text = subTotal.ToString("c");
            txtBoxTax.Text = subTotalTax.ToString("c");
            txtBoxOrderTotal.Text = orderTotal.ToString("c");

        }

        //event handlers for place order button styling when cursor hovers and leaves button
        private void btnPlaceOrder_MouseHover(object sender, EventArgs e)
        {
            btnPlaceOrder.BackColor = Color.LightGreen;
        }

        private void btnPlaceOrder_MouseLeave(object sender, EventArgs e)
        {
            btnPlaceOrder.BackColor = Color.Transparent;
        }

        //event handlers for reset button styling when cursor hovers and leaves button
        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Pink;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Transparent;
        }
    }
}
