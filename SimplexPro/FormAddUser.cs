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
    public partial class FormAddUser : Form
    {
        public static string ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KeySiplex.mdb";
        private OleDbConnection myConnection;
        public FormAddUser()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(ConnStr);
            myConnection.Open();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "keySiplexDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.keySiplexDataSet.user);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null)
               
            {
                MessageBox.Show("Не все данные введены!");
                return;
            }

            int kod = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
            string login = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string pass = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string prefix = dataGridView1.Rows[index].Cells[3].Value.ToString();
           


            string query = "INSERT INTO `user` VALUES(" + kod + ",'" + login + "','" + pass + "','" + prefix +"')";
            OleDbCommand dbCommand = new OleDbCommand(query, myConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса");
            else
                MessageBox.Show("Данные добавлены");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int kod = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
            string query = "DELETE FROM `user` WHERE `ID` = " + kod;
            OleDbCommand dbCommand = new OleDbCommand(query, myConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса");
            else
                MessageBox.Show("Данные удалены");
            dataGridView1.Rows.RemoveAt(index);
        }

        private void FormAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.ForeColor = Color.White;
        }

        private void deleteBtn_MouseEnter(object sender, EventArgs e)
        {
            deleteBtn.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteBtn.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void retrBtn_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.keySiplexDataSet.user);
        }

        private void retrBtn_MouseEnter(object sender, EventArgs e)
        {
            retrBtn.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void retrBtn_MouseLeave(object sender, EventArgs e)
        {
            retrBtn.ForeColor = Color.White;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessange(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessange(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
