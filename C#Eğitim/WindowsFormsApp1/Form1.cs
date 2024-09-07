using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Formda tuş vuruşlarını yakalamak için gerekli
            this.KeyDown += new KeyEventHandler(Form1_KeyDown); // KeyDown olayını bağla
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress); // KeyPress olayını bağla
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // + tuşu veya + işareti
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                PerformCalculation("+");
                e.Handled = true; 
            }
            // - tuşu veya - işareti
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                PerformCalculation("-");
                e.Handled = true; 
            }
            // * tuşu
            else if (e.KeyCode == Keys.Multiply)
            {
                PerformCalculation("*");
                e.Handled = true; 
            }
            // / tuşu veya ? işareti
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                PerformCalculation("/");
                e.Handled = true;
            }
            // % işareti
            else if (e.KeyCode == Keys.Oem5 || e.KeyCode == Keys.Oemtilde)
            {
                PerformCalculation("%");
                e.Handled = true; 
            }
            // C tuşu
            else if (e.KeyCode == Keys.C)
            {
                ClearFields();
                e.Handled = true; 
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '%')
            {
                e.Handled = true; 
            }
            else if (e.KeyChar == (char)Keys.C) 
            {
                ClearFields();
                e.Handled = true;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            PerformCalculation("+");
        }

        private void btnSubtract_Click_1(object sender, EventArgs e)
        {
            PerformCalculation("-");
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            PerformCalculation("*");
        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            PerformCalculation("/");
        }

        private void btnMod_Click_1(object sender, EventArgs e)
        {
            PerformCalculation("%");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void PerformCalculation(string operation)
        {
            double number1, number2, result = 0;

            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            MessageBox.Show("Bir sayıyı sıfıra bölemezsiniz.");
                            return;
                        }
                        break;
                    case "%":
                        if (number2 != 0)
                        {
                            result = number1 % number2;
                        }
                        else
                        {
                            MessageBox.Show("Bir sayıyı sıfıra bölemezsiniz.");
                            return;
                        }
                        break;
                }
                lblResult.Text = "Sonuç: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
            }
        }

        private void ClearFields()
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            lblResult.Text = "Sonuç: ";
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            
        }

      

        private void lblResult_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
