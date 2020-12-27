using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;


namespace Server.SO.DelegatSO
{
    public class PrijaviKorisnika : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().VratiZaUslovOstalo(odo) as Delegat;
        }
    }
}
