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
using FontAwesome.Sharp;

namespace SimplexPro
{
    public partial class FormLogin : Form
    {
        public static string ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KeySiplex.mdb";
        private OleDbConnection myConnection;
        bool eye = true;
        private int count;
        public FormLogin()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(ConnStr);
            myConnection.Open();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;

         
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
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 0, 43);
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
        }

        private void SignButton_MouseEnter(object sender, EventArgs e)
        {
            SignButton.BackColor = Color.FromArgb(11, 7, 17);
            SignButton.ForeColor = Color.FromArgb(255, 0, 43);
            SignButton.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 43);
        }

        private void SignButton_MouseLeave(object sender, EventArgs e)
        {
            SignButton.BackColor = Color.FromArgb(11, 7, 17);
            SignButton.ForeColor = Color.White;
            SignButton.FlatAppearance.BorderColor = Color.White;
        }

        private void logoPic_Click(object sender, EventArgs e)
        {
            loginBox.Clear();
            passBox.Clear();
            iconUser.IconColor = Color.White;
            loginPanel.BackColor = Color.White;
            loginBox.ForeColor = Color.White;
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

        private void SignButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox.Text;
            string passUser = passBox.Text;

            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand("SELECT * FROM `user` WHERE `Login` = @uL AND `Pass` = @uP", myConnection);
            command.Parameters.Add("@uL", OleDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", OleDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                Form MenuForm = new MenuForm();
                MenuForm.Show();
                this.Hide();
                myConnection.Close();
            }
            else
                MessageBox.Show("Не правильно введен логин или пароль!");
                label1.ForeColor = Color.White;
                label1.Text = "У вас осталось 3 попытки";
            if (count == 0)
            {   
                label1.ForeColor= Color.White;
                label1.Text = "У вас осталось 2 попытки";
            }
                if (count == 1)
            { 
                label1.ForeColor = Color.White;
                label1.Text = "У вас осталась 1 попытка";
            }
            if (count++ == 2)
            {
                Application.Exit();
            }

        }

        private void exitPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
            myConnection.Close();
        }

        private void hidePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessange(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessange(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitPic_MouseEnter(object sender, EventArgs e)
        {
            exitPic.IconColor = Color.FromArgb(255, 0, 43);
        }

        private void exitPic_MouseLeave(object sender, EventArgs e)
        {
            exitPic.IconColor = Color.White;
        }

        private void hidePic_MouseEnter(object sender, EventArgs e)
        {
            hidePic.IconColor = Color.FromArgb(255, 0, 43);
        }

        private void hidePic_MouseLeave(object sender, EventArgs e)
        {
            hidePic.IconColor = Color.White;
        }
    }
    
}
