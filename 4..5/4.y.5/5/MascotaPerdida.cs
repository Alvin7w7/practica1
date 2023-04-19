using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class MascotaPerdida:Mascota
    {
        
        public string motivo { get; set; }
        public DateTime fechaPerdida { get; set; }

        public override void MostrarMascota()
        {

        }
    }
}
