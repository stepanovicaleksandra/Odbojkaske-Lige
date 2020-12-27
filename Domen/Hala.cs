using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
   public class Hala:OpstiDomenskiObjekat
    {
        int id;
        string naziv;
        int kapacitet;
        string adresa;

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Kapacitet { get => kapacitet; set => kapacitet = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        public override string ToString()
        {
            return naziv;
        }

        [Browsable(false)]
        public string nazivTabele => "Hala";
        [Browsable(false)]
        public string primarniKljuc => "halaID";
        [Browsable(false)]
        public string uslovPrimarni => "halaID= "+Id;
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Hala h = new Hala();

            h.Id = Convert.ToInt32(red["halaID"]);
            h.Naziv = red["naziv"].ToString();
            h.Kapacitet = Convert.ToInt32(red["kapacitet"]);
            h.Adresa = red["adresa"].ToString();

            return h;
        }
    }
}
