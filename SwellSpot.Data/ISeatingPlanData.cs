using SwellSpot.Core;
using System.Collections.Generic;

namespace SwellSpot.Data
{
    public interface ISeatingPlanData
    {
        int Commit();
        IEnumerable<SeatingPlan> GetSeatingPlans();
        SeatingPlan GetSeatingPlan(int id);
    }
}