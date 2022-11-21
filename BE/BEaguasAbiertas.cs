using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEaguasAbiertas:BEcompetencia
    {
        public string Distancia { get; set; }
        public BEnadador PrimerPuesto { get; set; }
        public List<BEnadador> ListaNadadores { get; set; }

        public void LimpiarPropiedades()
        {
            ID = 0;
            Nombre = "";
            descripcion = "";
            Ubicacion = "";
            PrecioEntrada = 0;
            Premio = 0;
            Distancia = "";

        }

    }
}
