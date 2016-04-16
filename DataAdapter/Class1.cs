using System;
using System.Data.Entity;

namespace DataAdapter
{
    public enum TrainType
    {
        passanger,
        commuter,
        freight
    }

    internal class Train
    {
        public Guid ID { get; set; }
        public string StationFrom { get; set; }
        public DateTime Departure { get; set; }
        public string StationTo { get; set; }
        public DateTime Arrival { get; set; }
        public TrainType Type { get; set; }
    }

    internal class DataContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }
    }
}
