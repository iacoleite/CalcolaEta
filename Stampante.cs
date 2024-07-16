using System;

namespace CalcolaEta;
    class Stampante {
        public void stampare(string nome, string eta) {
            Console.WriteLine("\n");
            int annoAttuale = DateTime.Now.Year;
            Console.WriteLine($"Ciao, {nome}! L'anno attuale è {annoAttuale} e la tua età oggi è:");
            Console.WriteLine(eta);
        }

    }
