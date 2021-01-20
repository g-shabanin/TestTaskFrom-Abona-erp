using DevExpress.Xpo.Metadata;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace InventoryXPO.Tools
{
    public class OrderStatusTypeValueConverter : ValueConverter
    {
        public override Type StorageType
        {
            get { return typeof(Int32); }
        }

        public override object ConvertToStorageType(object value)
        {
            if (!(value is string)) return null;
            int result = 1;
            using (UnitOfWork uow = new UnitOfWork())
            {
                OrderStatusEnumTable orderStatusEnumTable = uow.Query<OrderStatusEnumTable>().FirstOrDefault(c => c.OrderStatusAsText == (string)value);
                result = orderStatusEnumTable.Value;
            }
            return result;
        }

        public override object ConvertFromStorageType(object value)
        {
            if (!(value is int)) return null;
            string result= "";
            using (UnitOfWork uow = new UnitOfWork())
            {
                OrderStatusEnumTable orderStatusEnumTable = uow.Query<OrderStatusEnumTable>().FirstOrDefault(c => c.Value == (int)value); 
                result = orderStatusEnumTable.OrderStatusAsText;
            }
            return result;
        }
    }
}
