using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooEsferas.Entidades;

namespace PooEsferas.Datos
{
    public class ManejadorDeArchivo
    {
        //Se encarga de manejar la persistencia de los datos en un arch. secuencial
        private readonly string _archivo = Environment.CurrentDirectory + @"\Esferas.txt";

        public ManejadorDeArchivo()
        {
            
        }

        public List<Esfera> LeerDatosDelArchivo()
        {
            List<Esfera> lista = new List<Esfera>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Esfera esfera = ConstruirEsfera(linea);
                    lista.Add(esfera);
                }
                lector.Close();
            }

            return lista;
        }

        private Esfera ConstruirEsfera(string linea)
        {
            return new Esfera()
            {
                Radio = int.Parse(linea)
            };
        }
    }
}
