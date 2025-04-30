using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        private Leitor origem;
        private Leitor destino;
        private Exemplar item;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;

        public Leitor Origem
        {
            get => origem;
            set => origem = value ?? throw new Exception("Leitor de origem deve ser informado.");
        }

        public Leitor Destino
        {
            get => destino;
            set => destino = value ?? throw new Exception("Leitor de destino deve ser informado.");
        }

        public Exemplar Item
        {
            get => item;
            set => item = value ?? throw new Exception("Item do empréstimo deve ser informado.");
        }

        public DateTime DataEmprestimo
        {
            get => dataEmprestimo;
            set
            {
                if (value == default)
                    throw new Exception("Data do empréstimo deve ser válida.");
                dataEmprestimo = value;
            }
        }

        public DateTime DataDevolucao
        {
            get => dataDevolucao;
            set
            {
                if (value == default || value < dataEmprestimo)
                    throw new Exception("Data de devolução deve ser válida e posterior à data de empréstimo.");
                dataDevolucao = value;
            }
        }

        // Construtor
        public Emprestimo(Leitor origem, Leitor destino, Exemplar item, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            Origem = origem;
            Destino = destino;
            Item = item;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }

        // ToString
        public override string ToString()
        {
            return $"Origem: {Origem.Nome}\nDestino: {Destino.Nome}\nItem: {Item.ToString()}\nData do Empréstimo: {DataEmprestimo:dd/MM/yyyy}\nData de Devolução: {DataDevolucao:dd/MM/yyyy}";
        }
    }
}