using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;
using DALXML2;
using BE;


namespace MAPPER
{
    public class MPPpatrocinador : Igestor<BEpatrocinador>
    {
        public MPPpatrocinador()
        {
            axml = new AccesoXML();
        }

        AccesoXML axml;

        public BEpatrocinador BuscarObj(BEpatrocinador obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEpatrocinador obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEpatrocinador obj)
        {
            return axml.AgregarXML(obj);
        }

        public List<BEpatrocinador> ListarObjs()
        {
            return axml.LeerXML();
        }
    }
}
