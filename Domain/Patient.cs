using HospitalOnionArchitecture.Domain.Core;
using System;

namespace Domain
{
    class Patient
    {
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

    }
}
