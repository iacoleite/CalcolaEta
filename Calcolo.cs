    using System.Dynamic;

namespace CalcolaEta;

class Calcolo {
    public int GetEta(int quandoEra, int quantoAveva) {
        int annoOggi = DateTime.Now.Year;
        int annoNascimento = quandoEra - quantoAveva;
        int etaCalcolata = annoOggi - annoNascimento;
        return etaCalcolata;
    }
}
