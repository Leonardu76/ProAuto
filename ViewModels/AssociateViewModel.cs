namespace Proauto.ViewModels
{
    public class AssociateViewModel
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string CPF { get; set; }
        public required string Phone { get; set; }
        public required string Plate { get; set; }

        // endereço editável
        public required string Street { get; set; }
        public required string Number { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set; }
    }
}