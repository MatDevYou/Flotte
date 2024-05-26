using System;
namespace Flotte
{
	internal class Auto:Veicoli
	{
		public int NumeroPorte { get; set; }
        public double ConsumoCarburante { get; set; }

        public void ApriBagagliaio()
        {
            Console.WriteLine("\nApri bagagliaio!!");
        }

        public void ChiudiBagagliaio()
        {
            Console.WriteLine("\nChiudi bagagliaio!!");
        }

        public double CalcolaCarburante(double kilometri)
        {
            return (ConsumoCarburante / 100) * kilometri;
        }

        public override string ToString()
        {
            return "\nAuto" + base.ToString() + $"\nNumero Porte : {NumeroPorte}";
        }

        public bool AutoEpoca()
        {
            return CalcoloEta() > 30;
        }
    }
}

