using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supply_card
{
    internal class supply
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Color { get; set; }

        public supply()
        {
            Id = Guid.NewGuid();
        }
    }
}
