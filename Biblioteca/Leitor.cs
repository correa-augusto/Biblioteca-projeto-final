using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Leitor : Pessoa
    {
        private List<Exemplar> exemplaresLeitor = new List<Exemplar>();
        private List<Emprestimo> emprestimosLeitor = new List<Emprestimo>();
        private string tipo;

        public List<Exemplar> ExemplaresLeitor
        {
            get => exemplaresLeitor;
            set => exemplaresLeitor = value ?? new List<Exemplar>();
        }

        public List<Emprestimo> EmprestimosLeitor
        {
            get => emprestimosLeitor;
            set => emprestimosLeitor = value ?? new List<Emprestimo>();
        }

        public string Tipo
        {
            get => tipo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Tipo deve ser informado.");
                tipo = value.Trim();
            }
        }

        // Construtor
        public Leitor(string nome, DateTime nascimento, string cpf, string email, string telefone, string tipo)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Tipo = tipo;
        }

        // Métodos de ação
        public bool EmprestaItem(Exemplar exemplar, Leitor destino)
        {
            if (!exemplaresLeitor.Contains(exemplar)) return false;
            destino.ExemplaresLeitor.Add(exemplar);
            exemplaresLeitor.Remove(exemplar);
            return true;
        }

        public bool DevolucaoItem(Exemplar exemplar, Leitor destino)
        {
            if (!destino.ExemplaresLeitor.Contains(exemplar)) return false;
            destino.ExemplaresLeitor.Remove(exemplar);
            exemplaresLeitor.Add(exemplar);
            return true;
        }

        public bool DoaExemplar(Exemplar exemplar, Leitor destino)
        {
            if (!exemplaresLeitor.Contains(exemplar)) return false;
            destino.ExemplaresLeitor.Add(exemplar);
            exemplaresLeitor.Remove(exemplar);
            return true;
        }

        public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem)
        {
            if (!this.exemplaresLeitor.Contains(exemplarVai) || !leitorVai.ExemplaresLeitor.Contains(exemplarVem))
                return false;

            this.exemplaresLeitor.Remove(exemplarVai);
            leitorVai.ExemplaresLeitor.Remove(exemplarVem);

            this.exemplaresLeitor.Add(exemplarVem);
            leitorVai.ExemplaresLeitor.Add(exemplarVai);

            return true;
        }

        // ToString
        public override string ToString()
        {
            return $"Nome: {Nome}\nNascimento: {Nascimento.ToShortDateString()}\nCPF: {Cpf}\nEmail: {Email}\nTelefone: {Telefone}\nTipo: {Tipo}\nExemplares: {ExemplaresLeitor.Count}\nEmpréstimos: {EmprestimosLeitor.Count}";
        }

        // Overrides de métodos abstratos
        public override void ListaLeitor(Leitor leitor)
        {
            Console.WriteLine(leitor.ToString());
        }

        public override void EditaLeitor(Leitor leitor)
        {
            Nome = leitor.Nome;
            Nascimento = leitor.Nascimento;
            Cpf = leitor.Cpf;
            Email = leitor.Email;
            Telefone = leitor.Telefone;
            Tipo = leitor.Tipo;
        }

        public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            leitor.ExemplaresLeitor.Add(exemplar);
        }

        public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            leitor.ExemplaresLeitor.Remove(exemplar);
        }

        public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            int index = leitor.ExemplaresLeitor.FindIndex(e => e.Equals(exemplar));
            if (index >= 0)
                leitor.ExemplaresLeitor[index] = exemplar;
        }

        public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            if (leitor.ExemplaresLeitor.Contains(exemplar))
                Console.WriteLine(exemplar.ToString());
            else
                Console.WriteLine("Exemplar não encontrado no leitor.");
        }
    }
}
