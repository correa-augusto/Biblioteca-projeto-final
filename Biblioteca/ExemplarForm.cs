using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.ClassEnum;
using System.Windows.Forms.VisualStyles;

//AUGUSTO DOS SANTOS CORRÊA
namespace Biblioteca
{
    public partial class ExemplarForm : Form
    {
        List<Exemplar> exemplares;
        public ExemplarForm(List<Exemplar> exemplares)
        {
            InitializeComponent();
            this.exemplares = exemplares;
        }

        private void LabelEscritor_Click(object sender, EventArgs e)
        {

        }

        private void ExemplarForm_Load(object sender, EventArgs e)
        {
            // carrega os valores do Enum para o combobox status
            ComboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            ComboBoxStatus.SelectedIndex = 0;

            // carrega os valores do Enum para o combobox tipo do exemplar generico
            ListBoxGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            ListBoxGenerico.SelectedIndex = 0;
        }

        private void LabekTamanho_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxEbook_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumericNumPaginas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxTitulo = TextBoxTitulo.Text;
            string auxSubTitulo = TextBoxSubtitulo.Text;
            string auxEscritor = TextBoxEscritor.Text;
            string auxEditora = TextBoxEditora.Text;
            int auxAnoPublicacao = Convert.ToInt32(NumericUpDownAno.Value);
            string auxGenero = ComboBoxGenero.Text;
            int auxStatus = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), ComboBoxStatus.Text);

            if (tabControlExemplar.SelectedIndex == 0)
            {
                // livro e ebook
                // leitura dos valores dos campos
                int auxPaginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                string auxTipoCapa = ComboBoxCapa.Text;
                string auxIsbn = TextBoxIsbn.Text;
                if (!CheckBoxEbook.Checked)
                {
                    // livro
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Livro(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn));
                }
                else
                {
                    // ebook
                    // leitura dos valores dos campos
                    string auxFormato = ComboBoxFormato.Text;
                    decimal auxTamanho = NumericTam.Value;
                    string auxUrl = TextBoxUrl.Text;
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Ebook(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus,  auxFormato, auxTamanho, auxUrl));
                }
            }
            else if (tabControlExemplar.SelectedIndex == 1)
            {
                // revista
                // leitura dos valores dos campos
                int auxEdicaoRevista = Convert.ToInt32(NumericEdicao.Value);
                int auxPaginasRevista = Convert.ToInt32(NumericNumPaginas.Value);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Revista(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoRevista, auxPaginasRevista));
            }
            else if (tabControlExemplar.SelectedIndex == 2)
            {
                // hq
                // leitura dos valores dos campos
                int auxEdicaoHq = Convert.ToInt32(NumericNumEdicao.Value);
                string auxIlustrador = TextBoxIlustrador.Text;
                // cria o objeto e já adiciona no List
                exemplares.Add(new Hq(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoHq, auxIlustrador));
            }
            else if (tabControlExemplar.SelectedIndex == 3)
            {
                // generico
                // leitura dos valores dos campos
                int auxTipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), ListBoxGenerico.Text);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Generico(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxTipo));
            }
            MessageBox.Show("Exemplar cadastrado com sucesso!");
            Close();
        }
    }
}
