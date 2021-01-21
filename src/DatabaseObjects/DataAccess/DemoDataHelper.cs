using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryXPO
{
    public static class DemoDataHelper
    {
        private static readonly string[] firstNames = new string[] {
            "Peter", "Ryan", "Richard", "Tom", "Mark", "Steve",
            "Jimmy", "Jeffrey", "Andrew", "Dave", "Bert", "Mike",
            "Ray", "Paul", "Brad", "Carl", "Jerry" };
        private static readonly string[] lastNames = new string[] {
            "Dolan", "Fischer", "Hamlett", "Hamilton", "Lee",
            "Lewis", "McClain", "Miller", "Murrel", "Parkins",
            "Roller", "Shipman", "Bailey", "Barnes", "Lucas", "Campbell" };
        private static readonly string[] itemNames = new string[] {
            "Chai", "Chang", "Aniseed Syrup", "Chef Anton's Cajun Seasoning",
            "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread",
            "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce",
            "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora",
            "Konbu", "Tofu", "Genen Shouyu", "Pavlova", "Alice Mutton",
            "Carnarvon Tigers", "Teatime Chocolate Biscuits",
            "Sir Rodney's Marmalade", "Sir Rodney's Scones",
            "Gustaf's Knäckebröd", "Tunnbröd", "Guaraná Fantástica",
            "NuNuCa Nuß-Nougat-Creme", "Gumbär Gummibärchen",
            "Schoggi Schokolade", "Rössle Sauerkraut", "Thüringer Rostbratwurst",
            "Nord-Ost Matjeshering", "Gorgonzola Telino", "Mascarpone Fabioli",
            "Geitost", "Sasquatch Ale", "Steeleye Stout", "Inlagd Sill",
            "Gravad lax", "Côte de Blaye", "Chartreuse verte",
            "Boston Crab Meat", "Jack's New England Clam Chowder",
            "Singaporean Hokkien Fried Mee", "Ipoh Coffee",
            "Gula Malacca", "Rogede sild", "Spegesild", "Zaanse koeken",
            "Chocolade", "Maxilaku", "Valkoinen suklaa", "Manjimup Dried Apples",
            "Filo Mix", "Perth Pasties", "Tourtière", "Pâté chinois",
            "Gnocchi di nonna Alice", "Ravioli Angelo", "Escargots de Bourgogne",
            "Raclette Courdavault", "Camembert Pierrot", "Sirop d'érable",
            "Tarte au sucre", "Vegie-spread", "Wimmers gute Semmelknödel",
            "Louisiana Fiery Hot Pepper Sauce", "Louisiana Hot Spiced Okra",
            "Laughing Lumberjack Lager", "Scottish Longbreads",
            "Gudbrandsdalsost", "Outback Lager", "Flotemysost",
            "Mozzarella di Giovanni", "Röd Kaviar", "Longlife Tofu",
            "Rhönbräu Klosterbier", "Lakkalikööri", "Original Frankfurter grüne Soße" };
        private static readonly Random Random = new Random(0);

        public static void Seed(UnitOfWork uow)
        {
            #region // OrderStatusEnumTable
            int orderStatusTypeCount = uow.Query<OrderStatusEnumTable>().Count();
            if (orderStatusTypeCount <= 0)
            {
                OrderStatusEnumTable orderStatusType = new OrderStatusEnumTable(uow) { Value = 1, OrderStatusAsText = "New" };
                orderStatusType = new OrderStatusEnumTable(uow) { Value = 2, OrderStatusAsText = "In processing" };
                orderStatusType = new OrderStatusEnumTable(uow) { Value = 3, OrderStatusAsText = "Paid" };
                orderStatusType = new OrderStatusEnumTable(uow) { Value = 4, OrderStatusAsText = "Completed" };
                uow.CommitChanges();
            }

            #endregion

            int itemCount = uow.Query<Item>().Count();
            #region // Item
            if (orderStatusTypeCount <= 0)
            {
                for (int i = 0; i < itemNames.Length; i++)
                {
                    Item item = new Item(uow)
                    {
                        ItemName = itemNames[i],
                        ItemPriceInStock = Decimal.Round((decimal)NextDouble(Random, 0.10, 100.99), 2)
                    };
                }
                uow.CommitChanges();
            }
            #endregion


            #region // Customers and Orders

            int ordersCnt = uow.Query<Order>().Count();
            if (ordersCnt <= 0)
            {
                var names = new KeyValuePair<string, string>[firstNames.Length * lastNames.Length];
                for (int i = 0; i < firstNames.Length * lastNames.Length; i++)
                {
                    int j = Random.Next(i + 1);
                    names[i] = names[j];
                    names[j] = new KeyValuePair<string, string>(firstNames[i / lastNames.Length], lastNames[i % lastNames.Length]);
                }
                foreach (var t in names)
                {
                    CreateCustomer(uow, t.Key, t.Value);
                }
            }
            #endregion


            uow.CommitChanges();
        }

        private static void CreateCustomer(UnitOfWork uow, string firstName, string lastName)
        {
            Customer customer = new Customer(uow);
            customer.FirstName = firstName;
            customer.LastName = lastName;
            int countOrderOfCustomer = Random.Next(1, 8);
            for (int i = 0; i < countOrderOfCustomer; i++)
            {
                OrderStatusEnumTable orderStatusTypeEnum = (OrderStatusEnumTable)uow.GetObjectByKey(typeof(OrderStatusEnumTable), Random.Next(1, 4));
                OrderStatusType orderStatusType = new OrderStatusType() { Key = orderStatusTypeEnum.Value, OrderStatus = orderStatusTypeEnum.OrderStatusAsText };
                Order order = new Order(uow);


                order.OrderDate = new DateTime(Random.Next(2014, 2024), Random.Next(1, 12), Random.Next(1, 28));
                order.Customer = customer;
                order.OrderStatus = orderStatusType.OrderStatus;

                char randomChar = (char)Random.Next('A', 'Z');
                order.OrderNum = String.Format("{0} - {1}{2}{3}{4}{5}{6}{7}{8}",
                    randomChar,
                    Random.Next(1, 9),
                    Random.Next(1, 9),
                    Random.Next(1, 9),
                    Random.Next(1, 9),
                    Random.Next(1, 9),
                    Random.Next(1, 9),
                    Random.Next(1, 9),
                    Random.Next(1, 9)
                    );

                for (int j = 0; j < Random.Next(1, 10); j++)
                {
                    Item item = (Item)uow.GetObjectByKey(typeof(Item), Random.Next(1, itemNames.Length - 1));
                    OrderDetail orderDetail = new OrderDetail(uow);
                    orderDetail.Order = order;
                    orderDetail.OrderDetailQuantity = (short)Random.Next(1, 100);
                    if (Random.Next(1, 100) % 2 == 0)
                    {
                        orderDetail.OrderDetailPrice = item.ItemPriceInStock;
                    }
                    else
                    {
                        orderDetail.OrderDetailPrice = item.ItemPriceInStock + 3;
                    }
                  
                    orderDetail.Items.Add(item);
                }
            }
        }
        public static float NextFloat(Random random)
        {
            double mantissa = (random.NextDouble() * 2.0) - 1.0;
            // choose -149 instead of -126 to also generate subnormal floats (*)
            double exponent = Math.Pow(2.0, random.Next(-126, 128));
            return (float)(mantissa * exponent);
        }

        public static double NextDouble(
        this Random random,
        double minValue,
        double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}
