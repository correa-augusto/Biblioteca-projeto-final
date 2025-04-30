using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal abstract class Pessoa
    {
        private string nome;
        private DateTime nascimento;
        private string cpf;
        private string email;
        private string telefone;

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nome deve ser preenchido.");
                nome = value.Trim();
            }
        }

        public DateTime Nascimento
        {
            get => nascimento;
            set => nascimento = value;
        }

        public string Cpf
        {
            get => cpf;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("CPF deve ser preenchido.");
                cpf = value.Trim();
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Email deve ser preenchido.");
                email = value.Trim();
            }
        }

        public string Telefone
        {
            get => telefone;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Telefone deve ser preenchido.");
                telefone = value.Trim();
            }
        }

        // Métodos abstratos
        public abstract void ListaLeitor(Leitor leitor);
        public abstract void EditaLeitor(Leitor leitor);
        public abstract void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor);
    }
}