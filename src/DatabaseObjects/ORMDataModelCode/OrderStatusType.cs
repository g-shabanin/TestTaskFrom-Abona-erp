using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace InventoryXPO
{

    public partial class OrderStatusType
    {
        int fKey;
        public int Key
        {
            get { return fKey; }
            set { fKey = value; }
        }


        string fOrderStatus;
        public string OrderStatus
        {
            get { return fOrderStatus; }
            set { fOrderStatus = value; }
            //set { SetPropertyValue<string>(nameof(OrderStatus), ref fOrderStatus, value); }
        }
        //public OrderStatusType() : base(Session.DefaultSession) { }
        //public OrderStatusType(Session session) : base(session) { }
        ////public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
