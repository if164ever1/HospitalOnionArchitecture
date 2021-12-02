
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalOnionArchitecture.Domain.Core
{
    public class User
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public BaseEntity BaseEntity { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
