using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        private TextBox selctTexsBox;
        public Form1()
        {
            InitializeComponent();
        }
        private void OperatorChange(object sender, EventArgs e)
        {
            cmbOperator.Text = ((Button)sender).Text;
        }
        private void One_clikc_global(object sender, EventArgs e)
        {
            selctTexsBox.Text += ((Button)sender).Text;
        }

        private void txtNunber1_Enter(object sender, EventArgs e)
        {
            selctTexsBox = sender as TextBox;
        }



        private void txtNunber2_Enter(object sender, EventArgs e)
        {
            selctTexsBox = sender as TextBox;
        }



        private void btnEquals_Click(object sender, EventArgs e)
        {
            // 1. convert 'string' to 'int'
            int num1 = int.Parse(txtNunber1.Text);
            int num2 = int.Parse(txtNunber2.Text);

            // 2.
            //

            if (cmbOperator.Text == "+")
            {
                lblResult.Text = (num1 + num2).ToString();
            }
            else if (cmbOperator.Text == "-")
            {
                lblResult.Text = (num1 - num2).ToString();
            }
            else if (cmbOperator.Text == "*")
            {
                lblResult.Text = (num1 * num2).ToString();
            }
            else if (cmbOperator.Text == "/")
            {
                if (num2 == 0)
                {
                    return;
                }
                lblResult.Text = (num1 / num2).ToString();

            }







        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }

}