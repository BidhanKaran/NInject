using NInjectExample.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectExample.Model
{
    public class Customer : ICustomer
    {
        string _name;
        string _address;
        string _phoneNumber;
        Guid _customerID;
        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public Guid CustomerID
        {
            get
            {
                return _customerID;
            }

            set
            {
                _customerID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
            }
        }
    }
}
