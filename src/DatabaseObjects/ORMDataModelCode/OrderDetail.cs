using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace InventoryXPO
{

    public partial class OrderDetail
    {
        public OrderDetail() : base(Session.DefaultSession) { }
        public OrderDetail(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
         
    }

}
