using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca
{
    internal class Generico:Exemplar
    {
        private int tipo;

        public int Tipo
        {
            get => tipo;
            set
            {
                if(value < 0)
                {
                    throw new Exception("Tipo deve ser preenchido");
                }
            }
        }
        public Generico(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao,
               string genero, int status, int tipo) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}\n" +
                   $"Subtítulo: {Subtitulo}\n" +
                   $"Escritor: {Escritor}\n" +
                   $"Editora: {Editora}\n" +
                   $"Ano de Publicação: {AnoPublicacao}\n" +
                   $"Gênero: {Genero}\n" +
                   $"Status: {Status}\n" +
                   $"Tipo: {Tipo}";
        }
    }
}
