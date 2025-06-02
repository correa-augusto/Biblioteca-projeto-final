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
        Exemplar exemplar;

        private bool edicaoLivro = false;
        private bool edicaoEbook = false;
        private bool edicaoRevista = false;
        private bool edicaoHq = false;
        private bool edicaoGenerico = false;
        public ExemplarForm(List<Exemplar> exemplares)
        {
            InitializeComponent();
            this.exemplares = exemplares;
        }

        // sobrecarga de construtor, novo construtor com lista de parâmetros diferente
        public ExemplarForm(List<Exemplar> exemplares, Exemplar exemplar)
        {
            InitializeComponent();
            // atribui a lista de exemplares recebida à variável com escopo de classe
            this.exemplares = exemplares;
            this.exemplar = exemplar;
            GroupBoxEbook.Enabled = false;

            // carrega os valores do Enum para o combobox/listbox
            ComboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            ComboBoxStatus.SelectedIndex = 0;
            ListBoxGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            ListBoxGenerico.SelectedIndex = 0;


            Livro livro = exemplar as Livro;
            if (livro != null)
            {
                edicaoLivro = true;
                TextBoxTitulo.Text = exemplar.Titulo;
                TextBoxSubtitulo.Text = exemplar.Subtitulo;
                TextBoxEscritor.Text = exemplar.Escritor;
                TextBoxEditora.Text = exemplar.Editora;
                NumericUpDownAno.Value = exemplar.AnoPublicacao;
                ComboBoxGenero.Text = exemplar.Genero;
                ComboBoxStatus.Text = "" + (EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), exemplar.Status.ToString());
                ComboBoxCapa.Text = ((Livro)exemplar).TipoCapa;
                TextBoxIsbn.Text = ((Livro)exemplar).Isbn;
                numericUpDownPaginasLivro.Value = livro.Pagninas;
                ComboBoxCapa.Text = livro.TipoCapa;
                TextBoxIsbn.Text = livro.Isbn;
                CheckBoxEbook.Checked = false;
            }

            Ebook ebook = exemplar as Ebook;
            if (ebook != null)
            {
              
                edicaoEbook = true;
                TextBoxTitulo.Text = exemplar.Titulo;
                TextBoxSubtitulo.Text = exemplar.Subtitulo;
                TextBoxEscritor.Text = exemplar.Escritor;
                TextBoxEditora.Text = exemplar.Editora;
                NumericUpDownAno.Value = exemplar.AnoPublicacao;
                ComboBoxGenero.Text = exemplar.Genero;
                ComboBoxStatus.Text = "" + (EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), exemplar.Status.ToString());
                CheckBoxEbook.Checked = true;
                ComboBoxFormato.Text = ((Ebook)exemplar).Formato;
                NumericTam.Value = ((Ebook)exemplar).Tamanho;
                TextBoxUrl.Text = ((Ebook)exemplar).Url;
                numericUpDownPaginasLivro.Value = ((Ebook)exemplar).Pagninas;
            }
            else if (exemplar is Revista revista)
            {
                edicaoRevista = true;
                NumericEdicao.Value = revista.Edicao;
                NumericNumPaginas.Value = revista.Paginas;
            }
            else if (exemplar is Hq hq)
            {
                edicaoHq = true;
                NumericNumEdicao.Value = hq.Edicao;
                TextBoxIlustrador.Text = hq.Ilustrador;
            }
            else if (exemplar is Generico)
            {
                edicaoGenerico = true;
                ListBoxGenerico.Text = "" + (EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), ((Generico)exemplar).Tipo.ToString());
            }
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

            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
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

            if (string.IsNullOrWhiteSpace(auxTitulo))
            {
                MessageBox.Show("Titulo deve ser preenchido");
                return;
            }
            else if(exemplares.Any(e => e.Titulo == auxTitulo))
            {
                MessageBox.Show("Ja existe um exemplar com esse titulo");
                return;
            }
            else if (string.IsNullOrWhiteSpace(auxSubTitulo))
            {
                MessageBox.Show("Subtitulo deve ser preenchido");
                return;
            }
            else if (string.IsNullOrWhiteSpace(auxEscritor))
            {
                MessageBox.Show("Escritor deve ser informado");
                return;
            }
            else if (string.IsNullOrWhiteSpace(auxEditora))
            {
                MessageBox.Show("editora deve ser preenchida");
                return;
            }
            else if (auxAnoPublicacao > DateTime.Today.Year)
            {
                MessageBox.Show("A data de publicação não pode ser futura ao ano atual.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(auxGenero))
            {
                MessageBox.Show("Genero deve ser informado.");
                return;
            }
     
            if (tabControlExemplar.SelectedIndex == 0)
            {
                // livro e ebook
                // leitura dos valores dos campos
                int auxPaginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                string auxTipoCapa = ComboBoxCapa.Text;
                string auxIsbn = TextBoxIsbn.Text;

                if(string.IsNullOrWhiteSpace(auxTipoCapa))
                {
                    MessageBox.Show("Tipo da capa deve ser informado");
                    return;
                }
                else if(auxPaginas <= 20)
                {
                    MessageBox.Show("Deve ter mais de 20 paginas");
                    return;
                }
                else if(string.IsNullOrWhiteSpace(auxIsbn))
                {
                    MessageBox.Show("ISBN deve ser informado");
                    return;
                }
           


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
                    decimal auxTamanho = Convert.ToInt32(NumericTam.Value);
                    string auxUrl = TextBoxUrl.Text;
                    int AuxPaginas = (int)numericUpDownPaginasLivro.Value;

                    if (string.IsNullOrWhiteSpace(auxFormato))
                    {
                        MessageBox.Show("Formato deve ser preenchido");
                        return;
                    }
                    else if (auxTamanho < 0)
                    {
                        MessageBox.Show("Tamanho deve ser maior que 0");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(auxUrl))
                    {
                        MessageBox.Show("URL deve ser preenchida");
                        return;
                    }

                    exemplares.Add(new Ebook(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxFormato, auxTamanho, auxUrl, AuxPaginas));
                }
            }
            else if (tabControlExemplar.SelectedIndex == 1)
            {
                // revista
                // leitura dos valores dos campos
                int auxEdicaoRevista = Convert.ToInt32(NumericEdicao.Value);
                int auxPaginasRevista = Convert.ToInt32(NumericNumPaginas.Value);

                if(auxEdicaoRevista < 0)
                {
                    MessageBox.Show("Edição da revista deve ser maior que 0");
                    return;
                }
                else if(auxPaginasRevista < 0)
                {
                    MessageBox.Show("Revista deve ter mais de uma página");
                    return;
                }
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Revista(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoRevista, auxPaginasRevista));
            }
            else if (tabControlExemplar.SelectedIndex == 2)
            {
                // hq
                // leitura dos valores dos campos
                int auxEdicaoHq = Convert.ToInt32(NumericNumEdicao.Value);
                string auxIlustrador = TextBoxIlustrador.Text;

                if(auxEdicaoHq < 0)
                {
                    MessageBox.Show("Edição deve ser maior que 0");
                }
                else if(string.IsNullOrWhiteSpace(auxIlustrador))
                {
                    MessageBox.Show("Campo Ilustrador deve ser preenchido");
                    return;
                }
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Hq(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoHq, auxIlustrador));
            }
            else if (tabControlExemplar.SelectedIndex == 3)
            {
                // generico
                // leitura dos valores dos campos
                int auxTipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), ListBoxGenerico.Text);

                if(auxTipo < 0)
                {
                    MessageBox.Show("Tipo deve ser preenchido");
                    return;
                }
                // cria o objeto e já adiciona no List
                exemplares.Add(new Generico(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxTipo));
            }
            MessageBox.Show("Exemplar cadastrado com sucesso!");
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            exemplar.Titulo = TextBoxTitulo.Text;
            exemplar.Subtitulo = TextBoxSubtitulo.Text;
            exemplar.Escritor = TextBoxEscritor.Text;
            exemplar.Editora = TextBoxEditora.Text;
            exemplar.AnoPublicacao = Convert.ToInt32(NumericUpDownAno.Value);
            exemplar.Genero = ComboBoxGenero.Text;
            exemplar.Status = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), ComboBoxStatus.Text);
            if (exemplar is Livro livro)
            {
                livro.Pagninas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                livro.TipoCapa = ComboBoxCapa.Text;
                livro.Isbn = TextBoxIsbn.Text;
            }
            else if (exemplar is Ebook ebook)
            {
                ebook.Pagninas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                ebook.Formato = ComboBoxFormato.Text;
                ebook.Tamanho = NumericTam.Value;
                ebook.Url = TextBoxUrl.Text;
            }
            else if (exemplar is Revista revista)
            {
                revista.Edicao = Convert.ToInt32(NumericEdicao.Value);
                revista.Paginas = Convert.ToInt32(NumericNumPaginas.Value);
            }
            else if (exemplar is Hq hq)
            {
                hq.Edicao = Convert.ToInt32(NumericNumEdicao.Value);
                hq.Ilustrador = TextBoxIlustrador.Text;
            }
            else if (exemplar is Generico generico)
            {
                generico.Tipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), ListBoxGenerico.Text);
            }
            MessageBox.Show("Exemplar editado com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            exemplares.Remove(exemplar);
            MessageBox.Show("Exemplar excluido com sucesso!");
            Close();
        }

        private void GroupBoxExemplar_Enter(object sender, EventArgs e)
        {

        }

        private void tabControlExemplar_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (edicaoLivro && e.TabPage != TabLivro)
            {
                e.Cancel = true;
            }
            else if(edicaoEbook && e.TabPage != TabLivro)
            {
                e.Cancel = true;
            }
            else if (edicaoRevista && e.TabPage != TabRevista)
            {
                e.Cancel = true;
            }
            else if (edicaoHq && e.TabPage != TabHq)
            {
                e.Cancel = true;
            }
            else if (edicaoGenerico && e.TabPage != TabGenerico)
            {
                e.Cancel = true;
            }
        }
    }
}
