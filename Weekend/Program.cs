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


        }
    }
}
