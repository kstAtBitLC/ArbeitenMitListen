using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitListen {
    class LineareListe {
        // Fields
        private ListenElement erstes=null, aktuelles=null, neues=null, letztes=null;

        // Methodes
        public void Hinzufügen(int wert) {
            // Die Liste ist leer, es gibt noch kein ListElement
            if ( erstes == null ) {
                neues = new ListenElement ();
                neues.Wert = wert;
                erstes = neues;
                letztes = erstes;
            }
            else {
                neues = new ListenElement ();
                neues.Wert = wert;
                letztes.Nachfolger = neues;
                letztes = neues;
            }
        }

        public void ZeigeListElemente () {
            aktuelles = erstes;

            while ( aktuelles != null ) {
                Console.WriteLine (aktuelles.Wert);
                aktuelles = aktuelles.Nachfolger;
            }
        }
    }

}
