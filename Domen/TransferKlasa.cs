using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj=1,
        PrijaviKorisnika = 2,
        KreirajTim = 3,
        ZapamtiTim = 4,
        PretraziTimove = 5,
        PronadjiTim = 6,
        ObrisiTim = 7,
        VratiListuOdbojkaskihLiga = 8,
        VratiListuTimova = 9,
        KreirajKolo = 10,
        ZapamtiKolo = 11,
        PretraziKola = 12,
        PronadjiKolo = 13,
        ObrisiKolo = 14,
        VratiListuHala = 15,
        PronadjiMec = 16
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
