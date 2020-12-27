using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.KoloSO
{
    public class KreirajKolo : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kolo k = new Kolo();
            k.Id = Broker.dajSesiju().VratiSifru(k);
            Broker.dajSesiju().Sacuvaj(k);
            return k;
        }
    }
}
