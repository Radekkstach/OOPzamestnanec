using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnanec
{
    class Zamestnanec
    {
        private string jmeno;
        private string prijmeni;
        private DateTime datumNastupu;
        private int hodinovaMzda;
        private int odpracHodiny = 0;

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
        }

        public int HodinovaMzda
        {
            get
            {
                return hodinovaMzda;
            }
        }

        public TimeSpan PocetDni()
        {
            TimeSpan pocet;
            pocet = DateTime.Now - datumNastupu;
            return pocet;
        }

        public void OdpracjHodiny(int x)
        {
            odpracHodiny += x;         
            
        }

        public int VypocitaMzdu()
        {
            int mzda;
            mzda = hodinovaMzda * odpracHodiny;
            return mzda;
        }

        public string Vypis()
        {
            return jmeno + " " + prijmeni + " s hodinovou mzdou" + hodinovaMzda + " a " + odpracHodiny + " odpracovanych hodin\nMa mzdu " + VypocitaMzdu() + "\nPracuje " + Math.Round(PocetDni().TotalDays,0) + " dni";
        }


    }
}
