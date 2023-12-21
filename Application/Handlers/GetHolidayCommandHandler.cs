using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;


namespace Application.Handlers
{
    public class GetHolidayCommandHandler : IRequestHandler<GetHolidayCommand, string>
    {
        public GetHolidayCommandHandler()
        {

        }

        public async Task<string> Handle(GetHolidayCommand request, CancellationToken cancellationToken)
        {
            var holidays = new List<Holiday>()
            {
                new Holiday { Date = DateTime.ParseExact("01-01", "dd-MM", CultureInfo.CurrentCulture), Name =  "Fraternidade Universal", PopularName = "Ano novo"}, //Fixo
                //new Holiday { Date = DateTime.Parse("02-27"), Name=  "Carnaval"},  //Pascoa - 47
                new Holiday { Date = DateTime.ParseExact("13-04", "dd-MM", CultureInfo.CurrentCulture), Name =  "Paixão de Cristo"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("21-04", "dd-MM", CultureInfo.CurrentCulture), Name =  "Tiradentes"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("01-05", "dd-MM", CultureInfo.CurrentCulture), Name =  "Dia do Trabalho"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("30-05", "dd-MM", CultureInfo.CurrentCulture), Name =  "Corpus Christi"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("07-09", "dd-MM", CultureInfo.CurrentCulture), Name =  "Independência do Brasil"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("12-10", "dd-MM", CultureInfo.CurrentCulture), Name =  "Nossa Sr.a Aparecida - Padroeira do Brasil", PopularName = "Dia das Crianças"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("02-11", "dd-MM", CultureInfo.CurrentCulture), Name =  "Finados"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("15-11", "dd-MM", CultureInfo.CurrentCulture), Name =  "Proclamação da República"}, //Fixo
                new Holiday { Date = DateTime.ParseExact("25-12", "dd-MM", CultureInfo.CurrentCulture), Name =  "Natal"}, //Fixo
           };

            await Task.Delay(1, cancellationToken);
            return holidays.Find(f => f.Date == DateTime.ParseExact(request.Date, "dd-MM", CultureInfo.CurrentCulture)).Name;
        }

        private string Pascoa(string year)
        {            
            Dictionary<string, string> datesPascoa = new Dictionary<string, string>()
            {
                {"1", "14-04" },
                {"2", "03-04" },
                {"3", "23-03" },
                {"4", "11-04" },
                {"5", "31-03" },
                {"6", "18-04" },
                {"7", "08-04" },
                {"8", "28-03" },
                {"9", "16-04" },
                {"10", "05-04" },
                {"11", "25-03" },
                {"12", "13-04" },
                {"13", "12-04" },
                {"14", "22-03" },
                {"15", "10-04" },
                {"16", "30-03" },
                {"17", "12-04" },
                {"18", "07-04" },
                {"19", "27-03" },
            };

            string goldNumber = (int.Parse(year) % 19).ToString();
            datesPascoa.TryGetValue(goldNumber, out string pascoa);

            return pascoa;
        }
    }
}
