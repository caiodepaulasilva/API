using Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class GetHolidayCommand : IRequest<string>
    {
        public string Date { get; set; }
        public string State { get; set; }
    }
}
