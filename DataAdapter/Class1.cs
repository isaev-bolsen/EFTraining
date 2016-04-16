using System;
using System.Data.Entity;

namespace DataAdapter
{
    internal class Train
    {
        public string StationFrom { get; set; }
        public DateTime Departure { get; set; }
        public string StationTo { get; set; }
        public DateTime Arrival { get; set; }
    }

    internal class DataContext : DbContext
    {
        internal DbSet<Train> Trains { get; set; }
    }
}
