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
    public class BLLusuario : Igestor<BEusuario>
    {
        public BLLusuario()
        {
            mpp = new MPPusuario();
        }

        MPPusuario mpp;

        public BEusuario BuscarObj(BEusuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEusuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEusuario obj)
        {
            return mpp.Guardar(obj);
        }

        public bool Verificar(BEusuario obj)
        {
            return mpp.VerificarExistencia(obj);
        }

        public bool VerificarNombre(BEusuario obj)
        {
            return mpp.VerificarExistenciaNombre(obj);
        }

        public List<BEusuario> ListarObjs()
        {
            throw new NotImplementedException();
        }
    }
}
