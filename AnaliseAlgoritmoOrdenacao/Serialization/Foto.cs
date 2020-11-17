using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseAlgoritmoOrdenacao.Serialization
{
    public class Foto
    {
        public Foto() { }
        public int IdFoto { get; set; }
        public string Titulo { get; set; }
        public string LocalDaFoto { get; set; }
        public string DataDaFoto { get; set; } //DataHora
        //public int ResoluçãoX { get; set; } // px
        //public int ResoluçãoY { get; set; } // px
        public string Tamanho { get; set; } // KB or double
        public string Formato { get; set; }
        public Foto(int idFoto, string titulo, string localDaFoto,
            string dataDaFoto, string tamanho, string formato)
        {
            this.IdFoto = idFoto;
            this.Titulo = titulo;
            this.LocalDaFoto = localDaFoto;
            this.DataDaFoto = dataDaFoto;
            this.Tamanho = tamanho;
            this.Formato = formato;
        }
    }
}
