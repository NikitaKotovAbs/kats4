using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Praktan5
{
    internal class Cake
    {
        public int cost;
        public string forma;
        public string size;
        public string vkus;
        public string Kolvo_Korgey;
        public string glazur;
        public string decor;
        public Cake(int ParamCost, string ParamForma, string ParamSize, string Paramvkus, string ParamKolvo_Korgey, string Paramglazur, string ParamDecor)
        {
            cost = ParamCost;
            forma = ParamForma;
            size = ParamSize;
            vkus = Paramvkus;
            Kolvo_Korgey = ParamKolvo_Korgey;
            glazur = Paramglazur;
            decor = ParamDecor;
        }
    }
}

