using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//AUGUSTO DOS SANTOS CORRÊA
namespace Biblioteca
{
    public abstract class Exemplar
    {
        private string titulo;
        private string subtitulo;
        private string escritor;
        private string editora;
        private int anoPublicacao;
        private string genero;
        private int status;

        public string Titulo
        {
            get => titulo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Titulo deve ser preenchido");
                }
                titulo = value.Trim();
            }
        }

        public string Subtitulo
        {
            get => subtitulo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Subtitulo deve ser preenchido");
                }
                subtitulo = value.Trim();
            }
        }

        public string Escritor
        {
            get => escritor;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Escritor deve ser preenchido");
                }
                escritor = value.Trim();    
            }
        }

        public string Editora
        {
            get => editora; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Editora deve ser informada");
                }
                editora = value.Trim();
            }
        }

        public int AnoPublicacao
        {
            get => anoPublicacao;
            set
            {
                int anoAtual = DateTime.Now.Year;
                if (value >= 1450 && value <= anoAtual)
                {
                    anoPublicacao = value;
                }
                else
                {
                    throw new Exception("Ano deve estar entre 1450 e o ano atual");
                }
            }
        }

        public string Genero
        {
            get => genero;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Genero deve ser preenchido");
                }
                genero = value.Trim();
            }
        }

        public int Status
        {
            get => status;
            set
            {
                if(value > 0)
                {
                    status = value;
                }
                throw new Exception("Status deve ser maior que zero");
            }
        }

        public Exemplar(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao, string genero, int status)
        {
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.escritor = escritor;
            this.editora = editora;
            this.anoPublicacao = anoPublicacao;
            this.genero = genero;
            this.status = status;
        }
    }
}
