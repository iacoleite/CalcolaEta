using System.Dynamic;

namespace CalcolaEta;

class Program {
    

    static void Main(string[] args) {
        try {
            string nome = args[0];
            int annoCheFu = int.Parse(args[1]);
            int etaDaPiccolo = int.Parse(args[2]);
            // int annoCorrente = int.Parse(args[3]);
            int annoCorrente = DateTime.Now.Year;
            
            // int annoDiNascita = annoCheFu - etaDaPiccolo;

            // int eta = annoCorrente - annoDiNascita;
            int eta = GetEta(annoCheFu, etaDaPiccolo, annoCorrente);
            Console.WriteLine("\n");
            Console.WriteLine($"Ciao, {nome}! L'anno attuale è {annoCorrente} e la tua età oggi è:");
            Console.WriteLine(eta);

        } catch (Exception e) {

            // Console.WriteLine("Deve mettere i argumenti: nome, anno che fu, eta da piccolo, anno corrente");
            Console.WriteLine("Era meglio mettere i argumenti: nome, anno che fu, eta da piccolo... Ora ti faccio vedere il messaggio di errore:");
            Console.WriteLine("\n");
            Console.WriteLine(e);
            Console.WriteLine("\n");


            Console.WriteLine("Va bene! Facciamo adesso!... Il suo nome è... ?");

            string? nome = Console.ReadLine();

            while (string.IsNullOrEmpty(nome)) {
                Console.WriteLine("Va bene! Facciamo adesso!... Il suo nome è... ?");
                nome = Console.ReadLine();
            }
            
            Console.WriteLine("Quando ha cominciato?");
            string? annoCheFuString = Console.ReadLine();
            
            while (string.IsNullOrEmpty(annoCheFuString)) {
                Console.WriteLine("Quando ha cominciato?");
                annoCheFuString = Console.ReadLine();
            }
            int annoCheFu = int.Parse(annoCheFuString);

            Console.WriteLine("E aveva quanti anni quando ha cominciato?");
            string? etaDaPiccoloString = Console.ReadLine();
            while (string.IsNullOrEmpty(etaDaPiccoloString)) {
                Console.WriteLine("E aveva quanti anni quando ha cominciato?");
                etaDaPiccoloString = Console.ReadLine();
            }
            int etaDaPiccolo = int.Parse(etaDaPiccoloString);
            
            int annoCorrente = DateTime.Now.Year;
            int eta = GetEta(annoCheFu, etaDaPiccolo, annoCorrente);
            Console.WriteLine("\n");
            Console.WriteLine($"Ciao, {nome}! L'anno attuale è {annoCorrente} e la tua età oggi è:");
            Console.WriteLine(eta);
        }
    }

    public static int GetEta(int quandoEra, int quantoAveva, int annoOggi) {
        // int annoOggi = DateTime.Now.Year;
        int annoNascimento = quandoEra - quantoAveva;
        int etaCalcolata = annoOggi - annoNascimento;
        return etaCalcolata;
    }
}
