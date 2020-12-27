using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Status { zakazan, odigran, odlozen, prekinut}
    [Serializable]
    public class Mec : OpstiDomenskiObjekat
    {
        int koloID;
        int id;
        DateTime datumVreme;
        Tim domacin;
        Tim gost;
        int setovaDomacin;
        int setovaGost;
        Status status;
        Hala hala;
        BindingList<Set> setovi;
        [DisplayName("R.broj")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Datum i vreme")]
        public DateTime DatumVreme { get => datumVreme; set => datumVreme = value; }
        [DisplayName("Domaćin")]
        public Tim Domacin { get => domacin; set => domacin = value; }
        [DisplayName("Gost")]
        public Tim Gost { get => gost; set => gost = value; }
        [DisplayName("Broj setova domaćina")]
        public int SetovaDomacin { get => setovaDomacin; set => setovaDomacin = value; }
        [DisplayName("Broj setova gosta")]
        public int SetovaGost { get => setovaGost; set => setovaGost = value; }
        public Hala Hala { get => hala; set => hala = value; }
        public Status Status { get => status; set => status = value; }
        public BindingList<Set> Setovi { get => setovi; set => setovi = value; }
        [Browsable(false)]
        public int KoloID { get => koloID; set => koloID = value; }

        public Mec()
        {
            setovi = new BindingList<Set>();
        }

        [Browsable(false)]
        public string nazivTabele => "Mec";
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
        public string unos => "values ("+Id+ ", " + KoloID + ",'" + DatumVreme.ToString("yyyy-MM-dd HH:mm")+"', "+Domacin.Id+", "+Gost.Id+", "+SetovaDomacin+", "+SetovaGost+", '"+Status+"', "+Hala.Id+")";


        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Mec m = new Mec();
            m.KoloID = Convert.ToInt32(red["koloID"]);
            m.Id = Convert.ToInt32(red["mecID"]);
            m.DatumVreme = Convert.ToDateTime(red["datumVreme"]);
            Tim domacin = new Tim();
            domacin.Id = Convert.ToInt32(red["domacinID"]);
            m.Domacin = domacin;
            Tim gost = new Tim();
            gost.Id = Convert.ToInt32(red["gostID"]);
            m.Gost = gost;
            m.setovaDomacin = Convert.ToInt32(red["setovaDomacin"]);
            m.SetovaGost = Convert.ToInt32(red["setovaGost"]);
            m.status = (Status)Enum.Parse(typeof(Status), red["status"].ToString());
            Hala h = new Hala();
            h.Id = Convert.ToInt32(red["halaID"]);
            m.Hala = h;

            return m;
        }

        public override bool Equals(object obj)
        {
            var mec = obj as Mec;
            return mec != null &&
                   id == mec.id;
        }
    }
    
}
