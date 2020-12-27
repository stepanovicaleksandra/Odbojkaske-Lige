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
    public class Liga : OpstiDomenskiObjekat
    {
        int id;
        string naziv;
        string sponzor;

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Sponzor { get => sponzor; set => sponzor = value; }

        public override string ToString()
        {
            return naziv;
        }

        [Browsable(false)]
        public string nazivTabele => "Liga";
        [Browsable(false)]
        public string primarniKljuc => "ligaID";
        [Browsable(false)]
        public string uslovPrimarni => "ligaID =" +id;
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

       
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Liga l = new Liga();

            l.Id =Convert.ToInt32(red["ligaID"]);
            l.Naziv = red["naziv"].ToString();
            l.Sponzor = red["sponzor"].ToString();

            return l;
        }

        public override bool Equals(object obj)
        {
            var liga = obj as Liga;
            return liga != null &&
                   id == liga.id &&
                   naziv == liga.naziv &&
                   sponzor == liga.sponzor;
        }
    }
}
