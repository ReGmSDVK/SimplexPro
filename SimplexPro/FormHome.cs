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

namespace SimplexPro
{
    public partial class FormHome : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Недвижимость.mdb";
        private OleDbConnection myConnection;
        public FormHome()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "недвижимостьDataSet.Дома". При необходимости она может быть перемещена или удалена.
            this.домаTableAdapter.Fill(this.недвижимостьDataSet.Дома);

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
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null ||
                dataGridView1.Rows[index].Cells[8].Value == null ||
                dataGridView1.Rows[index].Cells[9].Value == null ||
                dataGridView1.Rows[index].Cells[10].Value == null ||
                dataGridView1.Rows[index].Cells[11].Value == null)

            {
                MessageBox.Show("Не все данные введены!");
                return;
            }

            int kod = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
            string categori = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string tip = dataGridView1.Rows[index].Cells[2].Value.ToString();
            int comnat = Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value.ToString());
            string meterial = dataGridView1.Rows[index].Cells[4].Value.ToString();
            int ploshad = Convert.ToInt32(dataGridView1.Rows[index].Cells[5].Value.ToString());
            int etazh = Convert.ToInt32(dataGridView1.Rows[index].Cells[6].Value.ToString());
            int uchastoc = Convert.ToInt32(dataGridView1.Rows[index].Cells[7].Value.ToString());
            string raion = dataGridView1.Rows[index].Cells[8].Value.ToString();
            string adres = dataGridView1.Rows[index].Cells[9].Value.ToString();
            int ear = Convert.ToInt32(dataGridView1.Rows[index].Cells[10].Value.ToString());
            int owner = Convert.ToInt32(dataGridView1.Rows[index].Cells[11].Value.ToString());

            string query = "INSERT INTO Дома VALUES(" + kod + ",'" + categori + "','" + tip + "'," + comnat + ", '" + meterial + "'," + ploshad + "," + etazh + "," + uchastoc + ", '" + raion + "', '" + adres + "'," + ear + "," + owner + ")";
            OleDbCommand dbCommand = new OleDbCommand(query, myConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса");
            else
                MessageBox.Show("Данные добавлены");
        }

        private void retrBtn_Click(object sender, EventArgs e)
        {
            this.домаTableAdapter.Fill(this.недвижимостьDataSet.Дома);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int kod = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
            string query = "DELETE FROM Дома WHERE `Код дома` = " + kod;
            OleDbCommand dbCommand = new OleDbCommand(query, myConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса");
            else
                MessageBox.Show("Данные удалены");
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.ForeColor = Color.White;
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void retrBtn_MouseEnter(object sender, EventArgs e)
        {
            retrBtn.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void retrBtn_MouseLeave(object sender, EventArgs e)
        {
            retrBtn.ForeColor = Color.White;
        }

        private void deleteBtn_MouseEnter(object sender, EventArgs e)
        {
            deleteBtn.ForeColor = Color.FromArgb(255, 0, 43);
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteBtn.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[11].DataPropertyName + ", System.String) like '%" + textBox1.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
