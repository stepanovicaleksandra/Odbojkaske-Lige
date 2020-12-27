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
    public class Tim : OpstiDomenskiObjekat
    {
        int id;
        string naziv;
        string mesto;
        Liga liga;
        Delegat delegat;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Mesto { get => mesto; set => mesto = value; }
        public Liga Liga { get => liga; set => liga = value; }
        [Browsable(false)]
        public Delegat Delegat { get => delegat; set => delegat = value; }

        public override string ToString()
        {
            return naziv;
        }

        [Browsable(false)]
        public string nazivTabele => "Tim";
        [Browsable(false)]
        public string primarniKljuc => "timID";
        [Browsable(false)]
        public string uslovPrimarni => "timID= "+id;
        [Browsable(false)]
        public string Uslov = "Naziv is null";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => "naziv='"+naziv+"', mesto='"+mesto+"', ligaID="+liga.Id+", delegatID="+delegat.Id+"" ;
        [Browsable(false)]
        public string unos => "(timID) values ("+id+")";


        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Tim t = new Tim();
                     
            t.Id =Convert.ToInt32(red["timID"]);
            t.Mesto = red["mesto"].ToString();
            t.Naziv = red["naziv"].ToString();
            Liga l = new Liga();
            l.Id = Convert.ToInt32(red["ligaID"]);
            t.Liga = l;
            Delegat d = new Delegat();
            d.Id = Convert.ToInt32(red["delegatID"]);
            t.Delegat = d;

            return t;
        }

        public override bool Equals(object obj)
        {
            var tim = obj as Tim;
            return tim != null &&
                   id == tim.id;
        }
    }
}
