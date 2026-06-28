using System.Net;

namespace Proauto.Models
{
    public class Associate
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string CPF { get; set; }
        public required string Phone { get; set; }


        public Vehicle? Vehicle { get; set; }
        public  Address? Address { get; set; }
    }
}