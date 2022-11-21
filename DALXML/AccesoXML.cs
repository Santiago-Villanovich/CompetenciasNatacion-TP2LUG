using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using BE;

namespace DALXML
{
    public class AccesoXML
    {
        public List<BEpatrocinador> LeerXML()
        {
            //en load va la direccion del archivo, si pongo solo el nombre, es xq e guarda en el servidor
            //luego los elementos y atributos como estan estructurado en el XML
            var consulta =
                from Patrocinador in XElement.Load(@"C:\Universidad\LUG  - Lenguajes de Ultima Generacion\TP2").Elements("Patrocinador")
                select new BEpatrocinador
                {
                    ID = Convert.ToInt32(Convert.ToString(Patrocinador.Attribute("id").Value).Trim()),
                    Nombre = Convert.ToString(Patrocinador.Element("Nombre").Value).Trim(),
                    Importe = Convert.ToInt32(Convert.ToString(Patrocinador.Attribute("Importe").Value).Trim())
                };//Fin de consulta.
            //paso la consulta a lista del tipo clase Juego
            List<BEpatrocinador> listaPatrocinadores = consulta.ToList<BEpatrocinador>();
            return listaPatrocinadores;
        }

        public bool AgregarXML(BEpatrocinador obj)
        {
            XDocument xmlDoc = XDocument.Load(@"C:\Universidad\LUG  - Lenguajes de Ultima Generacion\TP2");
            // en el Xdocument, utilizo, y agrego como esta estructurado el XML
            xmlDoc.Element("Patrocinadores").Add(new XElement("Patrocinador",
                                                    new XAttribute("id", Convert.ToString(obj.ID).Trim()),
                                                    new XElement("Nombre", obj.Nombre.Trim()),
                                                    new XElement("Importe", Convert.ToString(obj.Importe).Trim())));

            //luego el metodo save guarda lo ingresado en el XML
            xmlDoc.Save("XMLPatrocinadores.XML");
            return true;
        }
    }
}
