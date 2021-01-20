using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace InventoryXPO
{

    public partial class Order
    {
        public Order(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        //OrderStatusType fOrderStatus;
        //[ValueConverter(typeof(InventoryXPO.Tools.OrderStatusTypeValueConverter))]
        //[NonPersistent]
        //public OrderStatusType OrderStatus
        //{
        //    get { return fOrderStatus; }
        //    set { SetPropertyValue<OrderStatusType>(nameof(OrderStatus), ref fOrderStatus, value); }
        //}

    }

}
