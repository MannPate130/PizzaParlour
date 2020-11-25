
namespace WindowsFormsApp1
{
    partial class pizzaTitle
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
            this.titlePizza = new System.Windows.Forms.Label();
            this.toppingLabel = new System.Windows.Forms.Label();
            this.numberOftoppingsTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.costOutputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlePizza
            // 
            this.titlePizza.BackColor = System.Drawing.Color.Red;
            this.titlePizza.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePizza.ForeColor = System.Drawing.Color.White;
            this.titlePizza.Location = new System.Drawing.Point(3, -4);
            this.titlePizza.Name = "titlePizza";
            this.titlePizza.Size = new System.Drawing.Size(799, 106);
            this.titlePizza.TabIndex = 0;
            this.titlePizza.Text = "Central Pizza Parlour";
            this.titlePizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toppingLabel
            // 
            this.toppingLabel.AutoSize = true;
            this.toppingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingLabel.ForeColor = System.Drawing.Color.White;
            this.toppingLabel.Location = new System.Drawing.Point(130, 158);
            this.toppingLabel.Name = "toppingLabel";
            this.toppingLabel.Size = new System.Drawing.Size(271, 32);
            this.toppingLabel.TabIndex = 1;
            this.toppingLabel.Text = "Number of Toppings";
            // 
            // numberOftoppingsTextbox
            // 
            this.numberOftoppingsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOftoppingsTextbox.Location = new System.Drawing.Point(434, 155);
            this.numberOftoppingsTextbox.Name = "numberOftoppingsTextbox";
            this.numberOftoppingsTextbox.Size = new System.Drawing.Size(174, 35);
            this.numberOftoppingsTextbox.TabIndex = 2;
            this.numberOftoppingsTextbox.TextChanged += new System.EventHandler(this.numberOftoppingsTextbox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(278, 255);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(230, 46);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // costOutputlabel
            // 
            this.costOutputlabel.BackColor = System.Drawing.Color.White;
            this.costOutputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costOutputlabel.ForeColor = System.Drawing.Color.Black;
            this.costOutputlabel.Location = new System.Drawing.Point(147, 336);
            this.costOutputlabel.Name = "costOutputlabel";
            this.costOutputlabel.Size = new System.Drawing.Size(493, 75);
            this.costOutputlabel.TabIndex = 4;
            // 
            // pizzaTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costOutputlabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberOftoppingsTextbox);
            this.Controls.Add(this.toppingLabel);
            this.Controls.Add(this.titlePizza);
            this.Name = "pizzaTitle";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlePizza;
        private System.Windows.Forms.Label toppingLabel;
        private System.Windows.Forms.TextBox numberOftoppingsTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label costOutputlabel;
    }
}

