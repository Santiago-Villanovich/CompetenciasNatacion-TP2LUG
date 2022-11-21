using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEnadador: BEpersona
    {
        public int edad { get; set; }
        public string categoria { get; set; }
        public double tiempo { get; set; }

        //public TimeSpan tiempoPasada { get; set; }

        public BEnadador() { }
        public BEnadador(string nom, string ape, string dni, int tel, int age)
        {
            nombre = nom;
            apellido = ape;
            this.dni = dni;
            telefono = tel;
            edad = age;

            asignarCategoria(age);
        }

        public void asignarCategoria(int age)
        {
            if (age >= 10 && age <= 11)
            {
                categoria = EnumCategoria.Infantiles.ToString();
            }
            else if (age >= 12 && age <= 13)
            {
                categoria = EnumCategoria.Menores.ToString();
            }
            else if (age >= 14 && age <= 15)
            {
                categoria = EnumCategoria.Cadetes.ToString();
            }
            else if (age >= 16 && age <= 18)
            {
                categoria = EnumCategoria.Juveniles.ToString();
            }
            else if (age >= 19)
            {
                categoria = EnumCategoria.Mayores.ToString();
            }
            else
            {
                categoria = "Error";
            }
        }
    }
}
