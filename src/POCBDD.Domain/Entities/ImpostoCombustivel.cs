namespace POCBDD.Domain.Entities
{
    public sealed class ImpostoCombustivel : Imposto
    {
        public decimal Aliquota { get; private set; }
        public decimal Valor { get; private set; }

        public ImpostoCombustivel(decimal fatorMultiplicador, decimal fatorDivisor, decimal aliquota, decimal valor)
            : base(fatorMultiplicador, fatorDivisor)
        {
            Aliquota = aliquota;
            Valor = valor;
        }

        public override decimal Calcular()
        {
            return decimal.Round((((Valor * Aliquota) * FatorMultiplicador) / FatorDivisor), 2, MidpointRounding.AwayFromZero);
        }
    }
}
