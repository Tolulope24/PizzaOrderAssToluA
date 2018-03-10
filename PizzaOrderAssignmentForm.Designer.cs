namespace PizzaOrderAssToluA
{
    partial class frmPizzaOrderAssignment
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblExtraLarge = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblSmall = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.nudSizeOfPizza = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfToppings = new System.Windows.Forms.NumericUpDown();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeOfPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(16, 50);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(354, 23);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Select the size of Pizza you would like ";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(16, 138);
            this.lblLarge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(147, 23);
            this.lblLarge.TabIndex = 1;
            this.lblLarge.Text = "Large Pizza = 3";
            this.lblLarge.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblExtraLarge
            // 
            this.lblExtraLarge.AutoSize = true;
            this.lblExtraLarge.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLarge.Location = new System.Drawing.Point(16, 167);
            this.lblExtraLarge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtraLarge.Name = "lblExtraLarge";
            this.lblExtraLarge.Size = new System.Drawing.Size(201, 23);
            this.lblExtraLarge.TabIndex = 2;
            this.lblExtraLarge.Text = "Extra Large Pizza = 4\r\n";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(16, 110);
            this.lblMedium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(171, 23);
            this.lblMedium.TabIndex = 3;
            this.lblMedium.Text = "Medium Pizza = 2";
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmall.Location = new System.Drawing.Point(16, 82);
            this.lblSmall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(146, 23);
            this.lblSmall.TabIndex = 4;
            this.lblSmall.Text = "Small Pizza = 1";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(17, 223);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(444, 23);
            this.lblToppings.TabIndex = 9;
            this.lblToppings.Text = "Select The Number Of Toppings You Would Like ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(19, 298);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(110, 23);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "Subtotal  = ";
            // 
            // nudSizeOfPizza
            // 
            this.nudSizeOfPizza.Location = new System.Drawing.Point(412, 49);
            this.nudSizeOfPizza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudSizeOfPizza.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSizeOfPizza.Name = "nudSizeOfPizza";
            this.nudSizeOfPizza.Size = new System.Drawing.Size(64, 22);
            this.nudSizeOfPizza.TabIndex = 11;
            this.nudSizeOfPizza.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudNumberOfToppings
            // 
            this.nudNumberOfToppings.Location = new System.Drawing.Point(508, 222);
            this.nudNumberOfToppings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNumberOfToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfToppings.Name = "nudNumberOfToppings";
            this.nudNumberOfToppings.Size = new System.Drawing.Size(64, 22);
            this.nudNumberOfToppings.TabIndex = 12;
            this.nudNumberOfToppings.ValueChanged += new System.EventHandler(this.nudNumberOfToppings_ValueChanged);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(19, 334);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(63, 23);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "HST =";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(19, 370);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 23);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total = ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(484, 370);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Caclulate ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmPizzaOrderAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(653, 558);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.nudNumberOfToppings);
            this.Controls.Add(this.nudSizeOfPizza);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblSmall);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblExtraLarge);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblQuestion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPizzaOrderAssignment";
            this.Text = "PizzaOrder";
            this.Load += new System.EventHandler(this.frmPizzaOrderAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeOfPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblExtraLarge;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.NumericUpDown nudSizeOfPizza;
        private System.Windows.Forms.NumericUpDown nudNumberOfToppings;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}

