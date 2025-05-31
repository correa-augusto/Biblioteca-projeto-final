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

//AUGUSTO DOS SANTOS CORRÊA
namespace Biblioteca
{
    public partial class BibliotecaForm : Form
    {
        public List<Funcionario> funcionarios;
        public List<Leitor> leitores;
        public List<Exemplar> exemplares;
        public BibliotecaForm()
        {
            InitializeComponent();

            funcionarios = new List<Funcionario>();
            leitores = new List<Leitor>();
            exemplares = new List<Exemplar>();

            CargaInicial();
        }

        private void CargaInicial()
        {
            leitores.Add(new Leitor("leitor 1", DateTime.Today, "cpf1", "email1", "tel1", "tipo1"));
            leitores.Add(new Leitor("leitor 2", DateTime.Today, "cpf2", "email2", "tel2", "tipo2"));
            leitores.Add(new Leitor("leitor 3", DateTime.Today, "cpf3", "email3", "tel3", "tipo3"));
            leitores.Add(new Leitor("leitor 4", DateTime.Today, "cpf3", "email4", "tel4", "tipo4"));
            leitores.Add(new Leitor("leitor 5", DateTime.Today, "cpf3", "email5", "tel5", "tipo5"));
            funcionarios.Add(new Funcionario("funcionário 1", DateTime.Today, "cpf1", "email1", "tel1", 0, "fun1", 9999.99m, 8));
            funcionarios.Add(new Funcionario("funcionário 2", DateTime.Today, "cpf2", "email2", "tel2", 1, "fun2", 3333.33m, 8));
            funcionarios.Add(new Funcionario("funcionário 3", DateTime.Today, "cpf3", "email3", "tel3", 2, "fun3", 1024.00m, 6));
            funcionarios.Add(new Funcionario("funcionário 4", DateTime.Today, "cpf4", "email4", "tel4", 3, "fun4", 1024.00m, 6));
            exemplares.Add(new Livro("livro 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 100, "tipoCapa1", "isbn1"));
            exemplares.Add(new Livro("livro 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 112, "tipoCapa2", "isbn2"));
            exemplares.Add(new Livro("livro 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 132, "tipoCapa3", "isbn3"));
            exemplares.Add(new Livro("livro 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 234, "tipoCapa4", "isbn4"));
            exemplares.Add(new Livro("livro 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 432, "tipoCapa5", "isbn5"));
            exemplares.Add(new Ebook("ebook 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, "formato1", 1, "url1", 100));
            exemplares.Add(new Ebook("ebook 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, "formato2", 1, "url2", 100));
            exemplares.Add(new Ebook("ebook 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, "formato3", 1, "url3", 100));
            exemplares.Add(new Ebook("ebook 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, "formato4", 1, "url4", 100));
            exemplares.Add(new Ebook("ebook 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, "formato5", 1, "url5", 100));
            exemplares.Add(new Revista("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 324, 1));
            exemplares.Add(new Revista("revista 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 123, 1));
            exemplares.Add(new Revista("revista 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 654, 1));
            exemplares.Add(new Revista("revista 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 764, 1));
            exemplares.Add(new Revista("revista 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 234, 1));
            exemplares.Add(new Hq("hq 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 432, "ilustrador1"));
            exemplares.Add(new Hq("hq 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 542, "ilustrador2"));
            exemplares.Add(new Hq("hq 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 298, "ilustrador3"));
            exemplares.Add(new Hq("hq 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 342, "ilustrador4"));
            exemplares.Add(new Hq("hq 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 98, "ilustrador5"));
            exemplares.Add(new Generico("genérico 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 0));
            exemplares.Add(new Generico("genérico 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 1));
            exemplares.Add(new Generico("genérico 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 2));
            exemplares.Add(new Generico("genérico 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 3));
            exemplares.Add(new Generico("genérico 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 4));
        }

        private void AtualizarDataGridView()
        {
            // listar funcionarios no datagridview
            DataViewFuncionario.DataSource = null;
            DataViewFuncionario.DataSource = funcionarios;
            // listar leitores no datagridview
            DataViewLeitores.DataSource = null;
            DataViewLeitores.DataSource = leitores;
            // listar exemplares no datagridview
            DataViewExemplares.DataSource = null;
            DataViewExemplares.DataSource = exemplares;
        }

        private void ButtonPessoa_Click(object sender, EventArgs e)
        {
            var aux = new PessoaForm(funcionarios, leitores);
            aux.StartPosition = FormStartPosition.CenterParent;
            aux.ShowDialog();
        }

        private void ButtonExemplar_Click(object sender, EventArgs e)
        {
            var aux = new ExemplarForm(exemplares);
            aux.StartPosition = FormStartPosition.CenterParent;
            aux.ShowDialog();
        }

        private void BibliotecaForm_Load(object sender, EventArgs e)
        {

        }

        private void FormBiblioteca_Activated(object sender, EventArgs e)
        {
            // esse evento é chamado sempre que o form volta a ficar ativo
            // quando o form é aberto ou quando ele volta a ficar ativo
            // também após fechar uma tela modal
            // atualiza a tela
            AtualizarDataGridView();
        }

        private void DataViewFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DataViewFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == DataViewFuncionario.NewRowIndex || e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                return;
            string columnName = DataViewFuncionario.Columns[e.ColumnIndex].Name.ToLower();
            string? valueStr = e.Value.ToString();
            switch (columnName)
            {
                case "cargo":
                    if (int.TryParse(valueStr, out int cargo))
                        e.Value = ((EnumFuncionarioCargo)cargo).GetDescription();
                    break;
                case "cpf":
                    if (valueStr!.Length == 11 && long.TryParse(valueStr, out long cpf))
                        e.Value = string.Format(@"{0:000\.000\.000\-00}", cpf);
                    break;
                case "telefone":
                    if (valueStr!.Length == 9 && long.TryParse(valueStr, out long telefone))
                        e.Value = string.Format(@"{0:(00) 00000\-0000}", telefone);
                    break;
                case "salario":
                    if (double.TryParse(valueStr, out double salario))
                        e.Value = salario.ToString("N2");
                    break;

            }
        }

        private void DataViewFuncionario_DoubleClick(object sender, EventArgs e)
        {
            var funcionario = DataViewFuncionario.CurrentRow.DataBoundItem as Funcionario;

            if (funcionario == null)
            {
                MessageBox.Show("Selecione um funcionário");
                return;
            }

            //MessageBox.Show($"{funcionario.GetType().Name}, {funcionario.Nome}");

            // abre a tela de edição de funcionário com o objeto selecionado
            var form = new PessoaForm(funcionarios, funcionario);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void DataViewLeitores_DoubleClick(object sender, EventArgs e)
        {
            // armazena o objeto selecionado
            var leitor = DataViewLeitores.CurrentRow.DataBoundItem as Leitor;
            // validar se o objeto é nulo
            if (leitor == null)
            {
                MessageBox.Show("Selecione um funcionário");
                return;
            }
            //MessageBox.Show($"{leitor.GetType().Name}, {leitor.Nome}");

            var form = new PessoaForm(leitores, leitor);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void DataViewExemplares_DoubleClick(object sender, EventArgs e)
        {
           
            var exemplar = DataViewExemplares.CurrentRow.DataBoundItem as Exemplar;
           
            if (exemplar == null)
            {
                MessageBox.Show("Selecione um exemplar");
                return;
            }

            //MessageBox.Show($"{exemplar.GetType().Name}, {exemplar.Titulo}");

            var form = new ExemplarForm(exemplares, exemplar);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
