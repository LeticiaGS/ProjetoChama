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
    public partial class Form4 : Form
    {
        int idPalestra, ra;
        MySqlConnection con;
        public Form4()
        {
            InitializeComponent();
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
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select tituloPalestra from Palestras ", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                while (resultado.Read())
                {
                    comboBox1.Items.Add(resultado["tituloPalestra"].ToString());
                }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    con.Open();
                    MySqlCommand busca_ra = new MySqlCommand("Select nomeAlunos, raAlunos, fotoAlunos, idAlunos from Alunos" +
                        " where idAlunos=" + textBox1.Text + " or raAlunos=" + textBox1.Text, con);
                    MySqlDataReader resultado = busca_ra.ExecuteReader();

                    if (resultado.Read())
                    {
                        label3.Text = resultado["nomeAlunos"].ToString();
                        ra = Convert.ToInt32(resultado["raAlunos"].ToString());
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
                        //inserção
                        con.Close();
                        try
                        {
                            con.Open();
                            MySqlCommand insere = new MySqlCommand("insert into Presenca (RA, idPalestra, Hora) values (" + ra + "," + idPalestra + ",'" + DateTime.Now.ToShortTimeString() + "')", con);
                            insere.ExecuteNonQuery();
                            MessageBox.Show("Registrado");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            con.Close();
                            textBox1.Clear();
                            textBox1.Focus();
                            pictureBox1.Image = null;
                            label3.Text = "Aluno";
                        }
                    }//if
                    //exercício Aula Atualizar/Excluir
                    else
                    {
                        DialogResult resul = MessageBox.Show("Deseja cadastrar o Aluno?", "ATENÇÃO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resul == DialogResult.Yes)
                        {
                            if (Application.OpenForms.OfType<Form2>().Count() == 0)
                            {
                                Form2 filho2 = new Form2();
                                filho2.MdiParent = this.MdiParent; //abrir form neto 
                                filho2.Show();
                            }
                        }//else
                    }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select tituloPalestra,idPalestras from Palestras where tituloPalestra='"+ comboBox1.SelectedItem.ToString()+"'", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                if (resultado.Read())
                {
                    idPalestra = Convert.ToInt32(resultado["idPalestras"].ToString());
                    MessageBox.Show(idPalestra.ToString());
                }
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
    }
}
