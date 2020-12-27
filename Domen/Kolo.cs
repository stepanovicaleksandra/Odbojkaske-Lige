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
   public class Kolo:OpstiDomenskiObjekat
    {
        int id;
        string naziv;
        DateTime datumOd;
        DateTime datumDo;
        Liga liga;
        Delegat delegat;
        BindingList<Mec> mecevi;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        [DisplayName("Datum početka")]
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        [DisplayName("Datum završetka")]
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }
        [Browsable(false)]
        public Liga Liga { get => liga; set => liga = value; }
        [Browsable(false)]
        public Delegat Delegat { get => delegat; set => delegat = value; }
        public BindingList<Mec> Mecevi { get => mecevi; set => mecevi = value; }

        public Kolo()
        {
            mecevi = new BindingList<Mec>();
        }

        [Browsable(false)]
        public string nazivTabele => "Kolo";
        [Browsable(false)]
        public string primarniKljuc => "koloID";
        [Browsable(false)]
        public string uslovPrimarni => "koloID= " +Id;
        [Browsable(false)]
        public string Uslov = null;
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => "naziv='"+Naziv+"', datumOd= '"+ DatumOd.ToString("yyyy-MM-dd") + "', datumDo='"+DatumDo.ToString("yyyy-MM-dd") + "', ligaID= "+Liga.Id+", delegatID="+Delegat.Id+"";
        [Browsable(false)]
        public string unos => "(koloID) values ("+Id+")";


        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Kolo k = new Kolo();
            k.Id = Convert.ToInt32(red["koloID"]);
            k.Naziv = red["naziv"].ToString();
            k.DatumOd = Convert.ToDateTime(red["datumOd"]);
            k.DatumDo = Convert.ToDateTime(red["datumDo"]);
            Liga l = new Liga();
            l.Id = Convert.ToInt32(red["ligaID"]);
            k.Liga = l;
            Delegat d = new Delegat();
            d.Id = Convert.ToInt32(red["delegatID"]);
            k.Delegat = d;

            return k;
        }
    }
}
