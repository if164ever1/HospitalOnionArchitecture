using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalOnionArchitecture.Domain.Core
{
    public class BaseEntity
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime RegistrationDate
        {   
            get => RegistrationDate.Date;
            set 
            {
                RegistrationDate = DateTime.Today.Date;
            }
        }
    }
}
