using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Conjuntos
{
    public class ConjuntoDoble : Conjunto
    {
        public HashSet<string> Lenguaje1;
        public HashSet<string> Lenguaje2;



        //Constructor
        public ConjuntoDoble(HashSet<string> pLenguaje1, HashSet<string> pLenguaje2) : base(pLenguaje1, pLenguaje2)
        {
            this.Lenguaje1 = pLenguaje1;
            this.Lenguaje2 = pLenguaje2;
        }



        public override HashSet<string> Union()
        {
            HashSet<string> unionAB = new HashSet<string>(this.Lenguaje1);
            unionAB.UnionWith(this.Lenguaje2);
            return unionAB;
        }



        public override HashSet<string> Interseccion()
        {
            HashSet<string> interseccionAB = new HashSet<string>(this.Lenguaje1);
            interseccionAB.IntersectWith(this.Lenguaje2);
            return interseccionAB;
        }




        public override HashSet<string> DiferenciaAB()
        {
            HashSet<string> diferenciaAB = new HashSet<string>(this.Lenguaje1);
            diferenciaAB.ExceptWith(this.Lenguaje2);
            return diferenciaAB;
        }




        public HashSet<string> operarDiferenciaBA()
        {
            HashSet<string> diferenciaBA = new HashSet<string>(this.Lenguaje2);
            diferenciaBA.ExceptWith(Lenguaje1);
            return diferenciaBA;
        }




        public override HashSet<string> DiferenciaSimetrica()
        {
            HashSet<string> diferenciaSimetrica = new HashSet<string>(this.Lenguaje1);
            diferenciaSimetrica.SymmetricExceptWith(this.Lenguaje2);
            return diferenciaSimetrica;
        }




    }
}
