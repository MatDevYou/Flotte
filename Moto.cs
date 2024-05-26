using System;
namespace Flotte
{
	internal class Moto:Veicoli
	{
		public bool HaBauletto { get; set; }
        public double ConsumoCarburante { get; set; }

        public override string ToString()
        {
            return "\nMoto" +  base.ToString() + $"\nHa Baule: {HaBauletto}";
        }

        public void AlzaCavalletto ()
        {
            Console.WriteLine("\nCavalletto alzato!!");
        }

        public void AbbassaCavalletto()
        {
            Console.WriteLine("\nCavalletto abbassato!!");
        }

        public double CalcolaAutonomia()
        {
            return (CapacitaSerbatoio / ConsumoCarburante) / 100;
        }


    }
}

