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
    public class BLLequipo : Igestor<BEequipo>
    {
        MPPequipo mpp;

        public BLLequipo()
        {
            mpp = new MPPequipo();
        }

        public BEequipo BuscarObj(BEequipo obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEequipo obj)
        {
            return mpp.Eliminar(obj);
        }

        public bool Guardar(BEequipo obj)
        {
            return mpp.Guardar(obj);
        }

        public List<BEnadador> ListarNadadores(BEequipo obj)
        {

            return mpp.ListarNadadores(obj);
        }

        public List<BEequipo> ListarObjs()
        {
            return mpp.ListarObjs();
        }
    }
}
