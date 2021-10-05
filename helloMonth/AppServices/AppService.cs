using Nager.Date;
using System;

namespace helloMonth.AppServices
{
    public static class AppService
    {
        public static string ObterDiaDaSemana(int dia, int mes, int ano)
        {
            var data = new DateTime(ano, mes, dia);
            var mensagem = "";

            //Verifica se o dia é feriado
            if (DateSystem.IsPublicHoliday(data, CountryCode.BR))
            {
                mensagem = $"{data}, é feriado!\n";
            }
            if (DateSystem.IsWeekend(data, CountryCode.BR))
            {
                mensagem += $"{data}, é final de semana!\n";
            }
            if(DateSystem.IsPublicHoliday(data, CountryCode.BR) == false && DateSystem.IsWeekend(data, CountryCode.BR) == false)
            {
                mensagem += $"{data}, é um dia de semana\n";
            }

            return mensagem;
        }
    }
}
