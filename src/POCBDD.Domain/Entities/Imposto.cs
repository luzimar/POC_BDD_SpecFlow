namespace POCBDD.Domain.Entities
{
    public abstract class Imposto : Entity
    {
        public decimal FatorMultiplicador { get; private set; }
        public decimal FatorDivisor { get; private set; }
        public Imposto(decimal fatorMultiplicador, decimal fatorDivisor)
        {
            FatorMultiplicador = fatorMultiplicador;
            FatorDivisor = fatorDivisor;
        }

        public abstract decimal Calcular();
    }
}
