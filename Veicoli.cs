using System;
namespace Flotte
{
	internal abstract class Veicoli
	{
		public string? Marca { get; set;}
		public string? Modello { get; set;}
		public int Anno { get; set;}
		public double CapacitaSerbatoio { get; set; }
		public Carburante carburante { get; set; }

        public override string ToString()
        {
            return $"\n\nMarca: {Marca}," +
				$"\nModello: {Modello}," +
				$"\nAnno: {Anno}" + 
				$"\nCarburante: {carburante}"
				;
        }

        public void Avvia()
		{
			Console.WriteLine("\nIl veicolo è avviato");
		}

        public void Ferma()
        {
            Console.Write("\nIl veicolo è fermo\n");
        }

        public int CalcoloEta()
		{
			return DateTime.Now.Year - Anno;
		}

		public string Manutenzione()
		{
           return $"Il veicolo {Marca} {Modello} del {Anno} è stato sottoposto a manutenzione.";
        }


	}
}

