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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

    private void divide_Click(object sender, EventArgs e)
        {
            symb.Text = "/";
            if (num2.Value != 0)
            {
                Results.Text = (num1.Value / num2.Value).ToString();
                History.Text += Results.Text + "\r\n";
            } else
            {
                ErrorWindow err = new ErrorWindow();
                err.ShowDialog();
            }
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            symb.Text = "х";
            Results.Text = (num1.Value * num2.Value).ToString();
            History.Text += Results.Text + "\r\n";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            symb.Text = "-";
            Results.Text = (num1.Value - num2.Value).ToString();
            History.Text += Results.Text + "\r\n";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            symb.Text = "+";
            Results.Text = (num1.Value + num2.Value).ToString();
            History.Text += Results.Text + "\r\n";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            History.Clear();
        }

        private void History_TextChanged(object sender, EventArgs e)
        {
            if (History.Lines.Length > 6) // когда в textbox больше чер 5 строк
            {
                var hist = History.Lines.ToList();
                /* удалить первый элемент, тем самым 
                   освободив 5-ю строку для записи результатов */
                hist.RemoveAt(0); 
                History.Lines = hist.ToArray(); 
            }
        }
    }
}
