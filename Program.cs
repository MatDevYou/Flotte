namespace Flotte;

class Program
{
    static void Main(string[] args)
    {
        Auto auto = new Auto
        {
            Marca = "Fiat",
            Modello = "Punto",
            Anno = 2015,
            NumeroPorte = 5,
            carburante = Carburante.Benzina ,
            ConsumoCarburante = 6.5 // 6.5 litri per 100 km
        };

        Moto moto = new Moto
        {
            Marca = "Honda",
            Modello = "CB500F",
            Anno = 2018,
            HaBauletto = true,
            CapacitaSerbatoio = 17, // litri
            ConsumoCarburante = 3.5 // litri per 100 km
        };

        Camion camion = new Camion
        {
            Marca = "Scania",
            Modello = "R450",
            Anno = 2020,
            CapacitaCarico = 18.5, // tonnellate
            CaricoAttuale = 10 // tonnellate
        };


        Console.WriteLine(auto.ToString());
        auto.ApriBagagliaio();
        auto.ChiudiBagagliaio();
        auto.Avvia();
        Console.WriteLine($"Consumo per 150 km: {auto.CalcolaCarburante(150)} litri.");
        Console.WriteLine($"È un'auto d'epoca? {auto.AutoEpoca()}");
        auto.Ferma();

        Console.WriteLine(moto.ToString());
        moto.AlzaCavalletto();
        moto.AbbassaCavalletto();
        moto.Avvia();
        Console.WriteLine($"Autonomia della moto: {moto.CalcolaAutonomia()} km.");
        moto.Ferma();

        Console.WriteLine(camion.ToString());
        camion.Carica(5);
        camion.Scarica(3);
        camion.Avvia();
        Console.WriteLine($"Il camion è in sovraccarico? {camion.Sovraccarico()}");
        Console.WriteLine($"Carico massimo trasportabile: {camion.Massimo()} tonnellate.");
        camion.Ferma();
    }
}


