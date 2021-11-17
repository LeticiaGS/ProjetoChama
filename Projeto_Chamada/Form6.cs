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
                mySqlDataAdapter = new MySqlDataAdapter("SELECT idAlunos, nomeAlunos FROM Alunos al, Presenca pr, Palestras pa WHERE al.idAlunos = pr.RA AND pr.idPalestra = pa.idPalestras AND al.turmaAlunos = " +
                    "'" + cmbTurma.SelectedItem.ToString() + "' AND pa.idPalestras = " + idPalestra + " order by nomeAlunos", con);
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

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(3, 2, 3, 2);//estipulando o espaçamento das margens que queremos
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Directory.GetCurrentDirectory() + "\                              \"+ comboBox1.SelectedItem.ToString() + " - " + comboBox2.SelectedItem.ToString()+".pdf",                                       FileMode.Create));
            doc.Open();

            iTextSharp.text.Font fonte = FontFactory.GetFont("TIMES_ROMAN", 10f, BaseColor.BLACK);

            String dados = "";

            Paragraph paragrafo = new Paragraph(dados, fonte);
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(comboBox1.SelectedItem.ToString());
            doc.Add(paragrafo);

            Paragraph paragrafo1 = new Paragraph(dados, fonte);
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add(comboBox2.SelectedItem.ToString());
            doc.Add(paragrafo1);

            Paragraph paragrafo2 = new Paragraph(dados, fonte);
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add(diaPalestra);
            doc.Add(paragrafo2);

            Paragraph paragrafo3 = new Paragraph(dados, fonte);
            paragrafo3.Alignment = Element.ALIGN_CENTER;
            paragrafo3.Add(horaPalestra);
            doc.Add(paragrafo3);

            Paragraph paragrafo4 = new Paragraph(dados, fonte);
            paragrafo4.Alignment = Element.ALIGN_CENTER;
            paragrafo4.Add("\n");
            doc.Add(paragrafo4);

            PdfPTable tabela = new PdfPTable(2);
            float[] anchoDeColumnas = new float[] { 10f, 80f };
            tabela.SetWidths(anchoDeColumnas);

            Paragraph coluna1 = new Paragraph("RA", fonte);
            Paragraph coluna2 = new Paragraph("Nome", fonte);

            var celula1 = new PdfPCell();
            var celula2 = new PdfPCell();

            celula1.AddElement(coluna1);
            celula2.AddElement(coluna2);

            tabela.AddCell(celula1);
            tabela.AddCell(celula2);

            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Index < dataGridView1.RowCount - 1)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        Phrase dado = new Phrase(cell.Value.ToString());
                        var cel1 = new PdfPCell(dado);
                        tabela.AddCell(cel1);
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo gerado");
                }
            }

            doc.Add(tabela);
            doc.Close();
    }
    }
}
