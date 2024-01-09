using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class Holiday
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string PopularName { get; set; }
        public State State { get; set; }
    }
}
