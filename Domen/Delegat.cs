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
   public class Delegat: OpstiDomenskiObjekat
    {
        int id;
        string ime;
        string prezime;
        string korisnickoIme;
        string korisnickaSifra;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string KorisnickaSifra { get => korisnickaSifra; set => korisnickaSifra = value; }

        public override string ToString()
        {
            return ime+" "+prezime; 
        }

        [Browsable(false)]
        public string nazivTabele => "Delegat";
        [Browsable(false)]
        public string primarniKljuc => "delegatID";
        [Browsable(false)]
        public string uslovPrimarni => "delegatID = "+Id;
        [Browsable(false)]
        public string uslovOstalo => "korisnickoIme = '"+KorisnickoIme+"'  and korisnickaSifra = '"+KorisnickaSifra+"'";
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Delegat d = new Delegat();

            d.Id = Convert.ToInt32(red["delegatID"]);
            d.Ime = red["ime"].ToString();
            d.Prezime = red["prezime"].ToString();
            d.KorisnickoIme = red["korisnickoIme"].ToString();
            d.KorisnickaSifra = red["korisnickaSifra"].ToString();

            return d;
        }
    }
}
