using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryXpo {

    public class Customer : XPObject {

        public Customer(Session session) : base(session) {  }
        string fFirstName;
        public string FirstName {
            get { return fFirstName; }
            set { SetPropertyValue(nameof(FirstName), ref fFirstName, value); }
        }
        string fLastName;
        public string LastName {
            get { return fLastName; }
            set { SetPropertyValue(nameof(LastName), ref fLastName, value); }
        }
        [PersistentAlias("Concat(FirstName, ' ', LastName)")]
        public string ContactName {
            get { return string.Concat(FirstName, " ", LastName); }
        }

        [Association("CustomerOrders", typeof(Order))]
        public IList<Order> Orders {
            get { return GetList<Order>(nameof(Orders)); }
        }


    }

}
