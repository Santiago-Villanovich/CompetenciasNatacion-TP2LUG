using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;
using BE;
using MAPPER;

namespace BLL
{
    public class BLLadministrador : Igestor<BEadminstrador>
    {
        public BLLadministrador()
        {
            mpp = new MPPadministrador();
        }

        MPPadministrador mpp;

        public BEadminstrador BuscarObj(BEadminstrador obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEadminstrador obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEadminstrador obj)
        {
            return mpp.Guardar(obj);
        }

        public List<BEadminstrador> ListarObjs()
        {
            throw new NotImplementedException();
        }
    }
}
