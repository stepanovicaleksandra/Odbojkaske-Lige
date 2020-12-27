using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.KoloSO
{
    public class PretraziKola : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kolo k = new Kolo();
            k.Uslov = "Naziv is null";
            Broker.dajSesiju().ObrisiZaUslovOstalo(k);
            return Broker.dajSesiju().vratiSveZaUslovOstalo(odo).OfType<Kolo>().ToList<Kolo>();
        }
    }
}
