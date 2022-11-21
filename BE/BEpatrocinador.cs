using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;

namespace BE
{
    public class BEpatrocinador : IEntidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Importe { get; set; }

        public BEpatrocinador()
        {

        }

        public BEpatrocinador(int id,string nom,int imp)
        {
            ID = id;
            Nombre = nom;
            Importe = imp;
        }
    }
}
