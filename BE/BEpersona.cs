using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;

namespace BE
{
    public abstract class BEpersona : IEntidad
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public int telefono { get; set; }
    }
}
