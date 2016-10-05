using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        double tipPercent = 1;

        public Form1()
        {
            InitializeComponent(); 
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
            catch { }
        }

        private void bill_Input_TextChanged(object sender, EventArgs e)
        {
            ComputeBill();
        }

        private void Percentage_Input_Box_TextChanged(object sender, EventArgs e)
        {
            string input = percentage_Input_Box.Text;
            double percentage;
            Double.TryParse(input, out percentage);
            percentage = percentage / 100;
            tipPercent = 1 + percentage;

            ComputeBill();
        }

        private void ComputeBill()
        {
            string input = bill_Input.Text;
            double total;
            Double.TryParse(input, out total);
            bill_Output.Text = (total * tipPercent).ToString();
        }
    }
}
