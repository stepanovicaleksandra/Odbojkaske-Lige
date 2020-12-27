using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.KoloSO
{
    public class PronadjiKolo : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kolo k = odo as Kolo;
            k.Liga = Broker.dajSesiju().VratiZaUslovPrimarni(k.Liga) as Liga;
            k.Delegat = Broker.dajSesiju().VratiZaUslovPrimarni(k.Delegat) as Delegat;

            Mec mec = new Mec();
            mec.Uslov = "koloID= " + k.Id;

            List<Mec> listaMeceva = Broker.dajSesiju().vratiSveZaUslovOstalo(mec).OfType<Mec>().ToList<Mec>();

            foreach(Mec m in listaMeceva)
            {
                m.Hala = Broker.dajSesiju().VratiZaUslovPrimarni(m.Hala) as Hala;
                m.Domacin = Broker.dajSesiju().VratiZaUslovPrimarni(m.Domacin) as Tim;
                m.Gost = Broker.dajSesiju().VratiZaUslovPrimarni(m.Gost) as Tim;
                m.Domacin.Liga = k.Liga;
                m.Gost.Liga = k.Liga;

                Set set = new Set();
                set.Uslov = "mecID= " + m.Id+ "and koloID= "+k.Id;

                List<Set> listaSetova = Broker.dajSesiju().vratiSveZaUslovOstalo(set).OfType<Set>().ToList<Set>();

                foreach (Set s in listaSetova)
                {
                    m.Setovi.Add(s);
                }


                k.Mecevi.Add(m);
            }

            return k;
        }
    }
            
}
