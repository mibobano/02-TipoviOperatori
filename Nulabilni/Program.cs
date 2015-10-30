using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);
            //double broj = nulabilniDuplić;
            double broj2 = 2;
            Console.WriteLine(broj2);

            double običniDuplic = Math.PI;
            //Nullable<T> broj3;


            Console.ReadKey();
        }
    }
}
