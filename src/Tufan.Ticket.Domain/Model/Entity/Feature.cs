namespace Tufan.Ticket.Domain.Model.Entity
{
    public class Feature
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public object Description { get; set; }
        public bool IsPromoted { get; set; }
        public object BackColor { get; set; }
        public object ForeColor { get; set; }
    }
}