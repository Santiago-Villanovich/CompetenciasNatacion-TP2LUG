using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEentrenador: BEpersona
    {
        public string club { get; set; }

        public BEentrenador() { }
        public BEentrenador(string nom,string ape,string dni, int tel,string nomclub)
        {
            nombre = nom;
            apellido = ape;
            this.dni = dni;
            telefono = tel;
            club = nomclub;

        }
    }
}
