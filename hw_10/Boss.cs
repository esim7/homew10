using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    public class Boss : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        ICollection <Worker> Workers { get; set; }
    }
}
