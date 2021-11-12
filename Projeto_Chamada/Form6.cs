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
    public partial class Form6 : Form
    {
        MySqlConnection con;
        private int idPalestra;
        private string diaPalestra =  "";
        private string horaPalestra = "";
        MySqlDataAdapter mySqlDataAdapter;

        public Form6()
        {
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server=143.106.241.3;port=3306;User ID=cl200475; database=cl200475; password=cl*20092002; SslMode=none;");
            }
            catch (Exception e)
            {
                //MessageBox.Show("Falha na Conexão");
                MessageBox.Show(e.ToString());
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select tituloPalestra from Palestras", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                while (resultado.Read())
                {
                    cmbPalestra.Items.Add(resultado["tituloPalestra"].ToString());
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

        private void cmbPalestra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select * from Palestras where " +
                    "tituloPalestra='" + cmbPalestra.SelectedItem.ToString() + "'", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                if (resultado.Read())
                {
                    idPalestra = Convert.ToInt32(resultado["idPalestras"].ToString());
                    diaPalestra = resultado["diaPalestra"].ToString();
                    horaPalestra = resultado["horaPalestra"].ToString();
                    //MessageBox.Show(idPalestra.ToString());
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                mySqlDataAdapter = new MySqlDataAdapter("SELECT idAlunos, nomeAlunos " +
                    "FROM Alunos al, Presenca pr, Palestras pa WHERE al.idAlunos = pr.RA " +
                    "AND pr.idPresenca = pa.idPalestras AND al.turmaAlunos = " +
                    "'" + cmbTurma.SelectedItem.ToString() + "' AND " +
                    "pa.idPalestras = " + idPalestra + "order by nomeAlunos", con);
                DataSet DS = new DataSet(); //objeto na memória para armazenar tabelas
                mySqlDataAdapter.Fill(DS); //objeto para preencher o DataSet
                dataGridView1.DataSource = DS.Tables[0];
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
