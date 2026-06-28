namespace Proauto.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public required  string Plate { get; set; }

        public int AssociateId { get; set; }
        public   Associate? Associate { get; set; }
    }
}