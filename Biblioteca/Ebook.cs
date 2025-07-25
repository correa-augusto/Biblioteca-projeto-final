﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//AUGUSTO DOS SANTOS CORRÊA
namespace Biblioteca
{
    internal class Ebook:Exemplar
    {
        private string formato;
        private decimal tamanho;
        private string url;
        private int paginas;

        public String Formato
        {
            get => formato;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Formato deve ser informado");
                }
                formato = value.Trim();
            }
        }

       public decimal Tamanho
        {
            get => tamanho;
            set
            {
                if(value < 0)
                {
                    throw new Exception("Tamanho deve ser informado");
                }
                tamanho = value;
            }
        }

        public string Url
        {
            get => url;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("URL deve ser preenchida");
                }
                url = value.Trim();
            }
        }

        public int Pagninas
        {
            get => paginas;
            set
            {
                if (value < 20)
                {
                    throw new Exception("O livro deve conter mais de 20 páginas");
                }
                paginas = value;
            }
        }

        public Ebook(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao,
             string genero, int status, string formato, decimal tamanho, string url, int paginas) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            this.formato = formato; 
            this.tamanho = tamanho; 
            this.url = url;
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
                   $"Formato: {Formato}\n" +
                   $"Tamanho: {Tamanho} MB\n" +
                   $"URL: {Url}" +
                   $"PAGINAS: {Pagninas}";
        }
    }
}
