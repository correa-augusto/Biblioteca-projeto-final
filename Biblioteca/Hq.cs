using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca
{
    internal class Hq:Exemplar
    {
        private int edicao;
        private string ilustrador;

        public int Edicao
        {
            get => edicao;
            set
            {
                if(value < 0)
                {
                    throw new Exception("Edição deve ser maior que zero");
                }
                edicao = value;
            }
        }

        public string Ilustrador
        {
            get => ilustrador;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ilustrador deve ser informado");
                }
            }
        }

        public Hq(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao,
               string genero, int status, int edicao, string ilustrador) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            this.edicao = edicao;
            this.ilustrador = ilustrador;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}\n" +
                   $"Subtítulo: {Subtitulo}\n" +
                   $"Escritor: {Escritor}\n" +
                   $"Editora: {Editora}\n" +
                   $"Ano de Publicação: {AnoPublicacao}\n" +
                   $"Gênero: {Genero}\n" +
                   $"Status: {(Status == 1 ? "Disponível" : "Indisponível")}\n" +
                   $"Edição: {Edicao}\n" +
                   $"Ilustrador: {Ilustrador}";
        }
    }
}
