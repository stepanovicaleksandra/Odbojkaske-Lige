using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.TimSO
{
    public class PretraziTimove : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            List<Tim> lista=Broker.dajSesiju().vratiSveZaUslovOstalo(odo).OfType<Tim>().ToList<Tim>();  
            foreach(Tim t in lista)
            {
                t.Liga = Broker.dajSesiju().VratiZaUslovPrimarni(t.Liga) as Liga;
            }
            return lista;
        }
    }
}
