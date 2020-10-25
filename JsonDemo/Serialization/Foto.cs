using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo.Serialization
{
    public class Foto
    {
        public int IdFoto { get; set; }
        public String Titulo { get; set; }
        public String LocalDaFoto { get; set; }
        public String DataDaFoto { get; set; } //DataHora
        public int Resolu��oX { get; set; } // px
        public int Resolu��oY { get; set; } // px
        public String Tamanho { get; set; } // KB or double
        public String Formato { get; set; }
    }
}
