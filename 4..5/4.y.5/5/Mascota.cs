using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Mascota
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string raza { get; set; }
        public string sexo { get; set; }


        public virtual void MostrarMascota() {  }
    }
}
