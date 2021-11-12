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
    public partial class Form2 : Form
    {
        MySqlConnection con;
        int status = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("server=143.106.241.3;port=3306;User ID=cl200475; database=cl200475; password=cl*20092002; SslMode=none;");
                con.Open();
                MessageBox.Show("Conectado");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Falha na Conexão");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("server=143.106.241.3;port=3306;User ID=cl200475; database=cl200475; password=cl*20092002; SslMode=none;");
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Alunos(idAlunos, nomeAlunos, turmaAlunos, fotoAlunos,email,status) values(" + textBox1.Text + ", '" +textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "',@foto, '" + textBox4.Text + "',"+status+")", con);
                insere.Parameters.AddWithValue("foto", ConverterFotoParaByteArray());
                insere.ExecuteNonQuery();
                MessageBox.Show("Gravação realizada com sucesso");
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                comboBox1.Text = "";
                pictureBox1.Image = null;
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

        //converter foto 
        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir foto";
            dialog.Filter = "JPG (*.jpg) |* .jpg" + "| All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a foto: " + ex.Message);
                }
            }
            dialog.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
