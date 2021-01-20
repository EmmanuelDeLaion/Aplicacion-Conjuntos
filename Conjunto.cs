using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Conjuntos
{
    public abstract class Conjunto
    {
        public HashSet<string> Lenguaje1;
        public HashSet<string> Lenguaje2;


        public Conjunto(HashSet<string> pLenguaje1, HashSet<string> pLenguaje2)
        {
            this.Lenguaje1 = pLenguaje1;
            this.Lenguaje2 = pLenguaje2;
        }




        public abstract HashSet<string> Union();
        public abstract HashSet<string> Interseccion();
        public abstract HashSet<string> DiferenciaAB();
        public abstract HashSet<string> DiferenciaSimetrica();
    }
}