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

//Augusto dos santos correa
namespace Biblioteca
{
    public partial class PessoaForm : Form
    {
        List<Funcionario> funcionarios;
        List<Leitor> leitores;
        public PessoaForm(List<Funcionario> funcionarios, List<Leitor> leitores)
        {
            InitializeComponent();

            this.funcionarios = funcionarios;
            this.leitores = leitores;
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
    }
}
