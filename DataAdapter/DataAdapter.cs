using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapter
{
   public class DataBase
    {
        private  DataContext DB = new DataContext();

        public int GetCount() { return DB.Trains.Count(); }

        public void AddNew(string From, DateTime Dep, string To, DateTime Arr)
        {
            DB.Trains.Add(new Train() { StationFrom = From, Departure = Dep, StationTo = To, Arrival = Arr });
            DB.SaveChanges();
        }
    }
}
