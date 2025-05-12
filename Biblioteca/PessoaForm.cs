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

namespace Biblioteca
{
    public partial class PessoaForm : Form
    {
        public PessoaForm()
        {
            InitializeComponent();
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
    }
}
