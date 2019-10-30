using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    public class WorkOffice : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection <Boss> Bosses { get; set; }
    }
}
