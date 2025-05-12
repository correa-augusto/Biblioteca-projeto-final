using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Funcionario : Pessoa
    {
        private int cargo;
        private decimal salario;
        private int cargaHoraria;
        private string funcao;

        public int Cargo
        {
            get => cargo;
            set
            {
                if (value < 0)
                    throw new Exception("O cargo deve ser um número positivo.");
                cargo = value;
            }
        }

        public decimal Salario
        {
            get => salario;
            set
            {
                if (value < 0)
                    throw new Exception("O salário deve ser um valor positivo.");
                salario = value;
            }
        }

        public int CargaHoraria
        {
            get => cargaHoraria;
            set
            {
                if (value <= 0)
                    throw new Exception("A carga horária deve ser maior que zero.");
                cargaHoraria = value;
            }
        }

        public string Funcao
        {
            get => funcao;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("A função deve ser informada.");
                funcao = value;
            }
        }

        public void NovoLeitor(Leitor leitor)
        {
            if (leitor == null)
                throw new Exception("Leitor inválido.");
            Console.WriteLine("Leitor adicionado com sucesso.");
        }

        public void ExcluiLeitor(Leitor leitor)
        {
            if (leitor == null)
                throw new Exception("Leitor inválido.");
            Console.WriteLine("Leitor excluído com sucesso.");
        }

        public void NovoFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
                throw new Exception("Funcionário inválido.");
            Console.WriteLine("Funcionário adicionado com sucesso.");
        }

        public void EditaFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
                throw new Exception("Funcionário inválido.");
            Console.WriteLine("Funcionário editado com sucesso.");
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
                throw new Exception("Funcionário inválido.");
            Console.WriteLine("Funcionário excluído com sucesso.");
        }

        public void ListaFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
                throw new Exception("Funcionário inválido.");
            Console.WriteLine(funcionario.ToString());
        }

        public void NovoExemplar(Exemplar exemplar)
        {
            if (exemplar == null)
                throw new Exception("Exemplar inválido.");
            Console.WriteLine("Exemplar adicionado com sucesso.");
        }

        public void EditaExemplar(Exemplar exemplar)
        {
            if (exemplar == null)
                throw new Exception("Exemplar inválido.");
            Console.WriteLine("Exemplar editado com sucesso.");
        }

        public void ExcluiExemplar(Exemplar exemplar)
        {
            if (exemplar == null)
                throw new Exception("Exemplar inválido.");
            Console.WriteLine("Exemplar excluído com sucesso.");
        }

        public void ListaExemplar(Exemplar exemplar)
        {
            if (exemplar == null)
                throw new Exception("Exemplar inválido.");
            Console.WriteLine(exemplar.ToString());
        }

        public override void ListaLeitor(Leitor leitor)
        {
            if (leitor == null)
                throw new Exception("Leitor inválido.");
            Console.WriteLine(leitor.ToString());
        }

        public override void EditaLeitor(Leitor leitor)
        {
            if (leitor == null)
                throw new Exception("Leitor inválido.");
            Console.WriteLine("Leitor editado com sucesso.");
        }

        public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            if (exemplar == null || leitor == null)
                throw new Exception("Dados inválidos.");
            leitor.ExemplaresLeitor.Add(exemplar);
            Console.WriteLine("Exemplar adicionado ao leitor.");
        }

        public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            if (exemplar == null || leitor == null)
                throw new Exception("Dados inválidos.");
            leitor.ExemplaresLeitor.Remove(exemplar);
            Console.WriteLine("Exemplar removido do leitor.");
        }

        public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            if (exemplar == null || leitor == null)
                throw new Exception("Dados inválidos.");
            Console.WriteLine("Exemplar do leitor editado.");
        }

        public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            if (exemplar == null || leitor == null)
                throw new Exception("Dados inválidos.");
            Console.WriteLine($"Exemplar: {exemplar}, Leitor: {leitor}");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {Cpf}\nCargo: {Cargo}\nFunção: {Funcao}\nSalário: {Salario:C}\nCarga Horária: {CargaHoraria}h";
        }
    }
}
