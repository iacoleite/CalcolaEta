using System.Dynamic;

namespace CalcolaEta;

class Program {
    
    static void Main(string[] args) {
        InputHandler inputHandler = new InputHandler();
        string[] informazioni = inputHandler.GetInput(args);
        
        Calcolo calculatrice = new Calcolo();
        int eta = calculatrice.GetEta(int.Parse(informazioni[1]), int.Parse(informazioni[2]));

        Stampante stampante = new Stampante();

        stampante.stampare(informazioni[0], eta.ToString());

    }
}
