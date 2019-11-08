using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraftlogs
{
    class Jatekos
    {
        int parse;
        string nev;
        int amount;
        int iLvl;
        int iLvlSzazalek;
        double activeSzazalek;
        double DPS;

        public Jatekos(int parse, string nev, int amount, int iLvl, int iLvlSzazalek, double activeSzazalek, double dPS)
        {
            this.parse = parse;
            this.nev = nev;
            this.amount = amount;
            this.iLvl = iLvl;
            this.iLvlSzazalek = iLvlSzazalek;
            this.activeSzazalek = activeSzazalek;
            this.DPS = dPS;
        }

       /* public override string ToString()
        {
            return base.ToString();
        }*/
    }
}
