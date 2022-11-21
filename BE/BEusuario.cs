using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;

namespace BE
{
    public class BEusuario:IEntidad
    {
        public int ID { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }
    }
}
