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
   public class Set:OpstiDomenskiObjekat
    {
        int koloID;
        int mecID;
        int id;
        int poenaDomacin;
        int poenaGost;

        [DisplayName("Redni broj")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Poeni domaćina")]
        public int PoenaDomacin { get => poenaDomacin; set => poenaDomacin = value; }
        [DisplayName("Poeni gosta")]
        public int PoenaGost { get => poenaGost; set => poenaGost = value; }
        [Browsable(false)]
        public int KoloID { get => koloID; set => koloID = value; }
        [Browsable(false)]
        public int MecID { get => mecID; set => mecID = value; }

        [Browsable(false)]
        public string nazivTabele => "[Set]";
        [Browsable(false)]
        public string primarniKljuc => null;
        [Browsable(false)]
        public string uslovPrimarni => null;
        [Browsable(false)]
        public string Uslov;
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => "values ("+id+", "+MecID+", "+koloID+", "+PoenaDomacin+", "+ PoenaGost+")";


        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Set s = new Set();
            s.KoloID = Convert.ToInt32(red["koloID"]);
            s.MecID = Convert.ToInt32(red["mecID"]);
            s.Id = Convert.ToInt32(red["setID"]);
            s.PoenaDomacin = Convert.ToInt32(red["poenaDomacin"]);
            s.PoenaGost = Convert.ToInt32(red["poenaGost"]);

            return s;

        }
    }
}
