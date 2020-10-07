using SwellSpot.Core;
using System.Collections.Generic;

namespace SwellSpot.Data
{
    public interface IVisitData
    {
        int Commit();
        IEnumerable<Visit> GetVisits();
        Visit GetVisit(int id);
    }
}