using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SimplexPro
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        double a = 0, b = 0, c = 0;

        private void iconButton13_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch(znak)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    break;

            }
            textBox1.Text = c.ToString();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;

        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessange(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormCalculator_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessange(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton18_MouseEnter(object sender, EventArgs e)
        {
            iconButton18.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton18_MouseLeave(object sender, EventArgs e)
        {
            iconButton18.ForeColor = Color.White;
        }

        private void iconButton19_MouseEnter(object sender, EventArgs e)
        {
            iconButton19.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton19_MouseLeave(object sender, EventArgs e)
        {
            iconButton19.ForeColor = Color.White;
        }

        private void iconButton12_MouseEnter(object sender, EventArgs e)
        {
            iconButton12.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton12_MouseLeave(object sender, EventArgs e)
        {
            iconButton12.ForeColor = Color.White;
        }

        private void iconButton8_MouseEnter(object sender, EventArgs e)
        {
            iconButton8.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton8_MouseLeave(object sender, EventArgs e)
        {
            iconButton8.ForeColor = Color.White;
        }

        private void iconButton7_MouseEnter(object sender, EventArgs e)
        {
            iconButton7.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton7_MouseLeave(object sender, EventArgs e)
        {
            iconButton7.ForeColor = Color.White;
        }

        private void iconButton5_MouseEnter(object sender, EventArgs e)
        {
            iconButton5.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton5_MouseLeave(object sender, EventArgs e)
        {
            iconButton5.ForeColor = Color.White;
        }

        private void iconButton6_MouseEnter(object sender, EventArgs e)
        {
            iconButton6.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            iconButton6.ForeColor = Color.White;
        }

        private void iconButton11_MouseEnter(object sender, EventArgs e)
        {
            iconButton11.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton11_MouseLeave(object sender, EventArgs e)
        {
            iconButton11.ForeColor = Color.White;
        }

        private void iconButton17_MouseEnter(object sender, EventArgs e)
        {
            iconButton17.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton17_MouseLeave(object sender, EventArgs e)
        {
            iconButton17.ForeColor = Color.White;
        }

        private void iconButton16_MouseEnter(object sender, EventArgs e)
        {
            iconButton16.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton16_MouseLeave(object sender, EventArgs e)
        {
            iconButton16.ForeColor = Color.White;
        }

        private void iconButton10_MouseEnter(object sender, EventArgs e)
        {
            iconButton10.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton10_MouseLeave(object sender, EventArgs e)
        {
            iconButton10.ForeColor = Color.White;
        }

        private void iconButton4_MouseEnter(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.White;
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.ForeColor = Color.White;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.ForeColor = Color.White;
        }

        private void iconButton3_MouseEnter(object sender, EventArgs e)
        {
            iconButton3.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton3_MouseLeave(object sender, EventArgs e)
        {
            iconButton3.ForeColor = Color.White;
        }

        private void iconButton9_MouseEnter(object sender, EventArgs e)
        {
            iconButton9.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton9_MouseLeave(object sender, EventArgs e)
        {
            iconButton9.ForeColor = Color.White;
        }

        private void iconButton15_MouseEnter(object sender, EventArgs e)
        {
            iconButton15.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton15_MouseLeave(object sender, EventArgs e)
        {
            iconButton15.ForeColor = Color.White;
        }

        private void iconButton13_MouseEnter(object sender, EventArgs e)
        {
            iconButton13.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton13_MouseLeave(object sender, EventArgs e)
        {
            iconButton13.ForeColor = Color.White;
        }

        private void iconButton14_MouseEnter(object sender, EventArgs e)
        {
            iconButton14.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton14_MouseLeave(object sender, EventArgs e)
        {
            iconButton14.ForeColor = Color.White;
        }

        private void iconButton20_MouseEnter(object sender, EventArgs e)
        {
            iconButton20.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton20_MouseLeave(object sender, EventArgs e)
        {
            iconButton20.ForeColor = Color.White;
        }

        private void iconButton20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        char znak = '+';
        private void iconButton17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        
    }
}
 