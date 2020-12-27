using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKI
    {
        public static Komunikacija komunikacija;
        public static Delegat delegat;
        public static Tim tim;
        public static Kolo kolo;
        public static Mec m;


        public static bool PoveziSeNaServer()
        {
            if (komunikacija == null) komunikacija = new Komunikacija();
            return komunikacija.poveziSeNaServer();           
        }

        internal static void PopuniPoljaMeca(ComboBox cmbDomacin, ComboBox cmbGost, TextBox txtDatumVreme, ComboBox cmbHala, ComboBox cmbStatus, TextBox txtSetovaDomacin, TextBox txtSetovaGost, DataGridView dataGridView1, ComboBox cmbLiga)
        {
            dataGridView1.DataSource = m.Setovi;
            Liga l = cmbLiga.SelectedItem as Liga; 
            Tim t = new Tim();
            t.Uslov = "ligaID= " + l.Id;
            cmbDomacin.DataSource = komunikacija.PretraziTimove(t);
            if(kolo.Liga.Equals(cmbLiga.SelectedItem as Liga)) cmbDomacin.Text = m.Domacin.ToString();


            Liga li = cmbLiga.SelectedItem as Liga;
            Tim ti = new Tim();
            ti.Uslov = "ligaID= " + li.Id;
            cmbGost.DataSource = komunikacija.PretraziTimove(t);
            if (kolo.Liga.Equals(cmbLiga.SelectedItem as Liga)) cmbGost.Text = m.Gost.ToString();

            txtDatumVreme.Text = m.DatumVreme.ToString("dd.MM.yyyy HH:mm");
            popuniCmbHala(cmbHala);
            cmbHala.Text = m.Hala.ToString();
            popuniCmbStatus(cmbStatus);
            cmbStatus.Text = m.Status.ToString();
            txtSetovaDomacin.Text = m.SetovaDomacin.ToString();
            txtSetovaGost.Text = m.SetovaGost.ToString();

            
        }

        internal static bool DodajDodatniMec(ComboBox cmbDomacin, ComboBox cmbGost, TextBox txtDatumVreme, ComboBox cmbHala, ComboBox cmbStatus, DateTimePicker dtpDatumDo, DateTimePicker dtpDatumOd)
        {
            m = new Mec();
            m.Id = kolo.Mecevi.Count + 1;
            m.KoloID = kolo.Id;
            m.Domacin = cmbDomacin.SelectedItem as Tim;
            if (m.Domacin == null)
            {
                MessageBox.Show("Niste izabrali domaćina!");
                return false;
            }
            m.Gost = cmbGost.SelectedItem as Tim;
            if (m.Gost == null)
            {
                MessageBox.Show("Niste izabrali gosta!");
                return false;
            }
            if (m.Domacin.Equals(m.Gost))
            {
                MessageBox.Show("Domaćin i gost moraju biti različiti timovi!");
                return false;
            }
            if (txtDatumVreme.Text == "")
            {
                MessageBox.Show("Niste uneli datum i vreme");
                return false;
            }

            try
            {
                m.DatumVreme = DateTime.ParseExact(txtDatumVreme.Text, "dd.MM.yyyy HH:mm", null);

                if (m.DatumVreme.Date < dtpDatumOd.Value.Date || m.DatumVreme.Date > dtpDatumDo.Value.Date)
                {
                    MessageBox.Show("Datum meča mora biti između datuma početka i kraja kola!");
                    return false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste pravilno uneli datum i vreme!");
                return false;
            }
            m.Hala = cmbHala.SelectedItem as Hala;
            if (m.Hala == null)
            {
                MessageBox.Show("Niste izabrali halu!");
                return false;
            }
            try
            {
                m.Status = (Status)Enum.Parse(typeof(Status), cmbStatus.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali status!");
                return false;
            }

            foreach (Mec mec in kolo.Mecevi)
            {
                if ((mec.Gost.Equals(m.Domacin) || mec.Domacin.Equals(m.Domacin)) && (mec.Gost.Equals(m.Gost) || mec.Domacin.Equals(m.Gost)))
                {
                    MessageBox.Show("Izabrani par je već unet za ovo kolo");
                    return false;
                }
                if (mec.Gost.Equals(m.Domacin) || mec.Domacin.Equals(m.Domacin))
                {
                    MessageBox.Show("Tim domaćin je već unet za ovo kolo");
                    return false;
                }
                if (mec.Gost.Equals(m.Gost) || mec.Domacin.Equals(m.Gost))
                {
                    MessageBox.Show("Tim gost je već unet za ovo kolo");
                    return false;
                }

            }
            kolo.Mecevi.Add(m);
            MessageBox.Show("Novi meč je uspešno dodat!");
            return true;


        }

        internal static bool IzmeniKolo(ComboBox cmbLiga, DateTimePicker dtpDatumDo, TextBox txtNaziv, DateTimePicker dtpDatumOd)
        {
            kolo.Delegat = delegat;
            kolo.Liga = cmbLiga.SelectedItem as Liga;
            if (kolo.Liga == null)
            {
                MessageBox.Show("Niste izabrali ligu!");
                return false;
            }

            kolo.DatumOd = dtpDatumOd.Value;
            if (kolo.DatumOd == null)
            {
                MessageBox.Show("Niste izabrali datum početka kola!");
                return false;
            }
            kolo.Naziv = txtNaziv.Text;
            if (string.IsNullOrEmpty(kolo.Naziv))
            {
                MessageBox.Show("Niste uneli naziv kola!");
                return false;
            }
            kolo.DatumDo = dtpDatumDo.Value;
            if (kolo.DatumDo == null)
            {
                MessageBox.Show("Niste izabrali datum završetka kola!");
                return false;
            }

            object rez = komunikacija.ZapamtiKolo(kolo);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti kolo");
                return false;
            }

            MessageBox.Show("Sistem je uspešno zapamtio kolo!");
            return true;
        }

        internal static bool SacuvajMec(ComboBox cmbDomacin, ComboBox cmbGost, ComboBox cmbHala, ComboBox cmbStatus, TextBox txtDatumVreme, TextBox txtSetovaDomacin, TextBox txtSetovaGost, DataGridView dataGridView1, DateTimePicker dtpDatumOd, DateTimePicker dtpDatumDo, ComboBox cmbLiga)
        { 
           
            m.Domacin = cmbDomacin.SelectedItem as Tim;
            if(m.Domacin==null)
            {
                MessageBox.Show("Niste izabrali domaćina!");
                return false;
            }
            m.Gost = cmbGost.SelectedItem as Tim;
            if (m.Gost == null)
            {
                MessageBox.Show("Niste izabrali gosta!");
                return false;
            }
            if (m.Domacin.Equals(m.Gost))
            {
                MessageBox.Show("Domaćin i gost moraju biti različiti timovi!");
                return false;
            }
            if (txtDatumVreme.Text == "")
            {
                MessageBox.Show("Niste uneli datum i vreme");
                return false;
            }

            try
            {
                m.DatumVreme = DateTime.ParseExact(txtDatumVreme.Text, "dd.MM.yyyy HH:mm", null);

                if (m.DatumVreme.Date < dtpDatumOd.Value.Date || m.DatumVreme.Date > dtpDatumDo.Value.Date)
                {
                    MessageBox.Show("Datum meča mora biti u između datuma početka i kraja kola!");
                    return false; ;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste pravilno uneli datum i vreme!");
                return false; ;
            }
            m.Hala = cmbHala.SelectedItem as Hala;
            if (m.Hala == null)
            {
                MessageBox.Show("Niste izabrali halu!");
                return false ;
            }
            try
            {
                m.Status = (Status)Enum.Parse(typeof(Status), cmbStatus.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali status!");
                return false;
            }

            foreach (Mec mec in kolo.Mecevi)
            {
                if (mec.Equals(m)) continue;
                if ((mec.Gost.Equals(m.Domacin) || mec.Domacin.Equals(m.Domacin)) && (mec.Gost.Equals(m.Gost) || mec.Domacin.Equals(m.Gost)))
                {
                    MessageBox.Show("Izabrani par je već unet za ovo kolo!");
                    return false;
                }
                if (mec.Gost.Equals(m.Domacin) || mec.Domacin.Equals(m.Domacin))
                {
                    MessageBox.Show("Tim domaćin je već unet za ovo kolo!");
                    return false;
                }
                if (mec.Gost.Equals(m.Gost) || mec.Domacin.Equals(m.Gost))
                {
                    MessageBox.Show("Tim gost je već unet za ovo kolo!");
                    return false;
                }

            }

            try
            {
                m.SetovaDomacin = Convert.ToInt32(txtSetovaDomacin.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Broj setova domaćina nije ispravno unet!");
                return false;
            }

            try
            {
                m.SetovaGost = Convert.ToInt32(txtSetovaGost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Broj setova gosta nije ispravno unet!");
                return false;

            }

            if (m.Status == Status.odigran && m.Setovi.Count == 0)
            {
                MessageBox.Show("Meč nije odigran! Promenite status meča. ");
                return false;
            }
            if (m.SetovaDomacin<3 && m.SetovaGost<3 && m.Status!=Status.prekinut && m.Setovi.Count!=0)
            {
                MessageBox.Show("Meč nije regularno odigran! Promenite status meča. ");
                return false;
            }

            if((m.SetovaDomacin==3 || m.SetovaGost==3)&& m.Status!=Status.odigran)
            {
                MessageBox.Show("Meč je regularno odigran! Promenite status meča.");
                return false;
            }

           foreach(Set s in m.Setovi)
            {
                if (s.Id<5 && s.PoenaDomacin < 25 && s.PoenaGost < 25 && m.Status != Status.prekinut)
                {
                    MessageBox.Show("Pogrešno unet rezultat!");
                    return false;
                }

                if (s.Id < 5 && (s.PoenaDomacin >= 25 || s.PoenaGost>=25) && Math.Abs(s.PoenaDomacin-s.PoenaGost)>2)
                {
                    MessageBox.Show("Pogrešno unet rezultat!");
                    return false;
                }

                if (s.Id == 5 && (s.PoenaDomacin >= 15 || s.PoenaGost >= 15) && Math.Abs(s.PoenaDomacin - s.PoenaGost) > 2)
                {
                    MessageBox.Show("Pogrešno unet rezultat!");
                    return false;
                }
            }


            return true;

        }

        internal static void IzracunajRezultat(TextBox txtSetovaDomacin, TextBox txtSetovaGost, DataGridView dataGridView1)
        {
         
            int setD = 0;
            int setG = 0;
            foreach(DataGridViewRow red in dataGridView1.Rows)
            {
                try
                {
                    red.Cells[0].Value = red.Index + 1;
                    Set s = red.DataBoundItem as Set;
                    if (s.PoenaDomacin > s.PoenaGost) setD++;
                    else
                    {
                        setG++;
                    }
                   
            
                }
                catch (Exception)
                {

                   
                }

            }

            txtSetovaDomacin.Text = setD.ToString();
            txtSetovaGost.Text = setG.ToString();
            if (setD>2||setG>2)
            {
                dataGridView1.AllowUserToAddRows = false;
            }
            else dataGridView1.AllowUserToAddRows = true;
        }

        internal static void PopuniPoljaKola(ComboBox cmbLiga, DateTimePicker dtpDatumDo, DateTimePicker dtpDatumOd, TextBox txtNaziv, TextBox txtDelegat, DataGridView dataGridView1)
        {
            dtpDatumOd.Value = kolo.DatumOd;
            dtpDatumDo.Value = kolo.DatumDo;
            txtNaziv.Text = kolo.Naziv;
            txtDelegat.Text = kolo.Delegat.ToString();
            dataGridView1.DataSource = kolo.Mecevi;
            PopuniCmbLiga(cmbLiga);
            cmbLiga.Text = kolo.Liga.ToString();

        }

        internal static bool IzaberiMec(DataGridView dataGridView1)
        {
            try
            {
                 m = dataGridView1.CurrentRow.DataBoundItem as Mec;
              //  mec = komunikacija.PronadjiMec(mec) as Mec;
                if(m==null)
                {
                    MessageBox.Show("Sistem ne može da učita podatke o meču!");
                    return false;
                }
                MessageBox.Show("Sistem je uspešno učitao podatke o meču!");
                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali meč!");
                return false;
            }
           

        }

        internal static bool KreirajKolo(TextBox txtSifra, DataGridView dataGridView1)
        {
            kolo = komunikacija.KreirajKolo() as Kolo;

            if(kolo==null)
            {
                MessageBox.Show("Sistem ne može da kreira novo kolo!");
                return false;
            }

            else
            {
                MessageBox.Show("Sistem je uspešno kreirao novo kolo!");
                txtSifra.Text = kolo.Id.ToString();
                dataGridView1.DataSource = kolo.Mecevi;

                return true;
            }


        }

        internal static bool IzaberiKolo(DataGridView dataGridView1)
        {
            try
            {
                kolo = dataGridView1.CurrentRow.DataBoundItem as Kolo;
                kolo = komunikacija.PronadjiKolo(kolo) as Kolo;

                if (kolo == null)
                {
                    MessageBox.Show("Sistem ne može da učita kolo");
                    return false;
                }

                MessageBox.Show("Sistem je uspešno učitao podatke o kolu!");
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali kolo!");
                return false;
            }
           
        }

        internal static void PretraziKola(ComboBox cmbLiga, DataGridView dataGridView1)
        {
            kolo = new Kolo();
            Liga liga = cmbLiga.SelectedItem as Liga;
            kolo.Uslov = "ligaID= " + liga.Id;
            List<Kolo> kola = komunikacija.PretraziKola(kolo) as List<Kolo>;
            dataGridView1.DataSource = kola;

            if(kola==null || kola.Count==0)
            {
                MessageBox.Show("Sistem ne može da nađe kola!");
                return;
            }

            MessageBox.Show("Sistem je našao kola!");



        }

        internal static void OcistiGrid(DataGridView dataGridView1)
        {
            kolo.Mecevi.Clear();
        }

        internal static void DodajMec(ComboBox cmbDomacin, ComboBox cmbGost, TextBox txtDatumVreme, ComboBox cmbHala, ComboBox cmbStatus, DateTimePicker dtpDatumDo, DateTimePicker dtpDatumOd, ComboBox cmbLiga)
        {
            m = new Mec();
            m.Id = kolo.Mecevi.Count + 1;
            m.KoloID = kolo.Id;
            Liga l = cmbLiga.SelectedItem as Liga;
            if(l==null)
            {
                MessageBox.Show("Niste odabrali ligu!");
                return;
            }
            m.Domacin = cmbDomacin.SelectedItem as Tim;
            if(m.Domacin==null)
            {
                MessageBox.Show("Niste izabrali domaćina!");
                return;
            }
            m.Gost = cmbGost.SelectedItem as Tim;
            if (m.Gost == null)
            {
                MessageBox.Show("Niste izabrali gosta!");
                return;
            }
            if(m.Domacin.Equals(m.Gost))
            {
                MessageBox.Show("Domaćin i gost moraju biti različiti timovi!");
                return;
            }
            if (txtDatumVreme.Text == "")
            {
                MessageBox.Show("Niste uneli datum i vreme");
                return;
            }
          
            try
            {
              m.DatumVreme = DateTime.ParseExact(txtDatumVreme.Text, "dd.MM.yyyy HH:mm", null);

              if(m.DatumVreme.Date<dtpDatumOd.Value.Date || m.DatumVreme.Date > dtpDatumDo.Value.Date)
                {
                    MessageBox.Show("Datum meča mora biti između datuma početka i kraja kola!");
                    return;
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Niste pravilno uneli datum i vreme!");
                return;
            }
            m.Hala = cmbHala.SelectedItem as Hala;
            if(m.Hala==null)
            {
                MessageBox.Show("Niste izabrali halu!");
                return;
            }
            try
            {
                m.Status = (Status)Enum.Parse(typeof(Status), cmbStatus.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali status!");
                return;
            }

            foreach(Mec mec in kolo.Mecevi)
            {
                if ((mec.Gost.Equals(m.Domacin) || mec.Domacin.Equals(m.Domacin)) && (mec.Gost.Equals(m.Gost) || mec.Domacin.Equals(m.Gost)))
                {
                    MessageBox.Show("Izabrani par je već unet za ovo kolo");
                    return;
                }
                if (mec.Gost.Equals(m.Domacin)|| mec.Domacin.Equals(m.Domacin))
                {
                    MessageBox.Show("Tim domaćin je već unet za ovo kolo");
                    return;
                }
                if (mec.Gost.Equals( m.Gost )|| mec.Domacin.Equals(m.Gost))
                {
                    MessageBox.Show("Tim gost je već unet za ovo kolo");
                    return;
                }
               
            }
            kolo.Mecevi.Add(m);
            

        }

        internal static void popuniCmbStatus(ComboBox cmbStatus)
        {
            List<string> listaStatusa=Enum.GetNames(typeof(Status)).ToList();
            foreach(string s in listaStatusa)
            {
                cmbStatus.Items.Add(s);
            }
        }

        internal static bool SacuvajKolo(ComboBox cmbLiga, TextBox txtNaziv, DateTimePicker dtpDatumOd, DateTimePicker dtpDatumDo)
        {
            kolo.Delegat = delegat;
            kolo.Liga = cmbLiga.SelectedItem as Liga;
            if(kolo.Liga==null)
            {
                MessageBox.Show("Niste izabrali ligu!");
                return false;
            }
            
            kolo.DatumOd = dtpDatumOd.Value;
            if(kolo.DatumOd==null)
            {
                MessageBox.Show("Niste izabrali datum početka kola!");
                return false;
            }
            kolo.Naziv = txtNaziv.Text;
            if(string.IsNullOrEmpty(kolo.Naziv))
            {
                MessageBox.Show("Niste uneli naziv kola!");
                return false;
            }
            kolo.DatumDo = dtpDatumDo.Value;
            if (kolo.DatumDo == null)
            {
                MessageBox.Show("Niste izabrali datum završetka kola!");
                return false;
            }

            object rez = komunikacija.ZapamtiKolo(kolo);
            
            if(rez==null)
            {
                MessageBox.Show("Sistem ne može da zapamti novo kolo");
                return false;
            }

            MessageBox.Show("Sistem je uspešno zapamtio novo kolo!");
            return true;

        }

        internal static void ObrisiMec(DataGridView dataGridView1)
        {
            try
            {
                m = dataGridView1.CurrentRow.DataBoundItem as Mec;
                kolo.Mecevi.Remove(m);
                int brojac = 1;
                foreach(Mec mec in kolo.Mecevi)
                {
                    mec.Id = brojac;
                    brojac++;
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali meč!");
            }
        }

        internal static void popuniCmbDomacin(ComboBox cmbDomacin, ComboBox cmbLiga, ComboBox cmbGost)
        {
            Liga l = cmbLiga.SelectedItem as Liga;
            Tim t = new Tim();
            t.Uslov = "ligaID= " + l.Id;
            cmbDomacin.DataSource = komunikacija.PretraziTimove(t);
           
        }

        internal static void popuniCmbGost(ComboBox cmbGost, ComboBox cmbDomacin, ComboBox cmbLiga)
        {
            Liga l = cmbLiga.SelectedItem as Liga;
            Tim t = new Tim();
            t.Uslov = "ligaID= " + l.Id;
            cmbGost.DataSource = komunikacija.PretraziTimove(t);
        }


        internal static void popuniCmbHala(ComboBox cmbHala)
        {
            cmbHala.Items.Clear();
            List<Hala> lista = komunikacija.VratiListuHala() as List<Hala>;

            foreach (Hala h in lista)
            {
                cmbHala.Items.Add(h);
            }
            cmbHala.Text = "Izaberitu halu";
        }

        internal static void PopuniDelegata(TextBox txtDelegat)
        {
            txtDelegat.Text = delegat.ToString();
        }

        internal static void PopuniPoljaTima(TextBox txtNaziv, TextBox txtMesto, ComboBox cmbLiga)
        {
            PopuniCmbLiga(cmbLiga);
            txtNaziv.Text = tim.Naziv;
            txtMesto.Text = tim.Mesto;
            cmbLiga.Text = tim.Liga.ToString();
        }

        internal static void PretraziTimove(TextBox txtNaziv, DataGridView dataGridView1)
        {
            Tim t = new Tim();
            t.Uslov = "Naziv like '%" + txtNaziv.Text + "%' or Mesto like '%" + txtNaziv.Text + "%' order by ligaID";
            List <Tim> lista= komunikacija.PretraziTimove(t) as List<Tim>;

            if(lista==null)
            {
                MessageBox.Show("Sistem ne može da nađe timove!");
            }

            dataGridView1.DataSource = lista;
            if(lista.Count==0)
            {
                MessageBox.Show("Nisu pronađeni timovi!");
            }
            else
            {
                MessageBox.Show("Sistem je pronašao timove!");
            }
        }

        internal static bool ObrisiTim()
        {
            Object rez = komunikacija.ObrisiTim(tim);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obriše tim !");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno obrisao tim !");
                return true;
            }
        }

        internal static bool PrikaziTim(DataGridView dataGridView1)
        {
            try
            {
                tim = dataGridView1.CurrentRow.DataBoundItem as Tim;
                tim = komunikacija.PronadjiTim(tim) as Tim;
                if(tim==null)
                {
                    MessageBox.Show("Sistem ne može da učita podatke o timu !");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je uspešno učitao podatke o timu!");
                    return true;
                }
                    
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali tim!");
                return false;
            }
        }

        internal static string PrikaziUlogovanogKorisnika()
        {
            return "Ulogovan je korisnik: " + delegat.ToString();
        }

        internal static bool KreirajTim(TextBox txtId, TextBox txtMesto, TextBox txtNaziv, ComboBox cmbLiga, Button btnKreirajTim, Button btnZapamtiTim)
        {
            tim = komunikacija.KreirajTim() as Tim;

            if(tim==null)
            {
                MessageBox.Show("Sistem ne može da kreira nov tim !");
                return false;
            }
            else
            {
                txtId.Text = tim.Id.ToString();
                txtMesto.Enabled = true;
                txtNaziv.Enabled = true;
                cmbLiga.Enabled = true;
                btnZapamtiTim.Enabled = true;
                btnKreirajTim.Enabled = false;
                return true;
            }
        }

        internal static void PopuniCmbLiga(ComboBox cmbLiga)
        {
            cmbLiga.Items.Clear();
            List<Liga> lista = komunikacija.VratiListuOdbojkaskihLiga() as List<Liga>;

            foreach(Liga l in lista)
            {
                cmbLiga.Items.Add(l);
            }
        }

        internal static bool ZapamtiTim(TextBox txtMesto, TextBox txtNaziv, ComboBox cmbLiga)
        {
            tim.Mesto = txtMesto.Text;
            if (string.IsNullOrEmpty(txtMesto.Text))
            {
                MessageBox.Show("Niste uneli mesto!");
                return false;
            }

            tim.Naziv = txtNaziv.Text;
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Niste uneli naziv!");
                return false;
            }

            tim.Liga = cmbLiga.SelectedItem as Liga;
            if (cmbLiga.SelectedItem==null)
            {
                MessageBox.Show("Niste izabrali Ligu!");
                return false;
            }
            tim.Delegat = delegat;
            Object rez = komunikacija.ZapamtiTim(tim);

            if(rez==null)
            {
                MessageBox.Show("Sistem ne može da zapamti nov tim !");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio tim !");
                return true;
            }
        }

        internal static void Kraj()
        {
            komunikacija.Kraj();
            komunikacija = null;
        }

        internal static bool Login(TextBox txtKorIme, TextBox txtSifra)
        {
            delegat = new Delegat();
          
            delegat.KorisnickoIme = txtKorIme.Text;
            if (string.IsNullOrEmpty(delegat.KorisnickoIme))
            {
                MessageBox.Show("Niste uneli korisnicko ime!");
                return false;
            }
            delegat.KorisnickaSifra = txtSifra.Text;
            if (string.IsNullOrEmpty(delegat.KorisnickaSifra))
            {
                MessageBox.Show("Niste uneli sifru!");
                return false;
            }

            delegat = komunikacija.PrijaviKorisnika(delegat) as Delegat;

            if(delegat==null)
            {
                MessageBox.Show("Sistem ne može da prijavi delegata !");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno prijavio delegata !");
                return true;
            }
        }
    }
}
