using SwellSpot.Core;
using System.Collections.Generic;

namespace SwellSpot.Data
{
    public interface ISpotData
    {
        int Commit();
        IEnumerable<SpotSwell> GetSpots();
        SpotSwell GetSpot(int id);
    }
}