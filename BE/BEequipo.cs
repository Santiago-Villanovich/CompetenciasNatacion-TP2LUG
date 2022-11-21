using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;

namespace BE
{
    public class BEequipo : IEntidad
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public List<BEnadador> nadadores { get; set; }
        public BEentrenador entrenador { get; set; }
        public double tiempoFinal { get; set; }
    }
}
