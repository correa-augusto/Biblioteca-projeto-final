using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//AUGUSTO DOS SANTOS CORRÊA
namespace Biblioteca
{
    internal class Livro:Exemplar
    {
        private int paginas;
        private string tipoCapa;
        private string isbn;

        public int Pagninas
        {
            get => paginas;
            set
            {
                if(value < 20)
                {
                    throw new Exception("O livro deve conter mais de 20 páginas");
                }
                paginas = value;
            }
        }

        public string TipoCapa
        {
            get => tipoCapa;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Tipo de capa deve ser preenchido.");
                }

                tipoCapa = value.Trim();
            }
        }

        public string Isbn
        {
            get => isbn;    
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Isbn deve ser preenchido");
                }
                isbn = value.Trim();
            }
        }

        public Livro(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao,
                 string genero, int status, int paginas, string tipoCapa, string isbn): base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            this.Pagninas = paginas;
            this.TipoCapa = tipoCapa;
            this.Isbn = isbn;
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
                   $"Páginas: {Pagninas}\n" +
                   $"Tipo de Capa: {TipoCapa}\n" +
                   $"ISBN: {Isbn}";
        }

    }
}
