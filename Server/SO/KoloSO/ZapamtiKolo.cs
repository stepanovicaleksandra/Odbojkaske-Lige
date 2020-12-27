using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.KoloSO
{
    public class ZapamtiKolo : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kolo k = odo as Kolo;
            Broker.dajSesiju().IzmeniUslovPrimarni(k);

            Mec mec = new Mec();
            mec.Uslov = "koloID= " + k.Id;
            Broker.dajSesiju().ObrisiZaUslovOstalo(mec);

            foreach(Mec m in k.Mecevi)
            {
                Broker.dajSesiju().Sacuvaj(m);
               
                    foreach (Set s in m.Setovi)
                    {
                        s.KoloID = k.Id;
                        s.MecID = m.Id;
                        Broker.dajSesiju().Sacuvaj(s);
                    } 
            }

            return k;
        }
    }
}
