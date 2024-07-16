namespace CalcolaEta;
class Program {
    
    static void Main(string[] args) {
        InputHandler inputHandler = new InputHandler();
        string[] informazioni = inputHandler.GetInput(args);
        string nome = informazioni[0],
               annoCheFu = informazioni[1],
               etaDaPiccolo = informazioni[2];  

        Calcolo calculatrice = new Calcolo();
        
        int eta = calculatrice.GetEta(int.Parse(annoCheFu), int.Parse(etaDaPiccolo));
        

        Stampante stampante = new Stampante();
        stampante.stampare(inputHandler.GetNome(), eta.ToString());


    }
}
