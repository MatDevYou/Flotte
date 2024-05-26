using System;
namespace Flotte
{
    internal class Camion : Veicoli
	{
		public double CapacitaCarico { get; set; }
        public double CaricoAttuale { get; set; }

        public override string ToString()
        {
            return  "\nCamion:" + base.ToString() + $"\nCapacita Carico: {CapacitaCarico}";
        }

        public void Carica(double peso)
        {
            CaricoAttuale += peso;
            Console.WriteLine($"Caricati {peso} tonnellate. Carico attuale {CaricoAttuale} tonnellate");
        }

        public void Scarica(double peso)
        {
            CaricoAttuale -= peso;
            Console.WriteLine($"Scaricati {peso} tonnellate. Carico attuale {CaricoAttuale} tonnellate");
        }

        public bool Sovraccarico()
        {
            return CaricoAttuale > CapacitaCarico;
        }

        public double Massimo()
        {
            return CapacitaCarico;
        }
    }
}

