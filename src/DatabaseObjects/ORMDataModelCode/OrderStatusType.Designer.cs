﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace InventoryXPO
{

    [NonPersistent]
    public partial class OrderStatusType : XPObject
    {
        short fOrderStatus;
        public short OrderStatus
        {
            get { return fOrderStatus; }
            set { SetPropertyValue<short>(nameof(OrderStatus), ref fOrderStatus, value); }
        }
        string fOrderStatusAsText;
        public string OrderStatusAsText
        {
            get { return fOrderStatusAsText; }
            set { SetPropertyValue<string>(nameof(OrderStatusAsText), ref fOrderStatusAsText, value); }
        }
        [Association(@"OrderReferencesOrderStatusType")]
        public XPCollection<Order> Orders { get { return GetCollection<Order>(nameof(Orders)); } }
    }

}
