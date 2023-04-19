using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<MascotaAdoptada> MiMascotaA = new List<MascotaAdoptada>();
            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "arnol",
                edad = 4,
                raza = "dalmata",
                sexo = "macho",
                nombreDueño = "roger",
                pagoMascota = 110.0,
                fechaAdopcion = Convert.ToDateTime("23/03/2020"),
            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "Batman",
                edad = 2,
                raza = "pastor Aleman",
                sexo = "macho",
                nombreDueño = "Raul",
                pagoMascota = 500.0,
                fechaAdopcion = Convert.ToDateTime("05/02/2019"),

            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "Perla",
                edad = 5,
                raza = "Chapi",
                sexo = "hembra",
                nombreDueño = "Susan",
                pagoMascota = 250.0,
                fechaAdopcion = Convert.ToDateTime("25/11/2012"),

            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "Chop",
                edad = 4,
                raza = "Rottweiler",
                sexo = "macho",
                nombreDueño = "Michael",
                pagoMascota = 800.0,
                fechaAdopcion = Convert.ToDateTime("01/01/2020"),

            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "Princesa",
                edad = 1,
                raza = "chiwuawa",
                sexo = "hembra",
                nombreDueño = "Melany",
                pagoMascota = 500.0,
                fechaAdopcion = Convert.ToDateTime("13/08/2022"),

            });

            

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "Boder",
                edad = 4,
                raza = "Alabai",
                sexo = "macho",
                nombreDueño = "Pipe",
                pagoMascota = 900.0,
                fechaAdopcion = Convert.ToDateTime("28/07/2013"),

            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "fercho",
                edad = 5,
                raza = "chiwawa",
                sexo = "hembra",
                nombreDueño = "xavi",
                pagoMascota = 200.0,
                fechaAdopcion = Convert.ToDateTime("23/03/2026"),

            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "sherk",
                edad = 3,
                raza = "chiwuawua",
                sexo = "hembra",
                nombreDueño = "Ronald",
                pagoMascota = 200.0,
                fechaAdopcion = Convert.ToDateTime("23/03/2026"),

            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "sherk",
                edad = 3,
                raza = "labrador",
                sexo = "hembra",
                nombreDueño = "Elver",
                pagoMascota = 200.0,
                fechaAdopcion = Convert.ToDateTime("23/03/2026"),

            });

            MiMascotaA.Add(new MascotaAdoptada()
            {
                nombre = "kal",
                edad = 2,
                raza = "bulldog",
                sexo = "hembra",
                nombreDueño = "Jose",
                pagoMascota = 200.0,
                fechaAdopcion = Convert.ToDateTime("23/03/2026"),

            });

              void mostrarlista(List<MascotaAdoptada> listaMascotas)
              {
                Console.WriteLine();
                foreach (MascotaAdoptada item in listaMascotas)
                {
                    Console.WriteLine(item.ToString());
                }

              }

            mostrarlista(MiMascotaA);
            Double PromM = getPromedio(MiMascotaA);
            Console.WriteLine("\nPROMEDIO DE MASCOTAS ES: {0}", PromM.ToString("##.##"));
            Double PromP = getPromedioDos(MiMascotaA);
            Console.WriteLine("\nPROMEDIO DE PAGO ES: {0}", PromP.ToString("##.##"));


            RazaChiwuawa(MiMascotaA);
            EdadMascota(MiMascotaA);


            Console.ReadKey();
            



                 void RazaChiwuawa(List<MascotaAdoptada> listaMascotas)
                 {
                       var raza = from Mascota in listaMascotas
                                               where Mascota.raza == "Chiwuawa" && Mascota.sexo == "Hembra"
                                               select Mascota;

                    foreach (var Mascota in raza)
                    {
                        Console.WriteLine("\nLAS MASCOTAS QUE SON DE RAZA CHIWUAWA Y DE SEXO FEMENINO SON :\n" + Mascota.nombre + " " + Mascota.raza + " " + Mascota.edad + " " + Mascota.sexo);
                    }
                 }    

                 void EdadMascota(List<MascotaAdoptada> listaMascotas)
                 {
                       var edades = from Mascota in listaMascotas
                                                 where Mascota.edad < 2
                                                 select Mascota;

                    foreach( var Mascota in  edades)
                    {
                        Console.WriteLine("\nLAS MASCOTAS QUE TIENEN LA EDAD MENOR A 2 AÑOS SON:\n" + Mascota.nombre + " " + Mascota.raza + " " + Mascota.edad + " " + Mascota.sexo);
                    }
           
                 }




                 double getPromedioDos(List<MascotaAdoptada> listaMascotas)
                 {
                   double sum = listaMascotas.Sum(x => x.pagoMascota);
                    int total = listaMascotas.Count;
                    return (double)sum / total;
                 }

                 double getPromedio(List<MascotaAdoptada> listaMascotas)
                 {
                    decimal sum = listaMascotas.Sum(x => x.edad);
                    int total = listaMascotas.Count;
                    return (double) sum / total;

                 }
        }

        

    }
}
