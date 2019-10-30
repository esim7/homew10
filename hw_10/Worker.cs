using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    public class Worker : Entity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public int Wage { get; set; }
        public string Position { get; set; }
        public Boss Boss { get; set; }
        public WorkOffice WorkOffice { get; set; }
    }
}
