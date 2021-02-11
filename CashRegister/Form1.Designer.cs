
namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.smallButton = new System.Windows.Forms.Button();
            this.medButton = new System.Windows.Forms.Button();
            this.lrgButton = new System.Windows.Forms.Button();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.pepperoniButton = new System.Windows.Forms.Button();
            this.extrachzButton = new System.Windows.Forms.Button();
            this.pineappleButton = new System.Windows.Forms.Button();
            this.mushroomButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.ordertitleLabel = new System.Windows.Forms.Label();
            this.printreceiptButton = new System.Windows.Forms.Button();
            this.neworderButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.onionButton = new System.Windows.Forms.Button();
            this.greenpepperButton = new System.Windows.Forms.Button();
            this.receipttitleLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pricingLabel = new System.Windows.Forms.Label();
            this.pizzaSizeLabel = new System.Windows.Forms.Label();
            this.tenderErrorLabel = new System.Windows.Forms.Label();
            this.calculateOrderButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Pinos Pizza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(213, 70);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(47, 22);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Size:";
            // 
            // smallButton
            // 
            this.smallButton.Location = new System.Drawing.Point(168, 95);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(43, 23);
            this.smallButton.TabIndex = 2;
            this.smallButton.Text = "Sml";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.Click += new System.EventHandler(this.smallButton_Click);
            // 
            // medButton
            // 
            this.medButton.Location = new System.Drawing.Point(217, 95);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(43, 23);
            this.medButton.TabIndex = 3;
            this.medButton.Text = "Med";
            this.medButton.UseVisualStyleBackColor = true;
            this.medButton.Click += new System.EventHandler(this.medButton_Click);
            // 
            // lrgButton
            // 
            this.lrgButton.Location = new System.Drawing.Point(266, 95);
            this.lrgButton.Name = "lrgButton";
            this.lrgButton.Size = new System.Drawing.Size(43, 23);
            this.lrgButton.TabIndex = 4;
            this.lrgButton.Text = "Lrg";
            this.lrgButton.UseVisualStyleBackColor = true;
            this.lrgButton.Click += new System.EventHandler(this.lrgButton_Click);
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.toppingsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsLabel.Location = new System.Drawing.Point(191, 132);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(92, 22);
            this.toppingsLabel.TabIndex = 8;
            this.toppingsLabel.Text = "Toppings:";
            // 
            // pepperoniButton
            // 
            this.pepperoniButton.Location = new System.Drawing.Point(138, 157);
            this.pepperoniButton.Name = "pepperoniButton";
            this.pepperoniButton.Size = new System.Drawing.Size(64, 43);
            this.pepperoniButton.TabIndex = 9;
            this.pepperoniButton.Text = "Pepperoni";
            this.pepperoniButton.UseVisualStyleBackColor = true;
            this.pepperoniButton.Click += new System.EventHandler(this.pepperoniButton_Click);
            // 
            // extrachzButton
            // 
            this.extrachzButton.Location = new System.Drawing.Point(208, 157);
            this.extrachzButton.Name = "extrachzButton";
            this.extrachzButton.Size = new System.Drawing.Size(64, 43);
            this.extrachzButton.TabIndex = 10;
            this.extrachzButton.Text = "Extra Cheese";
            this.extrachzButton.UseVisualStyleBackColor = true;
            this.extrachzButton.Click += new System.EventHandler(this.extrachzButton_Click);
            // 
            // pineappleButton
            // 
            this.pineappleButton.Location = new System.Drawing.Point(138, 206);
            this.pineappleButton.Name = "pineappleButton";
            this.pineappleButton.Size = new System.Drawing.Size(64, 43);
            this.pineappleButton.TabIndex = 11;
            this.pineappleButton.Text = "Pineapple";
            this.pineappleButton.UseVisualStyleBackColor = true;
            this.pineappleButton.Click += new System.EventHandler(this.pineappleButton_Click);
            // 
            // mushroomButton
            // 
            this.mushroomButton.Location = new System.Drawing.Point(208, 206);
            this.mushroomButton.Name = "mushroomButton";
            this.mushroomButton.Size = new System.Drawing.Size(64, 43);
            this.mushroomButton.TabIndex = 12;
            this.mushroomButton.Text = "Mushroom";
            this.mushroomButton.UseVisualStyleBackColor = true;
            this.mushroomButton.Click += new System.EventHandler(this.mushroomButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.Location = new System.Drawing.Point(12, 95);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(121, 270);
            this.orderLabel.TabIndex = 14;
            // 
            // ordertitleLabel
            // 
            this.ordertitleLabel.AutoSize = true;
            this.ordertitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ordertitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertitleLabel.Location = new System.Drawing.Point(12, 51);
            this.ordertitleLabel.Name = "ordertitleLabel";
            this.ordertitleLabel.Size = new System.Drawing.Size(62, 22);
            this.ordertitleLabel.TabIndex = 15;
            this.ordertitleLabel.Text = "Order:";
            // 
            // printreceiptButton
            // 
            this.printreceiptButton.Location = new System.Drawing.Point(16, 368);
            this.printreceiptButton.Name = "printreceiptButton";
            this.printreceiptButton.Size = new System.Drawing.Size(117, 29);
            this.printreceiptButton.TabIndex = 16;
            this.printreceiptButton.Text = "Print Receipt";
            this.printreceiptButton.UseVisualStyleBackColor = true;
            this.printreceiptButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // neworderButton
            // 
            this.neworderButton.Location = new System.Drawing.Point(394, 368);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(117, 29);
            this.neworderButton.TabIndex = 19;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(348, 95);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(119, 270);
            this.receiptLabel.TabIndex = 17;
            // 
            // onionButton
            // 
            this.onionButton.Location = new System.Drawing.Point(278, 206);
            this.onionButton.Name = "onionButton";
            this.onionButton.Size = new System.Drawing.Size(64, 43);
            this.onionButton.TabIndex = 21;
            this.onionButton.Text = "Onions";
            this.onionButton.UseVisualStyleBackColor = true;
            this.onionButton.Click += new System.EventHandler(this.onionLabel_Click);
            // 
            // greenpepperButton
            // 
            this.greenpepperButton.Location = new System.Drawing.Point(278, 157);
            this.greenpepperButton.Name = "greenpepperButton";
            this.greenpepperButton.Size = new System.Drawing.Size(64, 43);
            this.greenpepperButton.TabIndex = 20;
            this.greenpepperButton.Text = "Green Peppers";
            this.greenpepperButton.UseVisualStyleBackColor = true;
            this.greenpepperButton.Click += new System.EventHandler(this.greenpepperButton_Click);
            // 
            // receipttitleLabel
            // 
            this.receipttitleLabel.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipttitleLabel.Location = new System.Drawing.Point(346, 51);
            this.receipttitleLabel.Name = "receipttitleLabel";
            this.receipttitleLabel.Size = new System.Drawing.Size(165, 44);
            this.receipttitleLabel.TabIndex = 26;
            this.receipttitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(215, 312);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(113, 20);
            this.tenderedInput.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(139, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tendered:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricingLabel
            // 
            this.pricingLabel.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricingLabel.Location = new System.Drawing.Point(466, 95);
            this.pricingLabel.Name = "pricingLabel";
            this.pricingLabel.Size = new System.Drawing.Size(45, 273);
            this.pricingLabel.TabIndex = 29;
            // 
            // pizzaSizeLabel
            // 
            this.pizzaSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSizeLabel.Location = new System.Drawing.Point(12, 81);
            this.pizzaSizeLabel.Name = "pizzaSizeLabel";
            this.pizzaSizeLabel.Size = new System.Drawing.Size(120, 18);
            this.pizzaSizeLabel.TabIndex = 30;
            // 
            // tenderErrorLabel
            // 
            this.tenderErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderErrorLabel.Location = new System.Drawing.Point(139, 368);
            this.tenderErrorLabel.Name = "tenderErrorLabel";
            this.tenderErrorLabel.Size = new System.Drawing.Size(249, 32);
            this.tenderErrorLabel.TabIndex = 31;
            this.tenderErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateOrderButton
            // 
            this.calculateOrderButton.Location = new System.Drawing.Point(138, 265);
            this.calculateOrderButton.Name = "calculateOrderButton";
            this.calculateOrderButton.Size = new System.Drawing.Size(64, 44);
            this.calculateOrderButton.TabIndex = 32;
            this.calculateOrderButton.Text = "Calculate Order";
            this.calculateOrderButton.UseVisualStyleBackColor = true;
            this.calculateOrderButton.Click += new System.EventHandler(this.calculateOrderButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Location = new System.Drawing.Point(214, 272);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(116, 31);
            this.totalPriceLabel.TabIndex = 33;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CashRegister.Properties.Resources._213;
            this.ClientSize = new System.Drawing.Size(527, 409);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.calculateOrderButton);
            this.Controls.Add(this.tenderErrorLabel);
            this.Controls.Add(this.pizzaSizeLabel);
            this.Controls.Add(this.pricingLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.receipttitleLabel);
            this.Controls.Add(this.onionButton);
            this.Controls.Add(this.greenpepperButton);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printreceiptButton);
            this.Controls.Add(this.ordertitleLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.mushroomButton);
            this.Controls.Add(this.pineappleButton);
            this.Controls.Add(this.extrachzButton);
            this.Controls.Add(this.pepperoniButton);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.lrgButton);
            this.Controls.Add(this.medButton);
            this.Controls.Add(this.smallButton);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CashRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button smallButton;
        private System.Windows.Forms.Button medButton;
        private System.Windows.Forms.Button lrgButton;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.Button pepperoniButton;
        private System.Windows.Forms.Button extrachzButton;
        private System.Windows.Forms.Button pineappleButton;
        private System.Windows.Forms.Button mushroomButton;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label ordertitleLabel;
        private System.Windows.Forms.Button printreceiptButton;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button onionButton;
        private System.Windows.Forms.Button greenpepperButton;
        private System.Windows.Forms.Label receipttitleLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pricingLabel;
        private System.Windows.Forms.Label pizzaSizeLabel;
        private System.Windows.Forms.Label tenderErrorLabel;
        private System.Windows.Forms.Button calculateOrderButton;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

