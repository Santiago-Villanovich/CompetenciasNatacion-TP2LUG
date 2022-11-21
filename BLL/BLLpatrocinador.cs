using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;
using ABS;
using BE;

namespace BLL
{
    public class BLLpatrocinador : Igestor<BEpatrocinador>
    {
        public BLLpatrocinador()
        {
            mpp = new MPPpatrocinador();
        }

        MPPpatrocinador mpp;

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
            return mpp.Guardar(obj);
        }

        public List<BEpatrocinador> ListarObjs()
        {
            return mpp.ListarObjs();
        }
    }
}
