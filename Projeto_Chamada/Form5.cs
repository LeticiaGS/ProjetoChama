using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Chamada
{
    public partial class Form5 : Form
    {
        MySqlConnection con;
        public Form5(int i)
        {
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server=143.106.241.3;port=3306;User ID=cl200475; database=cl200475; password=cl*20092002; SslMode=none;");
            }
            catch
            {
                MessageBox.Show("Falha na Conexão");
            }
            this.WindowState = FormWindowState.Maximized;
            if (i == 0) //Atuallizar
                button2.Visible = true;
            else //Excluir
                button1.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_ra = new MySqlCommand("Update Alunos set status = 1 where idAlunos =" + textBox1.Text, con);
                busca_ra.ExecuteNonQuery();

                MessageBox.Show("Aluno inativado!");

                textBox1.Clear();
                textBox2.Clear();
                label2.Text = "Aluno";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            finally 
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //deslocamento de bytes em relação ao parâmetro origin
                //redefine a posição do fluxo para a gravação
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                //Lê um bloco de bytes e grava os dados em um buffer (stream)
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand atualiza_nome = new MySqlCommand("Update Alunos set nomeAlunos = '" + textBox2.Text + "', " +
                    "email = '" + textBox3.Text + "', fotoAlunos = @foto where idAlunos=" + textBox1.Text, con);
                atualiza_nome.Parameters.AddWithValue("foto", ConverterFotoParaByteArray());
                atualiza_nome.ExecuteNonQuery();
                MessageBox.Show("Atualização efetuada");
                textBox1.Clear();
                textBox2.Clear();
                label2.Text = "Aluno";
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                groupBox2.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }
            dialog.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    con.Open();
                    MySqlCommand busca_ra = new MySqlCommand("Select nomeAlunos, idAlunos, email, fotoAlunos " +
                        "from Alunos where idAlunos=" + textBox1.Text, con);
                    MySqlDataReader resultado = busca_ra.ExecuteReader();
                   
                    if (resultado.Read())
                    {
                        label2.Text = resultado["nomeAlunos"].ToString();
                        textBox2.Text = resultado["nomeAlunos"].ToString();
                        textBox3.Text = resultado["email"].ToString();
                        try
                        {
                            string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                            byte[] bimage = (byte[])resultado["fotoAlunos"];
                            FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                            fs.Write(bimage, 0, bimage.Length - 1);
                            fs.Close();
                            pictureBox1.Image = Image.FromFile(imagem);

                            resultado.Close();
                        }
                        catch
                        {
                            pictureBox1.Image = Image.FromFile("negado.png");

                        }
                    }//if
                }//try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }//if key
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

