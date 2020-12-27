using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;


namespace Server.SO.TimSO
{
    public class ZapamtiTim : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
           return Broker.dajSesiju().IzmeniUslovPrimarni(odo);
        }
    }
}
