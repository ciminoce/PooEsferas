using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEsferas.Entidades
{
    public class Esfera:ICloneable
    {
        public int Radio { get; set; }

        public Esfera()
        {
            
        }
        public Esfera(int medidaRadio)
        {
            Radio = medidaRadio;
        }
        public double GetVolumen()
        {
            return 4/3 * Math.PI * Math.Pow(Radio, 3);
        }
      
        public double GetArea()
        {
            return 4 * Math.PI * Math.Pow(Radio, 2);
        }

        public bool Validar()
        {
            return Radio > 0;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Esfera de radio {Radio}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Esfera))
            {
                return false;
            }

            return Radio == ((Esfera)obj).Radio;
        }

        public override int GetHashCode()
        {
            return Radio.GetHashCode();
        }
    }
}
