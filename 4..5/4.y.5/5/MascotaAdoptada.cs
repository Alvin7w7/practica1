using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class MascotaAdoptada:Mascota
    {
        

        public string nombreDueño { get; set; }
        public double pagoMascota { get; set; }
        public DateTime fechaAdopcion { get; set; }
        public override string ToString()
        {
              return$"Nombre: {nombre}  |   Edad: {edad}  |   Raza: {raza}   |    Sexo: {sexo}     |   fech: {fechaAdopcion}";
            
        }

    }
}

