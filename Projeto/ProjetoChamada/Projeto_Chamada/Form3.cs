using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Chamada
{
    public partial class Form3 : Form
    {
        MySqlConnection con;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("server=143.106.241.3;port=3306;User ID=cl200475; database=cl200475; password=cl*20092002; SslMode=none;");
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Palestras(diaPalestra, horaPalestra, tituloPalestra, nomePalestrante) values('" + textBox1.Text.ToString() + "', '" + comboBox1.SelectedItem.ToString() + "', '" + textBox2.Text + "','" + textBox3.Text + "')", con);
                insere.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                MessageBox.Show("Gravação realizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
