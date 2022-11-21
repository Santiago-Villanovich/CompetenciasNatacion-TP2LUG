using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml;
using System.Xml.Linq;

namespace DALXML2
{
    public class AccesoXML
    {
        public List<BEpatrocinador> LeerXML()
        {
            var consulta =
                from Patrocinador in XElement.Load("XMLPatrocinadores.XML").Elements("Patrocinador")
                select new BEpatrocinador
                {
                    ID = Convert.ToInt32(Convert.ToString(Patrocinador.Element("ID").Value).Trim()),
                    Nombre = Convert.ToString(Patrocinador.Element("Nombre").Value).Trim(),
                    Importe = Convert.ToInt32(Convert.ToString(Patrocinador.Element("Importe").Value).Trim())
                };

            List<BEpatrocinador> listaPatrocinadores = consulta.ToList<BEpatrocinador>();
            return listaPatrocinadores;
        }

        public bool AgregarXML(BEpatrocinador obj)
        {
            XDocument xmlDoc = XDocument.Load("XMLPatrocinadores.XML");

            xmlDoc.Element("Patrocinadores").Add(new XElement("Patrocinador",
                                                    new XElement("ID", Convert.ToString(obj.ID).Trim()),
                                                    new XElement("Nombre", obj.Nombre.Trim()),
                                                    new XElement("Importe", Convert.ToString(obj.Importe).Trim())));

            xmlDoc.Save("XMLPatrocinadores.XML");
            return true;
        }
    }
}
