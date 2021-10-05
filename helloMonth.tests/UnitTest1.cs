using helloMonth.AppServices;
using Xunit;

namespace helloMonth.tests
{
    public class UnitTest1
    {
        [Fact]
        public void DeveRetornarQueEhFeriado()
        {
            //arrannge
            var dia = 1;
            var mes = 1;
            var ano = 2021;

            //act
            var resultado = AppService.ObterDiaDaSemana(dia, mes, ano);

            //assert
            Assert.True(resultado == "01/01/2021 00:00:00, é feriado!\n");
        }

        [Fact]
        public void DeveRetornarQueEhFinalDeSemana()
        {
            //arrannge
            var dia = 2;
            var mes = 1;
            var ano = 2021;

            //act
            var resultado = AppService.ObterDiaDaSemana(dia, mes, ano);

            //assert
            Assert.True(resultado == "02/01/2021 00:00:00, é final de semana!\n");
        }

        [Fact]
        public void DeveRetornarQueEhDiaDeSemana()
        {
            //arrannge
            var dia = 5;
            var mes = 10;
            var ano = 2021;

            //act
            var resultado = AppService.ObterDiaDaSemana(dia, mes, ano);

            //assert
            Assert.True(resultado == "05/10/2021 00:00:00, é um dia de semana\n");
        }
    }
}
