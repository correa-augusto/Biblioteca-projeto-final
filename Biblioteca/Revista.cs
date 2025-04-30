using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca
{
    internal class Revista:Exemplar
    {
        private int edicao;
        private int paginas;

        public int Edicao
        {
            get => edicao;
            set
            {
                if(value < 0)
                {
                    throw new Exception("A edição deve ser maior que zero");
                }
                edicao = value;
            }
        }

        public int Paginas
        {
            get => paginas;
            set
            {
                if(value < 20)
                {
                    throw new Exception("A revista deve ter mais de 20 página");
                }
                paginas = value;
            }
        }

        public Revista(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao,
                string genero, int status, int edicao, int paginas) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            this.edicao = edicao;
            this.paginas = paginas;
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
                   $"Páginas: {Paginas}";
        }

    }
}
