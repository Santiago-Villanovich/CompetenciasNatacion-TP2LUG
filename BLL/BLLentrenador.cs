using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;
using BE;
using MAPPER;
using System.Data;

namespace BLL
{
    public class BLLentrenador : Igestor<BEentrenador>
    {
        MPPentrenador mpp;

        public BLLentrenador()
        {
            mpp = new MPPentrenador();
        }

        public BEentrenador BuscarObj(BEentrenador obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEentrenador obj)
        {
            return mpp.Eliminar(obj);
        }

        public bool Guardar(BEentrenador obj)
        {
            return mpp.Guardar(obj);
        }

        public List<BEentrenador> ListarObjs()
        {
            return mpp.ListarObjs();
        }

        public DataTable ListaTabla()
        {
            return mpp.tablaEntrenadores();
        }
    }
}
