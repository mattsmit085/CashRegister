using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        string size;
        string toppings;
        string extras;
        double subtotal;
        double total;
        double tax = 1.13;
        int pepperoni = 0;
        int extracheese = 0;
        int greenpeppers = 0;
        int pineapple = 0;
        int mushroom = 0;
        int onions = 0;
        double smallPrice = 10.25;
        double mediumPrice = 14.25;
        double largePrice = 18.25;
        double toppingPrice = 1.25;
        double garlicBreadPrice = 8.99;
        double saladPrice = 6.99;
        double chickenPrice = 10.99;
        double garlicBread = 0;
        double salad = 0;
        double chicken = 0;
        double tendered;
        double change;


        public Form1()
        {
            InitializeComponent();
            receipttitleLabel.Visible = false;
            receiptLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lrgButton_Click(object sender, EventArgs e)
        {
            size = "LARGE";
            orderLabel.Text += "\nLarge";
            Convert.ToString(largePrice);
            subtotal += 18.25;
            medButton.Enabled = false;
            smallButton.Enabled = false;

        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            size = "SMALL";
            Convert.ToString(smallPrice);
            subtotal += 10.25;
            medButton.Enabled = false;
            lrgButton.Enabled = false;
        }

        private void medButton_Click(object sender, EventArgs e)
        {
            size = "MEDIUM";
            Convert.ToString(mediumPrice);
            subtotal += 14.25;
            lrgButton.Enabled = false;
            smallButton.Enabled = false;
        }

        private void pepperoniButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nPepperoni";
            pepperoni++;
            subtotal+=1.25;
            Convert.ToString(toppingPrice);

        }

        private void extrachzButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nExtra Cheese";
            extracheese++;
            subtotal += 1.25;

        }

        private void greenpepperButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nGreen Peppers";
            greenpeppers++;
            subtotal += 1.25;
        }

        private void pineappleButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nPineapple";
            pineapple++;
            subtotal += 1.25;
          //  receiptpriceLabel.Text += $"\n{toppingPrice}";
        }

        private void mushroomButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nMushroom";
            mushroom++;
            subtotal += 1.25;
           // receiptpriceLabel.Text += $"\n{toppingPrice}";
        }

        private void onionLabel_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nOnions";
            onions++;
            subtotal += 1.25;
           // receiptpriceLabel.Text += $"\n{toppingPrice}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            receiptLabel.Visible = true;
            receipttitleLabel.Visible = true;
            receipttitleLabel.Text += $"\nRECEIPT\n";
            Thread.Sleep(100);
            Refresh();
            receipttitleLabel.Text += $"PINOS PIZZA";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\n1 {size} PIZZA\n";
            pricingLabel.Text += $"\n{mediumPrice}\n";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nPeperoni x{pepperoni}";
            pricingLabel.Text += $"\n{pepperoni*toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nExtra Cheese x{extracheese}";
            pricingLabel.Text += $"\n{extracheese * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nGreen Peppers x{greenpeppers}";
            pricingLabel.Text += $"\n{greenpeppers * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nPineapple x{pineapple}";
            pricingLabel.Text += $"\n{pineapple * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nMushrooms x{mushroom}";
            pricingLabel.Text += $"\n{mushroom * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nOnions x{onions}";
            pricingLabel.Text += $"\n{onions * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nCaesar Salad x{salad}";
            pricingLabel.Text += $"\n{salad * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nGarlic Bread x{garlicBread}";
            pricingLabel.Text += $"\n{garlicBread * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nChicken Wings x{chicken}";
            pricingLabel.Text += $"\n{chicken * toppingPrice}";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\n\n\n\n\n\n\nSubtotal\nTax\nTotal\n\nTendered\nChange";
            pricingLabel.Text += $"\n\n\n\n\n\n\n{subtotal}\n{tax*subtotal-subtotal}\n{tax*subtotal}\n\n{tendered}\n{tendered-total}";
        }

        private void saladButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nCaesar Salad";
            salad++;
            subtotal += 6.99;
          // receiptpriceLabel.Text += $"\n{saladPrice}";
        }

        private void garlicbreadButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nGarlic Bread";
            garlicBread++;
            subtotal += 8.99;
            //receiptpriceLabel.Text += $"\n{garlicBreadPrice}";
        }

        private void wingsButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nChicken Wings";
            chicken++;
            subtotal += 10.99;
            //receiptpriceLabel.Text += $"\n{garlicBreadPrice}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           Convert.ToString(tenderedInput);
         //   tendered = tenderedInput.Text;
      
        }
    }
}
