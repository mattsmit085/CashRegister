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
        string extras;
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
        double tendered;
        double change;
        double subtotal;
        double taxCharge;
        double sizePrice;
        bool sizeCheck = false;

      
        public Form1()
        {
           

            InitializeComponent();
           
            receipttitleLabel.Visible = false;
            receiptLabel.Visible = false;
            pricingLabel.Visible = false;
            //pepperoniButton.Enabled = false;
            //extrachzButton.Enabled = false;
            //greenpepperButton.Enabled = false;
            //pineappleButton.Enabled = false;
            //mushroomButton.Enabled = false;
            //onionButton.Enabled = false;

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //if (sizeCheck = true)
            //{
            //    pepperoniButton.Enabled = true;
            //    extrachzButton.Enabled = true;
            //    greenpepperButton.Enabled = true;
            //    pineappleButton.Enabled = true;
            //    mushroomButton.Enabled = true;
            //    onionButton.Enabled = true;
            //}
            //else if (sizeCheck = false)
            //{
            //    pepperoniButton.Enabled = false;
            //    extrachzButton.Enabled = false;
            //    greenpepperButton.Enabled = false;
            //    pineappleButton.Enabled = false;
            //    mushroomButton.Enabled = false;
            //    onionButton.Enabled = false;
            //}
        }
        private void lrgButton_Click(object sender, EventArgs e)
        {
            size = "LARGE";
            sizeCheck = true;
            sizePrice = 18.25;
           pizzaSizeLabel.Text = "Large Pizza:";
            Convert.ToString(largePrice);
            subtotal += largePrice;
          //  lrgButton.Enabled = false;
           // smallButton.Enabled = false;

        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            size = "SMALL";
            sizeCheck = true;
            sizePrice = 10.25;
            Convert.ToString(smallPrice);
            pizzaSizeLabel.Text = "Small Pizza:";
            subtotal = smallPrice;
            //  smallButton.Enabled = false;
            // lrgButton.Enabled = false;


        }

        private void medButton_Click(object sender, EventArgs e)
        {
            pizzaSizeLabel.Text = "Medium Pizza:";
            sizeCheck = true;
            size = "MEDIUM";
            sizePrice = 14.25;
            Convert.ToString(mediumPrice);
            subtotal = mediumPrice;
         //   medButton.Enabled = false;
           // smallButton.Enabled = false;
        }
        
        private void pepperoniButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nPepperoni";
            pepperoni++;
            Convert.ToString(toppingPrice);
            subtotal += toppingPrice;

        }

        private void extrachzButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nExtra Cheese";
            extracheese++;
            subtotal += toppingPrice;

        }

        private void greenpepperButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nGreen Peppers";
            greenpeppers++;
            subtotal += toppingPrice;
        }

        private void pineappleButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nPineapple";
            pineapple++;
            subtotal += toppingPrice;
          //  receiptpriceLabel.Text += $"\n{toppingPrice}";
        }

        private void mushroomButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nMushroom";
            mushroom++;
            subtotal += toppingPrice;
           // receiptpriceLabel.Text += $"\n{toppingPrice}";
        }

        private void onionLabel_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nOnions";
            onions++;
            subtotal += toppingPrice;
           // receiptpriceLabel.Text += $"\n{toppingPrice}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            receiptLabel.Text = "";
            pricingLabel.Text = "";

            if (tenderedInput.Text == "")


            {
                tenderErrorLabel.Text = "Please Insert the Tendered Amount"; 
                smallButton.Enabled = true;
                medButton.Enabled = true;
                lrgButton.Enabled = true;
                pepperoniButton.Enabled = true;
                extrachzButton.Enabled = true;
                greenpepperButton.Enabled = true;
                pineappleButton.Enabled = true;
                mushroomButton.Enabled = true;
                onionButton.Enabled = true;
                receipttitleLabel.Visible = false;
                receiptLabel.Enabled = false;
                orderLabel.Text = "";
                subtotal = 0;
                pricingLabel.Text = "";
                pizzaSizeLabel.Text = "";
                
                pepperoni = 0;
                extracheese = 0;
                greenpeppers = 0;
                pineapple = 0;
                mushroom = 0;
                onions = 0;
            }

            else
            {
                tenderErrorLabel.Text = "";
                receiptLabel.Visible = true;
                pricingLabel.Visible = true;
                smallButton.Enabled = false;
                medButton.Enabled = false;
                lrgButton.Enabled = false;
                pepperoniButton.Enabled = false;
                extrachzButton.Enabled = false;
                greenpepperButton.Enabled = false;
                pineappleButton.Enabled = false;
                mushroomButton.Enabled = false;
                onionButton.Enabled = false;
                receipttitleLabel.Visible = true;
                receipttitleLabel.Text += $"\nRECEIPT\n";
                Thread.Sleep(100);
                Refresh();
                receipttitleLabel.Text += $"PINOS PIZZA";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\n1 {size} PIZZA\n";
                pricingLabel.Text += $"\n{sizePrice}\n";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nPeperoni x{pepperoni}";
                pricingLabel.Text += $"\n{pepperoni * toppingPrice}";
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
                //subtotal = (pepperoni + pineapple + extracheese + greenpeppers + mushroom + onions * toppingPrice) + saladPrice + garlicBreadPrice + chickenPrice;
                Convert.ToString(change);
                total = subtotal * tax;
                taxCharge = subtotal * tax - subtotal;
                tendered = Convert.ToDouble(tenderedInput.Text);
                change = tendered - total;
                receiptLabel.Text += $"\n\n\n\n\n\n\nSubtotal";
                pricingLabel.Text += $"\n\n\n\n\n\n\n{subtotal.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nTax";
                pricingLabel.Text += $"\n{taxCharge.ToString("C")}";
                Thread.Sleep(100);
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nTotal";
                pricingLabel.Text += $"\n{total.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\n\nTendered";
                pricingLabel.Text += $"\n\n{tendered.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nChange";
                pricingLabel.Text += $"\n{change.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nHave A Nice Day!";
                Refresh();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void orderLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void neworderButton_Click(object sender, EventArgs e)
        {

            smallButton.Enabled = true;
            medButton.Enabled = true;
            lrgButton.Enabled = true;
            pepperoniButton.Enabled = true;
            extrachzButton.Enabled = true;
            greenpepperButton.Enabled = true;
            pineappleButton.Enabled = true;
            mushroomButton.Enabled = true;
            onionButton.Enabled = true;
            receipttitleLabel.Visible = false;
            receiptLabel.Enabled = false;
            receiptLabel.Text = "";
            orderLabel.Text = "";
            subtotal = 0;
            pricingLabel.Text = "";
            pizzaSizeLabel.Text = "";
            pepperoni = 0;
            extracheese = 0;
            greenpeppers = 0;
            pineapple = 0;
            mushroom = 0;
            onions = 0;

        }
    }
                    ;
}
