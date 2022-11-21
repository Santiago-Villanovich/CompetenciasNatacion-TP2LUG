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
    public class BLLaguasAbiertas : Igestor<BEaguasAbiertas>
    {
        public BLLaguasAbiertas()
        {
            mpp = new MPPaguasAbiertas();
        }

        MPPaguasAbiertas mpp;

        public BEaguasAbiertas BuscarObj(BEaguasAbiertas obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEaguasAbiertas obj)
        {
            return mpp.Eliminar(obj);
        }

        public bool Guardar(BEaguasAbiertas obj)
        {
            return mpp.Guardar(obj);
        }

        public List<BEaguasAbiertas> ListarObjs()
        {
            return mpp.ListarObjs();
        }
    }
}
