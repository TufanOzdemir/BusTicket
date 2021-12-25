using System;

namespace Tufan.Ticket.Domain.Model.Entity
{
    public class Stop
    {
        public string Name { get; set; }
        public string Station { get; set; }
        public DateTime Time { get; set; }
        public bool IsOrigin { get; set; }
        public bool IsDestination { get; set; }
    }
}