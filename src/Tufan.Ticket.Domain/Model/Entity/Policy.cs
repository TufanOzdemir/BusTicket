namespace Tufan.Ticket.Domain.Model.Entity
{
    public class Policy
    {
        public object MaxSeats { get; set; }
        public object MaxSingle { get; set; }
        public int MaxSingleMales { get; set; }
        public int MaxSingleFemales { get; set; }
        public bool MixedGenders { get; set; }
        public bool GovId { get; set; }
        public bool Lht { get; set; }
    }
}