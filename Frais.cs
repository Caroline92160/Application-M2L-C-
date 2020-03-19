using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationM2L1
{
    class Frais
    {
        static int CalculTotalFrais(int FraisMin, int FraisMax)
        {
            int resultat = 0;
            for (int i = FraisMin; i <= FraisMax; i++)
            {
                resultat += i;
            }
            return resultat;
        }
    }
}
