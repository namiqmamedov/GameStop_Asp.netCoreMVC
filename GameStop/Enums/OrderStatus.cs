using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Enums
{
    public enum OrderStatus
    {
        Pending = 1,
        Accepted,
        Rejected,
        Shipped,
        Courier
    }
}
