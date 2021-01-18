using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace InventoryXPO
{

    public partial class ItemInStock
    {
        public ItemInStock() : base(Session.DefaultSession) { }
        public ItemInStock(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
