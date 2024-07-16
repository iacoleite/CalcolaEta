namespace CalcolaEta;

class Program
{
    static void Main(string[] args)
    {
        try {
            string nome = args[0];
            int annoCheFu = int.Parse(args[1]);
            int etaDaPiccolo = int.Parse(args[2]);
            // int annoCorrente = int.Parse(args[3]);
            int annoCorrente = DateTime.Now.Year;
            
            int annoDiNascita = annoCheFu - etaDaPiccolo;

            int eta = annoCorrente - annoDiNascita;
            Console.WriteLine("\n");
            Console.WriteLine($"Ciao, {nome}! L'anno attuale è {annoCorrente} e la tua età oggi è:");
            Console.WriteLine(eta);

        } catch (Exception e) {
            // Console.WriteLine("Deve mettere i argumenti: nome, anno che fu, eta da piccolo, anno corrente");
            Console.WriteLine("Deve mettere i argumenti: nome, anno che fu, eta da piccolo");
            Console.WriteLine("\n");
            Console.WriteLine(e);
            Console.WriteLine("\n");
        }
    }
}
