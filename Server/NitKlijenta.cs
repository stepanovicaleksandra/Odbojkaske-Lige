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
using Server.SO.DelegatSO;
using Server.SO.TimSO;
using Server.SO.KoloSO;

namespace Server
{
    class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradi;
            new Thread(ts).Start();
        }

        void obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        case Operacije.PrijaviKorisnika:
                            PrijaviKorisnika pk = new PrijaviKorisnika();
                            transfer.Rezultat = pk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajTim:
                            KreirajTim kt = new KreirajTim();
                            transfer.Rezultat = kt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiTim:
                            ZapamtiTim zt = new ZapamtiTim();
                            transfer.Rezultat = zt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziTimove:
                            PretraziTimove pt = new PretraziTimove();
                            transfer.Rezultat = pt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PronadjiTim:
                            PronadjiTim pronTim = new PronadjiTim();
                            transfer.Rezultat = pronTim.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiTim:
                            ObrisiTim ot = new ObrisiTim();
                            transfer.Rezultat = ot.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;


                        case Operacije.VratiListuOdbojkaskihLiga:
                            SO.KoloSO.VratiListuLiga vl = new SO.KoloSO.VratiListuLiga();
                            transfer.Rezultat = vl.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiListuTimova:
                            VratiListuTimova vlt = new VratiListuTimova();
                            transfer.Rezultat = vlt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajKolo:
                            KreirajKolo kk = new KreirajKolo();
                            transfer.Rezultat = kk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiKolo:
                            ZapamtiKolo zk = new ZapamtiKolo();
                            transfer.Rezultat = zk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziKola:
                            PretraziKola prk = new PretraziKola();
                            transfer.Rezultat = prk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PronadjiKolo:
                            PronadjiKolo pronKolo = new PronadjiKolo();
                            transfer.Rezultat = pronKolo.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiKolo:
                            ObrisiTim ok = new ObrisiTim();
                            transfer.Rezultat = ok.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiListuHala:
                            VratiListuHala vlh = new VratiListuHala();
                            transfer.Rezultat = vlh.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PronadjiMec:
                            PronadjiMec prm = new PronadjiMec();
                            transfer.Rezultat = prm.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Server.listaTokova.Remove(tok);
            }
        }
    }
}
