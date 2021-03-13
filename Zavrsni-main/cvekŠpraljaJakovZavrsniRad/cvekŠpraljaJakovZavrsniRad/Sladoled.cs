using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovZavrsniRad
{
    class Sladoled
    {
        int brojKuglica;
        bool oblik;
        double cijena;
        double cijenaKuglice = 10.00;
        double cijenaOblika;

        public Sladoled(int brojKuglica, bool oblik)
        {
            this.brojKuglica = brojKuglica;
            this.oblik = oblik;
        }

        public int BrojKuglica { get => brojKuglica; set => brojKuglica = value; }
        public bool Oblik { get => oblik; set => oblik = value; }
        public double Cijena { get => cijena; set => cijena = value; }

        public double Izracun()
        {
            if (this.oblik == true)
            {
                this.cijenaOblika = 7.00;
            }
            else
            {
                this.cijenaOblika = 12.00;
            }

            cijena = cijenaOblika * brojKuglicaSladoled;
        }


        /*
private string[] oblik = { "Kornet", "Čašica", "Štapić" };



private string[] okus = { "Čokolada", "Vanilija", "Jagoda", "Stracatela", "Pistacio", "Keks" };

public string[] Oblik { get => oblik; set => oblik = value; }
public string[] Okus { get => okus; set => okus = value; }

public Sladoled (string[] Okus, string[] Oblik)
{
this.Okus = Okus;
this.Oblik = Oblik;
}
*/


    }

}
