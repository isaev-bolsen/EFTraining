using System;
using System.Linq;

namespace DataAdapter
{
    public class DataBase
    {
        public int GetCount()
        {
            using (DataContext DB = new DataContext())
                return DB.Trains.Count();
        }

        public void AddNew(string From, DateTime Dep, string To, DateTime Arr)
        {
            using (DataContext DB = new DataContext())
            {
                DB.Trains.Add(new Train()
                {
                    StationFrom = From,
                    Departure = Dep,
                    StationTo = To,
                    Arrival = Arr,
                    ID = Guid.NewGuid()
                });
                DB.SaveChanges();
            }
        }
    }
}