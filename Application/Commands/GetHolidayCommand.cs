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
    }
}
