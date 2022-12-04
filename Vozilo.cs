using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoziloKolekcije
{
    internal class Vozilo
    {
        string model, kategorija;
        int godinaProizvodnje, brojKotaca;


        public Vozilo(string model, int godinaProizvodnje, int brojKotaca)
        {
            this.Model = model;
            this.GodinaProizvodnje = godinaProizvodnje;
            this.BrojKotaca = brojKotaca;
        }

        public Vozilo()
        {

        }
        public string Model { get => model; set => model = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }

        public override string ToString()
        {
            return "Model: " + this.model + "\t\tGodina proizvodnje: "
                + this.godinaProizvodnje + "\t\tBroj kotača: " + this.brojKotaca
                + "\t\tKategorija: " + this.kategorija + "\r\n";
        }

    }
}
