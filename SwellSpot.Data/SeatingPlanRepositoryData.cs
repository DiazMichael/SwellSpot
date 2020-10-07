using SwellSpot.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Data
{
    public class SeatingPlanRepositoryData : ISeatingPlanData
    {
        private readonly SwellSpotDbContext db;

        public SeatingPlanRepositoryData(SwellSpotDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
            return db.SaveChanges();
        }

        public SeatingPlan GetSeatingPlan(int id)
        {
            return db.SeatingPlans.Find(id);
        }

        public IEnumerable<SeatingPlan> GetSeatingPlans()
        {
            return db.SeatingPlans;
        }
    }
}
