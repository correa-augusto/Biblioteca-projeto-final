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

namespace Biblioteca
{
    public partial class ExemplarForm : Form
    {
        public ExemplarForm()
        {
            InitializeComponent();
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
    }
}
