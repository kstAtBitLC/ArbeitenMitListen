using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitListen {
    class ListenElement {
        public int Wert { get; set; }
        public ListenElement Nachfolger { get; set; } = null;
    }
}
