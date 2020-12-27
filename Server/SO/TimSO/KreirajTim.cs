using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;


namespace Server.SO.TimSO
{
    public class KreirajTim : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Tim t = new Tim();
            t.Id = Broker.dajSesiju().VratiSifru(t);
            Broker.dajSesiju().Sacuvaj(t);
            return t;
        }
    }
}
