using SwellSpot.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Data
{
    public class AddressRepositoryData : IAddressData
    {
        private readonly SwellSpotDbContext db;

        public AddressRepositoryData(SwellSpotDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
            return db.SaveChanges();
        }

        public Address GetAddress(int id)
        {
            return db.Addresses.Find(id);
        }

        public IEnumerable<Address> GetAddresses()
        {
            return db.Addresses;
        }
    }
}
