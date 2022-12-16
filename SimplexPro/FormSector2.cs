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
    public partial class FormSector2 : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Недвижимость.mdb";
        private OleDbConnection myConnection;
        public FormSector2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void FormSector2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "недвижимостьDataSet.Участки". При необходимости она может быть перемещена или удалена.
            this.участкиTableAdapter.Fill(this.недвижимостьDataSet.Участки);
          
        }

        private void FormSector2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[6].DataPropertyName + ", System.String) like '%" + textBox1.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

       
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            участкиBindingSource.Filter = "[Район] LIKE'" + textBox2.Text + "%'";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            участкиBindingSource.Filter = "[Адрес] LIKE'" + textBox3.Text + "%'";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            участкиBindingSource.Filter = "[Категория] LIKE'" + textBox4.Text + "%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
