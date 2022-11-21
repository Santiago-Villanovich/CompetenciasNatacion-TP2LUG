using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;

namespace BE
{
    public abstract class BEcompetencia : IEntidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public int PrecioEntrada { get; set; }
        public int Premio { get; set; }

    }
}
