using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooEsferas.Datos;
using PooEsferas.Entidades;

namespace PooEsferas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = RepositorioDeEsferas.GetInstacia().GetLista();

            //Console.Write("Ingrese la medida del radio de la esfera:");
            //var medidaRadio = int.Parse(Console.ReadLine());

            //if (medidaRadio>0)
            //{
            //    var esfera = new Esfera(medidaRadio);

            //    if (esfera.Validar())
            //    {
            //        Console.WriteLine(esfera.GetArea());

            //    }
            //    else
            //    {
            //        Console.WriteLine("Esfera no válida!!!!");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Medida mal ingresada!!!");
            //}
            //var esfera = new Esfera();
            //esfera.Radio = 10;
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    var esfera3 = new Esfera() {Radio = r.Next(10, 20)};

            //    if (!RepositorioDeEsferas.GetInstacia().ExisteEsfera(esfera3))
            //    {
            //        RepositorioDeEsferas.GetInstacia().Agregar(esfera3);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Esfera existente!!!");
            //    }
            //}

            ////var repo2 = new RepositorioDeEsferas();
            //RepositorioDeEsferas.GetInstacia().Agregar(new Esfera(){Radio = 25});
            //Console.WriteLine(RepositorioDeEsferas.GetInstacia().GetCantidad());
            //var lista = RepositorioDeEsferas.GetInstacia().GetLista();
            foreach (var esfera1 in lista)
            {
                Console.WriteLine(esfera1.ToString());
            }
            Console.ReadLine();
            
        }
    }
}
