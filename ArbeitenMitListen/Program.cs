using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitListen
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry erstes, letztes, aktuelles, neues;

            //1. Element
            neues = new Entry () { Information = 4711 };
            erstes = neues;
            letztes = erstes;
            //2.Element

            neues = new Entry () { Information = 4610 };
            letztes.Next = neues;

            // Ausgabe : Schritt um Schritt
            aktuelles = erstes;
            Console.WriteLine (aktuelles.Information);
            aktuelles = aktuelles.Next;
            Console.WriteLine ( aktuelles.Information );

            // Ausgabe über eine Schleife
            aktuelles = erstes;
            do {
                Console.WriteLine ( aktuelles.Information );
                aktuelles = aktuelles.Next;
            } while ( aktuelles != null );

            Console.ReadLine ();
        }
    }

    class Entry {
        public int Information { get; set; }
        public Entry Next { get; set; } = null;
    }
}
