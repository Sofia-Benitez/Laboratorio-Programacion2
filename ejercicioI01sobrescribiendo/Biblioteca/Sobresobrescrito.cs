using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sobresobrescrito : Sobrescrito
    {
        public Sobresobrescrito() : base()
        {

        }

        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
        }

        public override string MiMetodo()
        {
           return MiPropiedad;
        }
    }
}
