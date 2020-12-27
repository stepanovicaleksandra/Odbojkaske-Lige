using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.KoloSO
{
    public class PronadjiMec : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Mec m = odo as Mec;
            m.Hala = Broker.dajSesiju().VratiZaUslovPrimarni(m.Hala) as Hala;
            m.Domacin = Broker.dajSesiju().VratiZaUslovPrimarni(m.Domacin) as Tim;
            m.Gost = Broker.dajSesiju().VratiZaUslovPrimarni(m.Gost) as Tim;

            Set set = new Set();
            set.Uslov = "mecID= " + m.Id;

            List<Set> listaSetova = Broker.dajSesiju().vratiSveZaUslovOstalo(set).OfType<Set>().ToList<Set>();

            foreach (Set s in listaSetova)
            {
                m.Setovi.Add(s);
            }

           
            return m;
        }
    }
    
}
