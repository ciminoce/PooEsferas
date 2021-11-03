using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooEsferas.Entidades;

namespace PooEsferas.Datos
{
    public class RepositorioDeEsferas
    {
        private List<Esfera> listaEsferas;
        private ManejadorDeArchivo _manejador;
        public static RepositorioDeEsferas _instancia = null;

        public static RepositorioDeEsferas GetInstacia()
        {
            if (_instancia==null)
            {
                _instancia = new RepositorioDeEsferas();
            }

            return _instancia;
        }
        private RepositorioDeEsferas()
        {
            listaEsferas = new List<Esfera>();
            _manejador = new ManejadorDeArchivo();
            listaEsferas = _manejador.LeerDatosDelArchivo();
        }
        public int GetCantidad()
        {
            return listaEsferas.Count;
        }

        public bool ExisteEsfera(Esfera esfera)
        {
            return listaEsferas.Contains(esfera);
        }
        public List<Esfera> GetLista()
        {
            return listaEsferas;
        }
        public void Agregar(Esfera esfera)
        {
            listaEsferas.Add(esfera);
        }

        public void Borrar(Esfera esfera)
        {
            listaEsferas.Remove(esfera);
        }

        public void Editar(Esfera esfera)
        {

        }
    }
}
