using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.ClassEnum;

//Augusto dos santos correa
namespace Biblioteca
{
    public partial class PessoaForm : Form
    {
        List<Funcionario> funcionarios;
        List<Leitor> leitores;
        Funcionario funcionario;
        Leitor leitor;

        private bool edicaoFuncionario = false;
        private bool edicaoLeitor = false;
        public PessoaForm(List<Funcionario> funcionarios, List<Leitor> leitores)
        {
            InitializeComponent();

            this.funcionarios = funcionarios;
            this.leitores = leitores;

            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;   
        }

        public PessoaForm(List<Funcionario> funcionarios, Funcionario funcionario)
        {
            InitializeComponent();
            edicaoFuncionario = true;
            // atribui o objeto recebido à variável com escopo de classe
            this.funcionario = funcionario;
            this.funcionarios = funcionarios;

            // carrega os valores do Enum para o combobox
            ComboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            ComboBoxCargo.SelectedIndex = 0;

            // carrega os valores do objeto recebido
            TextBoxNome.Text = funcionario.Nome;
            DateTimePickerNasc.Value = funcionario.Nascimento;
            MaskedCpf.Text = funcionario.Cpf;
            TextBoxEmail.Text = funcionario.Email;
            MaskedTelefone.Text = funcionario.Telefone;
            ComboBoxCargo.Text = "" + (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), funcionario.Cargo.ToString());
            NumericSalario.Value = funcionario.Salario;
            NumericCarga.Value = funcionario.CargaHoraria;
            TextBoxFuncao.Text = funcionario.Funcao;
            PessoaTab.SelectedIndex = 1;
            PessoaTab.TabPages[0].Enabled = false;
            ButtonSalvar.Enabled = false;
        }

        public PessoaForm(List<Leitor> leitores, Leitor leitor)
        {
            InitializeComponent();
            edicaoLeitor = true;

            this.leitor = leitor;
            this.leitores = leitores;

            TextBoxNome.Text = leitor.Nome;
            TextBoxNome.Text = leitor.Nome;
            DateTimePickerNasc.Value = leitor.Nascimento;
            MaskedCpf.Text = leitor.Cpf;
            TextBoxEmail.Text = leitor.Email;
            MaskedTelefone.Text = leitor.Telefone;
            ListBoxTipoLeitor.SelectedItem = leitor.Tipo;
        }

        private void PessoaForm_Load(object sender, EventArgs e)
        {
            // carrega os valores do Enum para o combobox/Listbox
            ComboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            ComboBoxCargo.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ListBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelCargo_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxNome = TextBoxNome.Text;
            DateTime auxData = DateTimePickerNasc.Value;
            string auxCpf = MaskedCpf.Text;
            string auxEmail = TextBoxEmail.Text;
            string auxTelefone = MaskedTelefone.Text;
            int idade = DateTime.Today.Year - auxData.Year;

            if(string.IsNullOrWhiteSpace(auxNome))
            {
                MessageBox.Show("O campo Nome é obrigatório.");
                return;
            }
            else if(auxData > DateTime.Today)
            {
                MessageBox.Show("A data de nascimento não pode ser futura ao dia de hoje.");
                return;
            }
            else if(idade < 5)
            {
                MessageBox.Show("A idade deve ser superior a 5");
                return;
            }
            else if(funcionarios.Any(f => f.Cpf == auxCpf) || leitores.Any(l => l.Cpf == auxCpf))
            {
                MessageBox.Show("CPF ja foi cadastrado");
                return;
            } 
            else if (string.IsNullOrWhiteSpace(auxCpf))
            {
                MessageBox.Show("O campo CPF É obrigatório.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(auxEmail))
            {
                MessageBox.Show("O campo Rmail é obrigatório.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(auxTelefone))
            {
                MessageBox.Show("O campo Telefone é obrigatório.");
                return;
            }

            if (PessoaTab.SelectedIndex == 0)
            {
                // leitura dos valores dos campos
                string auxTipoLeitor = ListBoxTipoLeitor.SelectedItem.ToString();
                // cria o objeto leitor
                var leitor = new Leitor(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxTipoLeitor);
                // adicionar no list
                leitores.Add(leitor);
            }
            else
            {
                // leitura dos valores dos campos
                int auxCargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), ComboBoxCargo.Text);
                decimal auxSalario = NumericSalario.Value;
                int auxCargaHoraria = Convert.ToInt32(NumericCarga.Value);
                string auxFuncao = TextBoxFuncao.Text;
                // cria o objeto funcionário e já adiciona diretamente
                var funcionario = new Funcionario(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxCargo, auxFuncao, auxSalario, auxCargaHoraria);
                funcionarios.Add(funcionario);
            }
            MessageBox.Show("Pessoa cadastrada com sucesso!");
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (PessoaTab.SelectedIndex == 0)
            {
                // atualiza os dados no objeto
                leitor.Nome = TextBoxNome.Text;
                leitor.Nascimento = DateTimePickerNasc.Value;
                leitor.Cpf = MaskedCpf.Text;
                leitor.Email = TextBoxEmail.Text;
                leitor.Telefone = MaskedTelefone.Text;
                leitor.Tipo = ListBoxTipoLeitor.SelectedItem.ToString();
            }
            else
            {
                // atualiza os dados no objeto
                funcionario.Nome = TextBoxNome.Text;
                funcionario.Nascimento = DateTimePickerNasc.Value;
                funcionario.Cpf = MaskedCpf.Text;
                funcionario.Email = TextBoxEmail.Text;
                funcionario.Telefone = MaskedTelefone.Text;
                funcionario.Cargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), ComboBoxCargo.Text);
                funcionario.Salario = NumericSalario.Value;
                funcionario.CargaHoraria = Convert.ToInt32(NumericCarga.Value);
                funcionario.Funcao = TextBoxFuncao.Text;
            }
            MessageBox.Show("Pessoa editada com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (PessoaTab.SelectedIndex == 0)
            {
                // exclui o objeto
                leitores.Remove(leitor);
            }
            else
            {
                // exclui o objeto
                funcionarios.Remove(funcionario);
            }
            MessageBox.Show("Pessoa excluída com sucesso!");
            Close();
        }

        private void PessoaTab_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void PessoaTab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (edicaoFuncionario && e.TabPage != TabFuncionario)
            {
                e.Cancel = true;
            }
            else if (edicaoLeitor && e.TabPage != TabLeitor)
            {
                e.Cancel = true;
            }
        }
    }
}
