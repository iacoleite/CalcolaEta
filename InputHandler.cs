namespace CalcolaEta;
    class InputHandler {

        string? nome;
        int annoCheFu;
        int etaDaPiccolo;
        int annoCorrente;

        public string[] GetInput(string[] args) {
            try {
                nome = args[0];
                annoCheFu = int.Parse(args[1]);
                etaDaPiccolo = int.Parse(args[2]);
                annoCorrente = DateTime.Now.Year;

                string[] teste = {nome, annoCheFu.ToString(), etaDaPiccolo.ToString(), annoCorrente.ToString()};

                return teste;

            } catch (Exception e) {

                Console.WriteLine("Era meglio mettere i argumenti: nome, anno che fu, eta da piccolo... Ora ti faccio vedere il messaggio di errore:");
                Console.WriteLine("\n");
                Console.WriteLine(e);
                Console.WriteLine("\n");

                Console.WriteLine("Va bene! Facciamo adesso!... Il suo nome è... ?");

                nome = Console.ReadLine();

                while (string.IsNullOrEmpty(nome)) {
                    Console.WriteLine("Va bene! Facciamo adesso!... Il suo nome è... ?");
                    nome = Console.ReadLine();
                }
                
                Console.WriteLine("Quando ha cominciato?");
                string? annoCheFuString = Console.ReadLine();

                //set a int
                int a =0;
                // verify if is not null or empty OR that can parse the string to int and put in the variable int "a" 
                while (string.IsNullOrEmpty(annoCheFuString) || !int.TryParse(annoCheFuString, out a)) {
                    Console.WriteLine("Quando ha cominciato?");
                    annoCheFuString = Console.ReadLine();
                }

                int annoCheFu = int.Parse(annoCheFuString);

                Console.WriteLine("E avevi quanti anni quando ha cominciato?");
                string? etaDaPiccoloString = Console.ReadLine();
                // verify if is not null or empty OR that can parse the string to int and put in the variable int "a" 
                while (string.IsNullOrEmpty(etaDaPiccoloString)|| !int.TryParse(etaDaPiccoloString, out a)) {
                    Console.WriteLine("E avevi quanti anni quando ha cominciato?");
                    etaDaPiccoloString = Console.ReadLine();
                }

                int etaDaPiccolo = int.Parse(etaDaPiccoloString);
                int annoCorrente = DateTime.Now.Year;

                string[] teste = {nome, annoCheFu.ToString(), etaDaPiccolo.ToString(), annoCorrente.ToString()};
                return teste;
        }
    }

    public string? GetNome() {
        return nome;
    }

    public string? GetAnnoCheFu() {
        return annoCheFu.ToString();
    } 

    public string? GetEtaDaPiccolo() {
        return etaDaPiccolo.ToString();
    }

    public string GetAnnoCorrente() {
        return annoCorrente.ToString();
    }
}