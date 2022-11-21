using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using ABS;
using MAPPER;

namespace BLL
{
    public class BLLpileta : Igestor<BEpileta>
    {
        public BLLpileta()
        {
            mpp = new MPPpileta();
        }
        MPPpileta mpp;

        public BEpileta BuscarObj(BEpileta obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEpileta obj)
        {
            return mpp.Eliminar(obj);
        }

        public bool Guardar(BEpileta obj)
        {
            return mpp.Guardar(obj);
        }

        public List<BEpileta> ListarObjs()
        {
            return mpp.ListarObjs();
        }
    }
}
