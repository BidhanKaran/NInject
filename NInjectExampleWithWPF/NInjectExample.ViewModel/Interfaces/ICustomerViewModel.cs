using NInjectExample.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectExample.ViewModel.Interfaces
{
    public interface ICustomerViewModel
    {
        ObservableCollection<ICustomer> Customers { get; set; }
        bool AddCustomer();
        bool DeleteCustomer();
    }
}
