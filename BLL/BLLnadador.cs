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
    public class BLLnadador : Igestor<BEnadador>
    {
        MPPnadador mpp;

        public BLLnadador()
        {
            mpp = new MPPnadador();
        }

        public bool Eliminar(BEnadador obj)
        {
            return mpp.Eliminar(obj);
        }

        public bool GuardarEquip(BEnadador obj, int idequip)
        {
            return mpp.GuardarEquip(obj, idequip);
        }

        public bool GuardarComp(BEnadador obj, int idcomp)
        {
            return mpp.GuardarAA(obj, idcomp);
        }

        public List<BEnadador> ListarXcategoria(string categoria) 
        {
            return mpp.ListarXCategoria(categoria);
        }



        /*-----------------------------------------------------------------------------------------------*/
        public bool Guardar(BEnadador obj)
        {
            throw new NotImplementedException();
        }
        public BEnadador BuscarObj(BEnadador obj)
        {
            throw new NotImplementedException();
        }
        public List<BEnadador> ListarObjs()
        {
            return mpp.ListarObjs();
        }
    }
}
