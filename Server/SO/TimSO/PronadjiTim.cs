using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.TimSO
{
    public class PronadjiTim : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Tim t = odo as Tim;
            t.Liga = Broker.dajSesiju().VratiZaUslovPrimarni(t.Liga) as Liga;
            return t;

        }
    }
}
