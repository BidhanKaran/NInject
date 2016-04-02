using NInjectExample.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NInjectExample.Model.Interfaces;

namespace NInjectExample.ViewModel
{
    class CustomerViewModel : ICustomerViewModel
    {
        ICustomer _newCustomer;
        ICustomer _selectedCustomer;
        ObservableCollection<ICustomer> _customers;
        public ObservableCollection<ICustomer> Customers
        {
            get
            {
                return _customers;
            }

            set
            {
                _customers = value;
            }
        }

        public ICustomer NewCustomer
        {
            get
            {
                return _newCustomer;
            }

            set
            {
                _newCustomer = value;
            }
        }

        public ICustomer SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }

            set
            {
                _selectedCustomer = value;
            }
        }

        public string NewCustomerName
        {
            get
            {
                return _newCustomer.Name;
            }

            set
            {
                _newCustomer.Name = value;
            }
        }
        public string NewCustomerAddress
        {
            get { return _newCustomer.Address; }
            set { _newCustomer.Address = value; }
        }
        public string NewCustomerPhoneNumber
        {
            get { return _newCustomer.PhoneNumber; }
            set { _newCustomer.PhoneNumber = value; }
        }
        public bool AddCustomer()
        {
            Customers.Add(NewCustomer);
            return true;
        }

        public bool DeleteCustomer()
        {
            if (Customers.Contains(SelectedCustomer))
            {
                Customers.Remove(SelectedCustomer);
                return true;
            }
            return false;
        }
    }
}
