using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class HolidayAcre
    {      
        public List<Holiday> Holidays { get; set; }

        public HolidayAcre()
        {
            Holidays = new List<Holiday>()
            {
                new() { Date = DateTime.ParseExact("02-01", "dd-MM", CultureInfo.CurrentCulture), Name =  "Dia do Evangélico"},
                new() { Date = DateTime.ParseExact("08-03", "dd-MM", CultureInfo.CurrentCulture), Name =  "Alusivo ao dia Internacional da Mulher" },
                new() { Date = DateTime.ParseExact("15-06", "dd-MM", CultureInfo.CurrentCulture), Name =  "Aniversário do estado" },
                new() { Date = DateTime.ParseExact("05-09", "dd-MM", CultureInfo.CurrentCulture), Name =  "Dia da Amazônia" },
                new() { Date = DateTime.ParseExact("17-01", "dd-MM", CultureInfo.CurrentCulture), Name =  "Assinatura do Tratado de Petrópolis" }
            };
        }

        public Holiday GetHoliday(string date)
        {        
            return Holidays.Find(f => f.Date == DateTime.ParseExact(date, "dd-MM", CultureInfo.CurrentCulture));
        }
        
    }
}
