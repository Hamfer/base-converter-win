using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTextBox(long number)
        {
            textBoxBinary.Text = Convert.ToString(number, 2);
            textBoxOctal.Text = Convert.ToString(number, 8);
            textBoxDecimal.Text = Convert.ToString(number, 10);
            textBoxHex.Text = Convert.ToString(number, 16).ToUpper();
        }
        
        private void EmptyTextBox()
        {
            textBoxBinary.Text = "";
            textBoxOctal.Text = "";
            textBoxDecimal.Text = "";
            textBoxHex.Text = "";
        }

        private void textBoxBase_TextChanged(object sender, EventArgs e, int baseNumber)
        {
            var textBox = (MaskedTextBox)sender;
            try
            {
                if (!textBox.Focused)
                    return;
                if (textBox.TextLength == 0) 
                {
                    EmptyTextBox();
                    return;
                }
                var number = Convert.ToInt64(textBox.Text, baseNumber);
                textBox.ForeColor = Color.Black;
                UpdateTextBox(number);
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                textBox.ForeColor = Color.Red;
            }
        }

        private void textBoxBase_KeyPress(object sender, KeyPressEventArgs e, int baseNumber)
        {
            if (char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
                return;
            }
            switch (baseNumber)
            {
                case 2:
                    e.Handled = System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-1]");
                    break;
                case 8:
                    e.Handled = System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-7]");
                    break;
                case 10:
                    e.Handled = System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-9]");
                    break;
                case 16:
                    e.Handled = System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-9A-Fa-f]");
                    break;
            }
        }
    }
}