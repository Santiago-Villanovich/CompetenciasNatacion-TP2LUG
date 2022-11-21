using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEpileta:BEcompetencia
    {
        public string Tipo { get; set; }
        public BEequipo EquipoGanador { get; set; }
        public List<BEequipo> ListaEquipos { get; set; }

        public void LimpiarPropiedades()
        {
            ID = 0;
            Nombre = "";
            descripcion = "";
            Ubicacion = "";
            PrecioEntrada = 0;
            Premio = 0;
            Tipo = "";

        }
    }
}
