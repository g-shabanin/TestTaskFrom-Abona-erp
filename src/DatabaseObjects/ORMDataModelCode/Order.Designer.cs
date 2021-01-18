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

    public partial class Order : XPObject
    {
        string fProductName;
        public string ProductName
        {
            get { return fProductName; }
            set { SetPropertyValue<string>(nameof(ProductName), ref fProductName, value); }
        }
        DateTime fOrderDate;
        public DateTime OrderDate
        {
            get { return fOrderDate; }
            set { SetPropertyValue<DateTime>(nameof(OrderDate), ref fOrderDate, value); }
        }
        decimal fFreight;
        public decimal Freight
        {
            get { return fFreight; }
            set { SetPropertyValue<decimal>(nameof(Freight), ref fFreight, value); }
        }
        Customer fCustomer;
        [Association(@"CustomerOrders")]
        public Customer Customer
        {
            get { return fCustomer; }
            set { SetPropertyValue<Customer>(nameof(Customer), ref fCustomer, value); }
        }
        string fOrderNum;
        [DevExpress.Xpo.DisplayName(@"Order Number")]
        public string OrderNum
        {
            get { return fOrderNum; }
            set { SetPropertyValue<string>(nameof(OrderNum), ref fOrderNum, value); }
        }
        OrderStatusType fOrderStatus;
        [Association(@"OrderReferencesOrderStatusType")]
        [DevExpress.Xpo.DisplayName(@"Order Status")]
        public OrderStatusType OrderStatus
        {
            get { return fOrderStatus; }
            set { SetPropertyValue<OrderStatusType>(nameof(OrderStatus), ref fOrderStatus, value); }
        }
        [Association(@"OrderDetailReferencesOrder")]
        public XPCollection<OrderDetail> OrderDetails { get { return GetCollection<OrderDetail>(nameof(OrderDetails)); } }
    }

}
