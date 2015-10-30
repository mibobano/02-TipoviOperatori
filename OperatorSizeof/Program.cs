using System;

namespace CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
    }

    struct MojaSloženaStruktura
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;

    }

    class MojaKlasa
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ispisati duljinu tipa decimal
            int x = sizeof(decimal);
            Console.WriteLine(x);

            // ispisati duljinu tipa double
            int y = sizeof(double);
            Console.WriteLine(x);

            // ispisati duljinu tipa MojaStruktura
            int z = y + x;
            Console.WriteLine(z);

            // ispisati duljinu tipa MojaSloženaStruktura
           // b = System.Runtime.InteropServices.Marshal.SizeOf(MojaSloženaStruktura);
            Console.WriteLine(b);

            // ispisati duljinu tipa MojaKlasa


            Console.ReadKey();
        }
    }
}
