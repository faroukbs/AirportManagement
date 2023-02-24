using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace AM.Core.Services
{
    public interface IFlightService
    {
        IList<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        /// <summary>
        /// return destinataion for gived plane 
        /// </summary>
        /// <param name="plane"></param>
        /// <returns></returns>
        public IEnumerable<object> ShowFlightDetails(Plane plane);
        public int GetWeeklyFlightNumber(DateTime date);

        public double GetDurationAverage(String destination);

        public IEnumerable<object> SortFlights();

        public IEnumerable<object> GetThreeOlderTravellers(Flight vol);
        public void ShowGroupedFlights();
    }
}
