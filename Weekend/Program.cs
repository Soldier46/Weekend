using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Weekend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<fasz> lista = new List<fasz>();
            foreach (var mind1hogymitadokmegneki in File.ReadAllLines("nyitohetvege.txt").Skip(1))
            {
                lista.Add(new fasz(mind1hogymitadokmegneki));
            }
            Console.WriteLine($"3.feladat: Filmek száma állományban " + lista.Count + " db");

            long összeg = 0;
            foreach (var i in lista)
            {
                if (i.forgalmazo =="UIP")
                {
                    összeg += i.bevel;
                }
            }
            Console.WriteLine("4.feladat UIP Duna film forgalmazo 1.hetes bevételének összege:" + összeg + "ft");
            fasz vmax = lista[0];

            foreach (var i in lista)
            {
                if (i.latogato > vmax.latogato)
                {
                    vmax = i;
                }
            }
            Console.WriteLine($"\tEredeti cím: {vmax.eredetiCim} másodperc");
            Console.WriteLine($"\tMagyar cím: {vmax.magyarCim}");
            Console.WriteLine($"\tForgalmazó: {vmax.forgalmazo}");
            Console.WriteLine($"\tBevétel az első héten: {vmax.bevel} Ft");
            Console.WriteLine($"\tLátogatók száma: {vmax.latogato}$" );

        }
    }
}
