﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

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
            pepperoniButton.Enabled = false;
            extrachzButton.Enabled = false;
            greenpepperButton.Enabled = false;
            pineappleButton.Enabled = false;
            mushroomButton.Enabled = false;
            onionButton.Enabled = false;
            printreceiptButton.Enabled = true;
        }

        // If the size buttons are clicked, It adds the size price to the receipt, and writes the size name
        private void lrgButton_Click(object sender, EventArgs e)
        {
            smallButton.Enabled = false;
            medButton.Enabled = false;
            lrgButton.Enabled = false;

            size = "LARGE";
            sizeCheck = true;
            sizePrice = 18.25;
            pizzaSizeLabel.Text = "Large Pizza:";
            Convert.ToString(largePrice);
            subtotal += largePrice;
            pepperoniButton.Enabled = true;
            extrachzButton.Enabled = true;
            greenpepperButton.Enabled = true;
            pineappleButton.Enabled = true;
            mushroomButton.Enabled = true;
            onionButton.Enabled = true;
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            smallButton.Enabled = false;
            medButton.Enabled = false;
            lrgButton.Enabled = false;

            size = "SMALL";
            sizeCheck = true;
            sizePrice = 10.25;
            pizzaSizeLabel.Text = "Small Pizza:";

            Convert.ToString(smallPrice);
            subtotal = smallPrice;
            pepperoniButton.Enabled = true;
            extrachzButton.Enabled = true;
            greenpepperButton.Enabled = true;
            pineappleButton.Enabled = true;
            mushroomButton.Enabled = true;
            onionButton.Enabled = true;
        }

        private void medButton_Click(object sender, EventArgs e)
        {
            smallButton.Enabled = false;
            medButton.Enabled = false;
            lrgButton.Enabled = false;

            pizzaSizeLabel.Text = "Medium Pizza:";
            sizeCheck = true;
            size = "MEDIUM";
            sizePrice = 14.25;

            Convert.ToString(mediumPrice);
            subtotal = mediumPrice;
            pepperoniButton.Enabled = true;
            extrachzButton.Enabled = true;
            greenpepperButton.Enabled = true;
            pineappleButton.Enabled = true;
            mushroomButton.Enabled = true;
            onionButton.Enabled = true;
        }

        // Adds topping price to subtotal, writes topping name to order label
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
        }

        private void mushroomButton_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nMushroom";
            mushroom++;
            subtotal += toppingPrice;
        }

        private void onionLabel_Click(object sender, EventArgs e)
        {
            orderLabel.Text += "\nOnions";
            onions++;
            subtotal += toppingPrice;
        }

        // resets the receipt strings if the button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {


                printreceiptButton.Enabled = true;
                calculateOrderButton.Enabled = false;
                receiptLabel.Text = "";
                pricingLabel.Text = "";

                tendered = Convert.ToDouble(tenderedInput.Text);

                // sets TOTAL and SUBTOTAL to their values
                total = subtotal * tax;
                taxCharge = subtotal * tax - subtotal;

            // checks to see if there is a value entered in the tendered section. If there is none, it sets everything back to the way the program starts



                    // if theres a value that is less than the total, it displays a message
                if (tendered < total)
                {
                    tendered = Convert.ToDouble(tenderedInput.Text);
                    tenderErrorLabel.Text = "Invalid Change! Please place a new order!";
                    receiptLabel.Enabled = false;
                    smallButton.Enabled = false;
                    medButton.Enabled = false;
                    lrgButton.Enabled = false;
                    pepperoniButton.Enabled = false;
                    extrachzButton.Enabled = false;
                    greenpepperButton.Enabled = false;
                    pineappleButton.Enabled = false;
                    mushroomButton.Enabled = false;
                    onionButton.Enabled = false;
                    tenderedInput.Text = "";
                }

                // If there IS a value in the tendered section, It calculates the total and writes it out to the receipt.
                else
                {
                    tendered = Convert.ToDouble(tenderedInput.Text);
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
                    SoundPlayer player = new SoundPlayer(Properties.Resources.receipt1);
                    player.Play();

                    receipttitleLabel.Text += $"\nRECEIPT\n";
                    Thread.Sleep(100);
                    Refresh();
                    receipttitleLabel.Text += DateTime.Now.ToString("dd/MM/yy");
                    Thread.Sleep(100);
                    Refresh();
                    receipttitleLabel.Text += $"\nPINOS PIZZA";
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
                    Convert.ToString(change);
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
                    receiptLabel.Text += $"\nTotal\n";
                    pricingLabel.Text += $"\n{total.ToString("C")}";
                    Thread.Sleep(100);
                    Refresh();
                    receiptLabel.Text += $"\n\nTendered";
                    pricingLabel.Text += $"\n\n\n{tendered.ToString("C")}";
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
            catch
            {
                tenderedInput.Text = "0";
                tenderErrorLabel.Text = "Invalid Change! Please place a new order!";
                receiptLabel.Enabled = false;
                smallButton.Enabled = false;
                medButton.Enabled = false;
                lrgButton.Enabled = false;
                pepperoniButton.Enabled = false;
                extrachzButton.Enabled = false;
                greenpepperButton.Enabled = false;
                pineappleButton.Enabled = false;
                mushroomButton.Enabled = false;
                onionButton.Enabled = false;
                tenderedInput.Text = "";
            }
        }

        // if the new order button is clicked, it sets everything back to how it is at program run
        private void neworderButton_Click(object sender, EventArgs e)
        {
            smallButton.Enabled = true;
            medButton.Enabled = true;
            lrgButton.Enabled = true;
            pepperoniButton.Enabled = false;
            extrachzButton.Enabled = false;
            greenpepperButton.Enabled = false;
            pineappleButton.Enabled = false;
            mushroomButton.Enabled = false;
            onionButton.Enabled = false;
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
            totalPriceLabel.Text = "";
            printreceiptButton.Enabled = true;
            calculateOrderButton.Enabled = true;
            tenderErrorLabel.Text = "";
        }

        // If the Calculate button is pressed, it sets the subtotal and total to their values, as well as displays the total
        private void calculateOrderButton_Click(object sender, EventArgs e)
        {
            total = subtotal * tax;
            taxCharge = subtotal * tax - subtotal;
            totalPriceLabel.Text = $"{total.ToString("C")}";
        }


    }
}
