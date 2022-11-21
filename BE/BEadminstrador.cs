using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEadminstrador: BEpersona
    {
        public string password { get; set; }
        public BEadminstrador() { }
        public BEadminstrador(string nom,string ape,string dni, int tel,string pw)
        {
            nombre = nom;
            apellido = ape;
            this.dni = dni;
            telefono = tel;
            password = pw;
        }
    }
}
