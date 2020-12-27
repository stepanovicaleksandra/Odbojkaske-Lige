using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object PrijaviKorisnika (Delegat d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrijaviKorisnika;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object KreirajTim()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajTim;
            transfer.TransferObjekat = new Tim();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ZapamtiTim(Tim t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiTim;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PretraziTimove(Tim t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziTimove;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PronadjiTim(Tim t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiTim;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ObrisiTim(Tim t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiTim;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object VratiListuOdbojkaskihLiga()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuOdbojkaskihLiga;
            transfer.TransferObjekat = new Liga();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object KreirajKolo()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajKolo;
            transfer.TransferObjekat = new Kolo();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ZapamtiKolo(Kolo k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiKolo;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PretraziKola(Kolo k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziKola;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PronadjiKolo(Kolo k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiKolo;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ObrisiKolo(Kolo k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiKolo;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object VratiListuTimova()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuTimova;
            transfer.TransferObjekat = new Tim();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }


        internal Object VratiListuHala()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuHala;
            transfer.TransferObjekat = new Hala();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PronadjiMec(Mec m)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiMec;
            transfer.TransferObjekat = m;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

    }
}
