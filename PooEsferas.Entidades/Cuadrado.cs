using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEsferas.Entidades
{
    public class Cuadrado
    {
        public int Lado { get; set; }
        public override string ToString()
        {
            return $"Cuadrado de Lado {Lado}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
