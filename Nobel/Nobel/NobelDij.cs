using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class NobelDij
    {
        public int Evszam { get; set; }
        public string Tipus { get; set; }
        public string KeresztNev { get; set; }
        public string VezetekNev { get; set; }
        public string TeljesNev => KeresztNev + " " + VezetekNev;

        public NobelDij(int evszam, string tipus, string keresztNev, string vezetekNev)
        {
            Evszam = evszam;
            Tipus = tipus;
            KeresztNev = keresztNev;
            VezetekNev = vezetekNev;
        }

        


    }
}
