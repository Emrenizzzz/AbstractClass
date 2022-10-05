using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.KacTekerlekVar());
            Console.WriteLine(corolla.HangiAracinMarkasi().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());
            
            Civic civic = new Civic();
            Console.WriteLine(civic.KacTekerlekVar());
            Console.WriteLine(civic.HangiAracinMarkasi().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            
            Focus focus = new Focus();
            Console.WriteLine(focus.KacTekerlekVar());
            Console.WriteLine(focus.HangiAracinMarkasi().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());


        }
    }
}
