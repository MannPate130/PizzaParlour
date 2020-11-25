using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pizzaTitle : Form
    {
        double pizza = 7.00;
        double toppings = 1.25;
        int number;
        double total;
        


        public pizzaTitle()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try 
            {
                number = Convert.ToInt32(numberOftoppingsTextbox.Text);
                total = toppings * number + pizza;

                costOutputlabel.Text = $" The price of a pizza with {number} toppings is: {total.ToString("c")} ";
            }
            catch
            {
                costOutputlabel.Text = "You must enter a valid amount";
            }
        }


        private void numberOftoppingsTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
