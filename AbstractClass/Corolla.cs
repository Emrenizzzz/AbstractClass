using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractClass.Sabitler;

namespace AbstractClass
{
    public class Corolla : Otomobil
    {
        public override Marka HangiAracinMarkasi()
        {
            return Marka.Toyota;
        }
    }
}
