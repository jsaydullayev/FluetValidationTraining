using FluetValidationTraining.Entity;
using System.ComponentModel.DataAnnotations;

namespace FluetValidationTraining.Models
{
    public class CreateUserModel
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public byte[]? Age { get; set; }
        public Adress? UserAdress { get; set; }
    }
}
