using SwellSpot.Core;
using System.Collections.Generic;

namespace SwellSpot.Data
{
    public interface IAddressData
    {
        IEnumerable<Address> GetAddresses();
        Address GetAddress(int id);
        int Commit();
    }
}