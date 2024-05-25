using UltimoDesafioDIO;

namespace UltimoDesafioDIOTeste
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string data = "24/05/2024";
            Calculadora calc = new Calculadora("24/05/2024");

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 6, 11)]
        public void SomarTeste(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultoadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultoadoCalculadora);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(5, 5, 0)]
        public void SubtrairTeste(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultoadoCalculadora = calc.subtrair(num1, num2);

            Assert.Equal(resultado, resultoadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 6, 30)]
        public void MultiplicarTeste(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultoadoCalculadora = calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultoadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void DividirTeste(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultoadoCalculadora = calc.dividir(num1, num2);

            Assert.Equal(resultado, resultoadoCalculadora);
        }

        [Fact]
        public void DivisaoPor0Teste()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
                );
        }

        [Fact]
        public void HistoricoTeste()
        {
            Calculadora calc = ConstruirClasse();

            calc.somar(1, 4);
            calc.somar(5, 5);
            calc.somar(10, 0);
            calc.somar(6, 6);
            
            var lista = calc.historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}