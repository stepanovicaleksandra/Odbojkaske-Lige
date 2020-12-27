using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.KoloSO
{
    public class VratiListuTimova : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Tim t = new Tim();
            t.Uslov = "Naziv is null";
            Broker.dajSesiju().ObrisiZaUslovOstalo(t);

            return Broker.dajSesiju().vratiSve(odo).OfType<Tim>().ToList<Tim>();
        }
    }
}
