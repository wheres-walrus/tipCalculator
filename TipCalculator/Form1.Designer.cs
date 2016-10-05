namespace TipCalculator
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
            this.bill_Input = new System.Windows.Forms.TextBox();
            this.bill_Output = new System.Windows.Forms.TextBox();
            this.initialBillLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.percentage_Input_Box = new System.Windows.Forms.TextBox();
            this.enterTipLabel = new System.Windows.Forms.Label();
            this.percentSignLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bill_Input
            // 
            this.bill_Input.Location = new System.Drawing.Point(261, 78);
            this.bill_Input.Name = "bill_Input";
            this.bill_Input.Size = new System.Drawing.Size(100, 22);
            this.bill_Input.TabIndex = 0;
            this.bill_Input.TextChanged += new System.EventHandler(this.bill_Input_TextChanged);
            // 
            // bill_Output
            // 
            this.bill_Output.Location = new System.Drawing.Point(261, 141);
            this.bill_Output.Name = "bill_Output";
            this.bill_Output.ReadOnly = true;
            this.bill_Output.Size = new System.Drawing.Size(100, 22);
            this.bill_Output.TabIndex = 1;
            // 
            // initialBillLabel
            // 
            this.initialBillLabel.AutoSize = true;
            this.initialBillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialBillLabel.Location = new System.Drawing.Point(138, 83);
            this.initialBillLabel.Name = "initialBillLabel";
            this.initialBillLabel.Size = new System.Drawing.Size(116, 17);
            this.initialBillLabel.TabIndex = 2;
            this.initialBillLabel.Text = "Enter Total Bill";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(148, 146);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(106, 17);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total with Tip";
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(157, 198);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(204, 66);
            this.computeButton.TabIndex = 4;
            this.computeButton.Text = "Compute Tip!";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // percentage_Input_Box
            // 
            this.percentage_Input_Box.Location = new System.Drawing.Point(261, 35);
            this.percentage_Input_Box.Name = "percentage_Input_Box";
            this.percentage_Input_Box.Size = new System.Drawing.Size(100, 22);
            this.percentage_Input_Box.TabIndex = 5;
            this.percentage_Input_Box.Text = "0";
            this.percentage_Input_Box.TextChanged += new System.EventHandler(this.Percentage_Input_Box_TextChanged);
            // 
            // enterTipLabel
            // 
            this.enterTipLabel.AutoSize = true;
            this.enterTipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTipLabel.Location = new System.Drawing.Point(91, 40);
            this.enterTipLabel.Name = "enterTipLabel";
            this.enterTipLabel.Size = new System.Drawing.Size(163, 17);
            this.enterTipLabel.TabIndex = 6;
            this.enterTipLabel.Text = "Enter Tip Percentage";
            // 
            // percentSignLabel
            // 
            this.percentSignLabel.AutoSize = true;
            this.percentSignLabel.Location = new System.Drawing.Point(368, 39);
            this.percentSignLabel.Name = "percentSignLabel";
            this.percentSignLabel.Size = new System.Drawing.Size(20, 17);
            this.percentSignLabel.TabIndex = 7;
            this.percentSignLabel.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 391);
            this.Controls.Add(this.percentSignLabel);
            this.Controls.Add(this.enterTipLabel);
            this.Controls.Add(this.percentage_Input_Box);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.initialBillLabel);
            this.Controls.Add(this.bill_Output);
            this.Controls.Add(this.bill_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bill_Input;
        private System.Windows.Forms.TextBox bill_Output;
        private System.Windows.Forms.Label initialBillLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.TextBox percentage_Input_Box;
        private System.Windows.Forms.Label enterTipLabel;
        private System.Windows.Forms.Label percentSignLabel;
    }
}

