namespace POCBDD.Specs.StepDefinitions
{
    [Binding]
    public class CalculoDeImpostoDeCombustivelStepDefinitions
    {
        private decimal _aliquota, _valor, _fatorMultiplicador, _fatorDivisor, _impostoCalculado;

        [Given(@"que a aliquota seja (.*)")]
        public void GivenQueAAliquotaSeja(decimal aliquota)
        {
            _aliquota = aliquota;
        }

        [Given(@"o valor seja (.*)")]
        public void GivenOValorSeja(decimal valor)
        {
            _valor = valor;
        }

        [Given(@"o fator multiplicador seja (.*)")]
        public void GivenOFatorMultiplicadorSeja(decimal fatorMultiplicador)
        {
            _fatorMultiplicador = fatorMultiplicador;
        }

        [Given(@"o fator divisor seja (.*)")]
        public void GivenOFatorDivisorSeja(decimal fatorDivisor)
        {
            _fatorDivisor = fatorDivisor;
        }

        [When(@"o imposto for calculado")]
        public void WhenOImpostoForCalculado()
        {
            _impostoCalculado = new ImpostoCombustivel(_fatorMultiplicador,
                _fatorDivisor, _aliquota, _valor).Calcular();
        }

        [Then(@"o resultado deve ser (.*)")]
        public void ThenOResultadoDeveSer(decimal resultado)
        {
            Assert.That(resultado, Is.EqualTo(_impostoCalculado));
        }
    }
}
