using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace SimplexPro
{
    public partial class AddUser : Form
    {
        public static string ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KeySiplex.mdb";
        private OleDbConnection myConnection;
        bool eye = true;
        public AddUser()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(ConnStr);
            myConnection.Open();
        }

        private void iconQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция предназначена только для Admin", "Подсказка");
        }

        private void iconEye_Click(object sender, EventArgs e)
        {
            if (eye)
            {
                passBox.UseSystemPasswordChar = false;
                eye = false;
            }
            else
            {
                passBox.UseSystemPasswordChar = true;
                eye = true;
            }
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            iconUser.IconColor = Color.FromArgb(255, 0, 43);
            loginPanel.BackColor = Color.FromArgb(255, 0, 43);
            loginBox.ForeColor = Color.FromArgb(255, 0, 43);

            iconKey.IconColor = Color.White;
            passPanel.BackColor = Color.White;
            passBox.ForeColor = Color.White;
            iconEye.IconColor = Color.White;
        }

        private void passBox_Click(object sender, EventArgs e)
        {
            iconKey.IconColor = Color.FromArgb(255, 0, 43);
            passPanel.BackColor = Color.FromArgb(255, 0, 43);
            passBox.ForeColor = Color.FromArgb(255, 0, 43);
            iconEye.IconColor = Color.FromArgb(255, 0, 43);

            iconUser.IconColor = Color.White;
            loginPanel.BackColor = Color.White;
            loginBox.ForeColor = Color.White;

            iconPictureBox1.IconColor = Color.White;
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(11, 7, 17);
            iconButton2.ForeColor = Color.FromArgb(255, 0, 43);
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 43);
            iconButton2.IconColor = Color.FromArgb(255, 0, 43);
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(11, 7, 17);
            iconButton2.ForeColor = Color.White;
            iconButton2.FlatAppearance.BorderColor = Color.White;
            iconButton2.IconColor = Color.White;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            iconUser.IconColor = Color.FromArgb(255, 0, 43);
            loginPanel.BackColor = Color.FromArgb(255, 0, 43);
            loginBox.ForeColor = Color.FromArgb(255, 0, 43);

            iconKey.IconColor = Color.White;
            passPanel.BackColor = Color.White;
            passBox.ForeColor = Color.White;
            iconEye.IconColor = Color.White;
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            iconKey.IconColor = Color.FromArgb(255, 0, 43);
            passPanel.BackColor = Color.FromArgb(255, 0, 43);
            passBox.ForeColor = Color.FromArgb(255, 0, 43);
            iconEye.IconColor = Color.FromArgb(255, 0, 43);

            iconUser.IconColor = Color.White;
            loginPanel.BackColor = Color.White;
            loginBox.ForeColor = Color.White;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox.Text;
            string passUser = passBox.Text;
            string prefix = textBox1.Text;
            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand("SELECT * FROM `user` WHERE `Login` = @uL AND `Pass` = @uP AND `Prefix` = @uPr", myConnection);
            command.Parameters.Add("@uL", OleDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", OleDbType.VarChar).Value = passUser;
            command.Parameters.Add("@uPr", OleDbType.VarChar).Value = prefix;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                Form FormAddUser = new FormAddUser();
                FormAddUser.Show();
                this.Hide();
                myConnection.Close();
            }
            else
                MessageBox.Show("Не правильно введен логин, пароль или префикс!");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = Color.FromArgb(255, 0, 43);
            panel1.BackColor = Color.FromArgb(255, 0, 43);
            textBox1.ForeColor = Color.FromArgb(255, 0, 43);

            iconUser.IconColor = Color.White;
            loginPanel.BackColor = Color.White;
            loginBox.ForeColor = Color.White;

            iconKey.IconColor = Color.White;
            passPanel.BackColor = Color.White;
            passBox.ForeColor = Color.White;
            iconEye.IconColor = Color.White;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            iconPictureBox1.IconColor = Color.FromArgb(255, 0, 43);
            panel1.BackColor = Color.FromArgb(255, 0, 43);
            textBox1.ForeColor = Color.FromArgb(255, 0, 43);

            iconUser.IconColor = Color.White;
            loginPanel.BackColor = Color.White;
            loginBox.ForeColor = Color.White;

            iconKey.IconColor = Color.White;
            passPanel.BackColor = Color.White;
            passBox.ForeColor = Color.White;
            iconEye.IconColor = Color.White;
        }
    }
}

