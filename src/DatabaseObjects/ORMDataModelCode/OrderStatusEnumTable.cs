﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace InventoryXPO
{

    public partial class OrderStatusEnumTable
    {
        public OrderStatusEnumTable() : base(Session.DefaultSession) { }
        public OrderStatusEnumTable(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
