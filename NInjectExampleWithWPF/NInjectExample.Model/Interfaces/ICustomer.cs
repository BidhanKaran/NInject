using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectExample.Model.Interfaces
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        Guid CustomerID { get; set; }
    }
}
